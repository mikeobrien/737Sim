using System;
using System.IO;
using System.Text;

namespace Common.IO
{
    public static class Extensions
    {
        public static string ReadLength(this Stream stream)
        {
            var buffer = new byte[stream.Length];
            stream.Read(buffer, 0, (int)stream.Length);
            return System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        }

        public static string ReadToEnd(this Stream stream)
        {
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public static void Write(this Stream stream, string text)
        {            
            using var writer = new StreamWriter(stream);
            writer.Write(text);
        }
    }
}
