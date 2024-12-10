using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1.Extensions
{
    public static class CharExtension
    {
        public static bool IsNumber(this char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}
