using System;
using System.Text;
using ConstrantsDemoLib;

namespace ConstraintsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Запуск");
            ConstraintsDemo demo = new ConstraintsDemo();
            demo.MyDemoMethod();
        }
    }
}
