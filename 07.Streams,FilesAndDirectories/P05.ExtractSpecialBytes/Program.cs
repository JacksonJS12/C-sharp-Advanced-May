using System;
using System.IO;

namespace P05.ExtractSpecialBytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte secretCode = 243;
            XorEncrypt(
                "../../../files/img.jpg",
                "../../../files/img-encrypted.jpg",
                secretCode);

            XorEncrypt(
                "../../../files/img-encrypted.jpg",
                "../../../files/img-dencrypted.jpg",
                secretCode);
            
        }

        private static void XorEncrypt(string inputFileName, string outPutFileName, byte secretCode)
        {
            using (var input = new FileStream(inputFileName, FileMode.Open))
            {
                using (var output = new FileStream(outPutFileName, FileMode.Create))
                {
                    var buf = new byte[1024];
                    while (true)
                    {
                        var bytesRead = input.Read(buf, 0, buf.Length);
                        if (bytesRead == 0)
                            break;
                        Encrypt(buf, bytesRead, secretCode);
                        output.Write(buf, 0, bytesRead);
                    }
                }
            }
        }

        private static void Encrypt(byte[] buf,int read, byte secretCode)
        {
            for (int i = 0; i < read; i++)
            {
                buf[i] = (byte) (buf[i] ^ secretCode);
            }
        }
    }
}
