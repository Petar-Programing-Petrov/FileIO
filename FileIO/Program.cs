using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Created path and path2 actually pointing to the project folder where the solution is found by going 4 folders out
            string path = @"..\..\..\..\ToDo.txt";
            string path2 = @"..\..\..\..\BuisinessCard.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Learning systemIO");
                streamWriter.WriteLine("or do I ? ");
            }
           
            BusinessCardCreator(path2);

            BuissinesCardReader(path2);
            Console.WriteLine();
            BuissinesCardReader(path);

        }
        /// <summary>
        /// Method that takes a string with the path where to store the created txt file
        /// </summary>
        /// <param name="path"></param>
        public static void BusinessCardCreator(string path)
        {
            using (StreamWriter buisinessCard = new StreamWriter(path))
            {
                buisinessCard.WriteLine("This is my business card!!!");
            }
        }
        /// <summary>
        /// Method that takes a string with the path and reads a txt file in the given path
        /// </summary>
        /// <param name="path"></param>
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
