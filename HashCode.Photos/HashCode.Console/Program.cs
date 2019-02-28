using System;
using HashCode.Photos;

namespace HashCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var runner = new Runner();

            runner.Run("input/b_lovely_landscapes.txt", "../../../output/b_lovely_landscapes.out");
        }
    }
}
