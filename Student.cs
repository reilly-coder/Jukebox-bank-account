using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class Student
    {
        private String name;
        private static int count;
        public Student(string name)
        {
            this.name = name;
            count++;
        }

        ~Student()
        {
            count--;
        }

        public static string getCount()
        {
            return count.ToString();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
}
