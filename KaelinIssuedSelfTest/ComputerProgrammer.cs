using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleSelfTest_Interface;

namespace CodeLouisvilleSelfTest_ComputerProgrammer
{
    public class ComputerProgrammer: IEmployee
    {
        //Constructor
        public ComputerProgrammer(string name)
        {
            Name = name;
        }
        //Properties
        public string Name { get; set; }
        //Methods
        public string DoWork(int hoursPerDay)
        {
            return $"{Name} writes code {hoursPerDay} hours a day.";
        }
    }
}