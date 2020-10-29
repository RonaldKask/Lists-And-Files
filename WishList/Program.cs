using System;
using System.Collections.Generic;
using System.IO;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishlist = new List<string>();
            //string filePath = @"C:\Users\opilane\data\wishlist.txt";


            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine("Enter something to your wishlist: ");
                wishlist.Add(Console.ReadLine());
            }

            string filePath = @"C:\Users\opilane\data\wishlist.txt";
            File.WriteAllLines(filePath, wishlist);

        }
    }
}
