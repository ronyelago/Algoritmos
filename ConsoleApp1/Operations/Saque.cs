using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Saque
{
    public class Saque
    {
        public static bool IsValid(double value)
        {
            if (value >= 20 && value != 30 && value % 10 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
