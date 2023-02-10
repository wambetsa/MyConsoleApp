using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.AppCode
{

    public class Rectangle
    {
        // member variables
        double length;
        double width;
        string? username;

        public void Acceptdetails()
        {
            //
            Console.WriteLine("Enter username");
            username = Console.ReadLine();

            //Convert string to double
            Console.WriteLine("Enter the Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            //Convert string to double
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Username: {0}", username);
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
