using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSelfTest_ArraysAndLists
{
    public class ArrayListIterator
    {
        public static string[] stringTogetherASentence = new string[] { "I", "Love", "C#", "Programming" };

        public static void WriteSentence()
        {
            foreach (string s in stringTogetherASentence)
            {
                Console.Write($"{s} ");
            }
        }
    }
}
