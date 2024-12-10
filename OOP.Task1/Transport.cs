using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class Transport
    {
        private int _maxSpeed;
        public string Brand { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
                if(value > 110)
                {
                    Console.WriteLine("Sürət öldürür!");
                }
                else
                {
                    Console.WriteLine("Belə davam edin!");
                }
            }
        }
    }
}
