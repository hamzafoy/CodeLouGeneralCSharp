using System;
using CodeLouisvilleLibrary;

namespace FebruaryDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleAppBase.Prompt4YesNo("Anta Tafhamu? ");
            if (doesThisMakeSense)
                Console.WriteLine("I am successful");
            else
                Console.WriteLine("I am unsuccessful");
        }
    }
}