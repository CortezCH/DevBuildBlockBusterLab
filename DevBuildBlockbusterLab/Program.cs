using System;

namespace DevBuildBlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBuster blockBuster = new BlockBuster();

            Console.WriteLine("Welcome to GC Blockbuster!");
            blockBuster.Checkout();

            blockBuster.PlayAllMovies();
        }
    }
}
