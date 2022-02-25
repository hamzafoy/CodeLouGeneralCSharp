using System;
using CodeLouisvilleSelfTest_ArraysAndLists;
using CodeLouisvilleSelfTest_ComputerProgrammer;

namespace CodeLouisvilleSelfTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayListIterator.WriteSentence();
            Console.WriteLine();
            ComputerProgrammer computerProgrammer = new ComputerProgrammer("Hamza");
            Console.WriteLine(computerProgrammer.DoWork(2));
            Console.WriteLine("Value Types are those types who directly contain a value, ex: Int32, Boolean");
            Console.WriteLine("Reference Types are those types which point to something else with value without actually containing said value");
            Console.WriteLine("Examples of reference types include Arrays & Strings");
        }
    }
}