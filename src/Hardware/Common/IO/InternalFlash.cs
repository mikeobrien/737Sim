using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using nanoFramework.Json;

namespace Common.IO
{
    public static class InternalFlash
    {
        public static string ReadAllText(string path)
        {
            var absolutePath = GetAbsolutePath(path);

            if (!File.Exists(absolutePath)) return null;

            using var file = new FileStream(absolutePath, FileMode.Open);
            return file.ReadToEnd();
        }

        public static void WriteAllText(string path, string text)
        {
            var absolutePath = GetAbsolutePath(path);

            using var file = new FileStream(absolutePath, FileMode.OpenOrCreate);
            file.Write(text);
        }

        public static void Delete(string path)
        {
            var absolutePath = GetAbsolutePath(path);

            File.Delete(absolutePath);
        }

        private static string GetAbsolutePath(string path)
        {
            return $@"I:\{path}";
        }
    }
}
