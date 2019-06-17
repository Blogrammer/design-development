using System;

namespace TableDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                new HandlerController().Print(i); 
            }

            Console.ReadLine();
        }
    }
}
