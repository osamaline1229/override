using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : Ishape
{
//    private double lenght;
//    private double width;

//    public Rectangle(double lenght, double width)
//    {
//        this.lenght = lenght;
//        this.width = width;
//    }

//    public double CaculateArea()
//    {
//        return lenght * width;
//    }

//    public double CaculateParameter() 
//    {
//        return 2 * (lenght * width);
//    }
//}

//public class Circle : Ishape
//{
//    private 

    public double calculateArea()
    {
        return lenght;
    }
    public int CompareTo(Square? other)
    {
        if (other == null) { return 1; }

        if (this.lenght > other.lenght)
        {
            return 1;
        }
        else if(this.lenght < other.lenght)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}