using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2
{
    internal class Student
    {
        private int[] grades;
        public int[] Grades
        {
            get
            {
                return grades;
            }
            set
            {
                foreach (var item in value)
                {
                    if (item % 2 == 0)
                    {
                        ArrayExtension.Add(ref grades, item);
                    }
                }
            }
        }

        public Student()
        {
            grades = new int[0];
        }
    }
}
