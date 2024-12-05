using System;
 
namespace Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            header h = new header();
            h.foo = 1; 
            h.bar = 2; 
            Console.WriteLine(h.foo);
        }
    }
}
