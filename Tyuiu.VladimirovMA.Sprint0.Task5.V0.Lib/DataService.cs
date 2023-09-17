using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VladimirovMA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int x, int y)
        {
            return (x + y);
        }
        public static int Subtraction(int x, int y)
        {
            return (x - y);
        }
        public static int Multiplication(int x, int y)
        {
            return (x * y);
        }
        public static int Division(int x, int y)
        {
            if(y == 0)
            {
                Console.WriteLine("Переменная y = {0} на ноль нельзя делить");
                return (-1);
            }
            else
            {
                return (x / y);
            }
        }
    }
}
