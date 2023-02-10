using System;
using MyConsoleApp.AppCode;

namespace MyConsoleApp
{

    class ExecuteRectangle
    {

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}