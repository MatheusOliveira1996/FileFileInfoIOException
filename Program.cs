using System;
using System.IO;

namespace FileFileInfoIOException
{
    class Program
    {
        static void Main (string[] args)
        {
            string sourcePath = @"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\file1.txt";
            string targetPath = @"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
