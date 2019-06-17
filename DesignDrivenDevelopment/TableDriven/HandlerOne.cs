using System;

namespace TableDriven
{
    public class HandlerOne : IHandler
    {
        public void PrintNumber(int number)
        {
            Console.WriteLine($"This is {number}");
        }
    }
}
