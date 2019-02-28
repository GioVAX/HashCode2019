using System;
using HashCode.Photos;

namespace HashCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var photos = new PhotoReader().Read("a_example.txt");
        }
    }
}
