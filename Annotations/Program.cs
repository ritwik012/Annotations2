using System;

namespace Annotations
{
    class Program
    {
        static void Main(string[] args)
        {
            NewAttribute.AttributeDisplay(typeof(Employer));
            Console.WriteLine();
            NewAttribute.AttributeDisplay(typeof(Employee));
            Console.ReadLine();
        }
    }
}