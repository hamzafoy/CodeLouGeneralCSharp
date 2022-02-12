using System;
using CodeLouisvilleLibrary;

namespace FebruaryDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleAppBase.Prompt4YesNo("Anta Tafhamu? ");//Anta Tafhamu is 'Arabic' for 'Do you understand?'
            if (doesThisMakeSense)
                Console.WriteLine("I have successfully understood");
            else
                Console.WriteLine("I have not successfully understood the assignment!");
        }
    }
}