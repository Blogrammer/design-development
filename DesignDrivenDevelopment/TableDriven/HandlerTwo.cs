using System;

namespace TableDriven
{
    public class HandlerTwo : IHandler
    {
        public void PrintNumber(int number)
        {
            Console.WriteLine($"This is {number}");
        }
    }
}
