using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\ToDo.txt";
            string path2 = @"..\..\..\..\BuisinessCard.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Learning systemIO");
                streamWriter.WriteLine("or do I ? ");
            }
            //using (StreamReader streamReader = new StreamReader(path))
            //{

            //    Console.WriteLine(streamReader.ReadToEnd());
            //}
            BusinessCardCreator(path2);

            BuissinesCardReader(path2);
            Console.WriteLine();
            BuissinesCardReader(path);

        }
        public static void BusinessCardCreator(string path)
        {
            using (StreamWriter buisinessCard = new StreamWriter(path))
            {
                buisinessCard.WriteLine("This is my business card!!!");
            }
        }
        public static void BuissinesCardReader(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string[] arrText = File.ReadAllLines(path);
                foreach (string line in arrText)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
