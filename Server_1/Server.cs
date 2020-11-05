using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Server_1
{
    class Server
    {
        static Hashtable clientList;

        static string message;

        static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Server ---");

            clientList = new Hashtable();

            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 6789);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        count++;
                        server.Listen(100);
                        Socket client = server.Accept();

                        byte[] userNameByte = new byte[client.Available];
                        client.Receive(userNameByte);
                        string userName = Encoding.UTF8.GetString(userNameByte);

                        clientList.Add(client, userName);
                        Console.WriteLine("Connected to " + client.RemoteEndPoint.ToString());
                        Console.WriteLine(Environment.NewLine + count + " connected");//thêm

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                        foreach (DictionaryEntry item in clientList)
                        {
                            SendNum((Socket)item.Key, count);
                        }
                    }
                }
                catch (Exception)
                {
                    IPEndPoint IP = new IPEndPoint(IPAddress.Any, 6789);
                    Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });

            listen.Start();
        }

        /// <summary>
        /// Gửi tin nhắn
        /// </summary>
        /// <param name="client"></param>
        static void SendMessage(Socket client, string userName)
        {
            client.Send(Encoding.UTF8.GetBytes("message"));

            byte[] messageData = Encoding.UTF8.GetBytes(userName + ": " + message);

            client.Send(messageData);
        }

        static void SendNum(Socket client, int count)//gửi số người onl
        {
            client.Send(Encoding.UTF8.GetBytes("numConnect"));

            byte[] messageData = Encoding.UTF8.GetBytes(Convert.ToString(count) + " people is chatting!");

            client.Send(messageData);
        }
        static void SendFile(Socket client, string fileName)
        {
            try
            {
                client.Send(Encoding.UTF8.GetBytes("file"));

                FileStream fileStream = new FileStream("G:\\Server_Data\\" + fileName, FileMode.Open);
                long fileSize = fileStream.Length;

                client.Send(Encoding.UTF8.GetBytes("file=" + fileName + ";size=" + fileSize));

                //  Tránh dữ liệu client nhận được rơi vào phần header
                Thread.Sleep(100);

                int readByte = 0;

                do
                {
                    byte[] buffer = new byte[2048];

                    readByte = fileStream.Read(buffer, 0, buffer.Length);

                    if (readByte > 0)
                    {
                        int sendByte = 0;
                        do
                        {
                            sendByte = client.Send(buffer, readByte, SocketFlags.None);
                            readByte = readByte - sendByte;

                        } while (readByte > 0);

                        readByte = sendByte;
                    }

                    fileSize = fileSize - readByte;

                } while (fileSize > 0);

                fileStream.Close();

                Console.WriteLine("Gui thanh cong \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Khong the gui file: " + fileName);
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Nhận header từ client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static string ReceiveHeader(Socket client)
        {
            string strHeader = "";

            while (true)
            {
                if (client.Available > 0)
                {
                    byte[] buffer = new byte[client.Available];
                    client.Receive(buffer);

                    strHeader = Encoding.UTF8.GetString(buffer);
                    return strHeader;
                }
            }
        }

        /// <summary>
        /// Nhận tin nhắn từ client
        /// </summary>
        /// <param name="client"></param>
        static void ReceiveMessage(Socket client)
        {
            if (client.Available > 0)
            {
                byte[] messageData = new byte[client.Available];
                string userName = "";

                client.Receive(messageData);
                message = Encoding.UTF8.GetString(messageData);

                //Console.WriteLine(message);

                //  Lấy tên user của client đã gửi
                foreach (DictionaryEntry item in clientList)
                {
                    if (item.Key == client)
                        userName = (string)item.Value;
                }
                //  Gửi cho những client còn lại
                foreach (DictionaryEntry item in clientList)
                {
                    if (item.Key != client)
                        SendMessage((Socket)item.Key, userName);
                }
            }
        }

        /// <summary>
        /// Nhận file từ client
        /// </summary>
        /// <param name="client"></param>
        /// <param name="strHeader"></param>
        static void ReceiveFile(Socket client, string strHeader)
        {
            string userName = "";

            string[] arrayName = strHeader.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //  Tên file
            string fileName = arrayName[0].Substring(arrayName[1].IndexOf("=") + 1);

            //  Kích thước file
            long fileSize = Convert.ToInt32(arrayName[1].Substring(arrayName[1].IndexOf("=") + 1));

            FileStream fileStream = new FileStream("G:\\Server_Data\\" + fileName, FileMode.Create);

            int receiveByte = 0;

            do
            {
                receiveByte = client.Available;

                if (receiveByte > 0)
                {
                    byte[] buffer = new byte[receiveByte];
                    client.Receive(buffer);
                    fileStream.Write(buffer, 0, buffer.Length);
                }

                fileSize = fileSize - receiveByte;

            } while (fileSize > 0);

            Console.WriteLine("Da nhan file " + fileName);

            fileStream.Close();

            //  Lấy tên user của client đã gửi
            foreach (DictionaryEntry item in clientList)
            {
                if (item.Key == client)
                    userName = (string)item.Value;
            }
            //  Gửi cho những client còn lại
            foreach (DictionaryEntry item in clientList)
            {
                if (item.Key != client)
                {
                    Socket socket = (Socket)item.Key;

                    string fileType = fileName.Substring(fileName.IndexOf("."));

                    //  Gửi file trực tiếp nếu là file ảnh
                    if (fileType == ".jpg" || fileType == ".png")
                        SendFile(socket, fileName);

                    else
                    {
                        socket.Send(Encoding.UTF8.GetBytes("fileName"));

                        socket.Send(Encoding.UTF8.GetBytes(userName + ";" + fileName));
                    }

                }
            }
        }

        /// <summary>
        /// Nhận dữ liệu từ client
        /// </summary>
        /// <param name="obj"></param>
        static void Receive(object obj)
        {
            Socket client = obj as Socket;

            while (true)
            {
                try
                {
                    //  Nhận header từ client
                    string strHeader = ReceiveHeader(client);

                    //  Xác định loại dữ liệu sẽ nhận được
                    if (strHeader == "message")
                        ReceiveMessage(client);

                    else if (strHeader == "close")
                    {
                        Console.WriteLine(client.RemoteEndPoint + " has been disconnected");
                        clientList.Remove(client);
                        client.Close();
                        break;
                    }

                    else
                    {
                        string[] arrayName = strHeader.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                        if (arrayName[0] == "getfile")
                            SendFile(client, arrayName[1]);
                        else
                            ReceiveFile(client, strHeader);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Khong the nhan message");
                }
            }

        }
    }
}
