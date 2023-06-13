using OOPBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oopbasice
{
    class student
    {
        public long Id;
        public string Name;
        public double grade;
        public string department;

        public void study()
        {
            Console.WriteLine("student is studing");
        }
    }
}


//public student (long id, string name, string grade, string reqistrationNumber)
//{
//    this.id = id;
//    this.name = name;
//    this.grade = grade;
//    this.department = department;
//}

//public student (long id, string name, string grade, string reqistrationNumber) : this(id, name, null, registrationNumber)
//{


//}

