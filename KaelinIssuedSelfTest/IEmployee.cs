using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSelfTest_Interface
{
    public interface IEmployee
    {
        string Name { get; set; }
        string DoWork(int hoursPerDay);
    }
}