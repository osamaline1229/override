using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal abstract class shape
    {
        public string Name;

        public shape(string name)
        {
            this.Name = name;
        }

        public abstract void circleArea();

        public void circleRectandular()
        {
            Console.WriteLine("printing something");
        }
        public override bool Equals(object? obj)
        {
             shape animal2 = obj as shape;
            if (animal2 == null) { return false; }
            return this.Name == ((shape)obj).Name;
        }



    }


    internal  class Circle : shape  // Derived class (child) 
    {
        int lenght;
        int wight;
        
        public Circle(string name, int lenght, int wight) : base(name)
        {
            this.lenght = lenght;
            this.wight = wight;
            
        }

        public void getShapeInfo()
        {
            Console.WriteLine(this.Name + " " + lenght + " " + wight);
        }

        public override void circleArea()
        {
            Console.WriteLine("sound of Dog");
            
            
        }





    }
}
   
    

       

