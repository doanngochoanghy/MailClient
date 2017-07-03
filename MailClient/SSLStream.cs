using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
namespace MailClient
{
    class SSLStream
    {
        /// <summary>
        /// Đọc dữ liệu gửi từ server về
        /// </summary>
        /// <param name="sslStream"></param>
        public static string ReadMessage(SslStream sslStream)
        {
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            //string messageData;
            int bytes;
            bytes = sslStream.Read(buffer, 0, buffer.Length);

            // Use Decoder class to convert from bytes to UTF8
            // in case a character spans two buffers.
            Decoder decoder = Encoding.UTF8.GetDecoder();
            char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
            decoder.GetChars(buffer, 0, bytes, chars, 0);
            messageData.Append(chars);
            //messageData = Encoding.UTF8.GetString(buffer);
            //int bytes = -1;
            //do
            //{
            //    // Read the client's test message.
            //    bytes = sslStream.Read(buffer, 0, buffer.Length);

            //    // Use Decoder class to convert from bytes to UTF8
            //    // in case a character spans two buffers.
            //    Decoder decoder = Encoding.UTF8.GetDecoder();
            //    char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
            //    decoder.GetChars(buffer, 0, bytes, chars, 0);
            //    messageData.Append(chars);
            //    // Check for EOF or an empty message.
            //    if (messageData.ToString().IndexOf("\r\n") != -1)
            //    {
            //        break;
            //    }
            //    } while (bytes != 0);
            return messageData.ToString();
        }
        /// <summary>
        /// Gửi message tới server
        /// </summary>
        /// <param name="sslStream"></param>
        /// <param name="message"></param>
        public static void WriteMessage(SslStream sslStream, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            sslStream.Write(bytes);
            sslStream.Flush();
        }
    }
}
