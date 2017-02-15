using System;

namespace ConstrantsDemoLib
{
    struct RefDemo<T> where T : class
    {
        public override string ToString()
        {
            return string.Format("Структура с ограничением class: {0}", typeof(T));
        }
    }

    class ValDemo<T> where T : struct
    {
        public override string ToString()
        {
            return string.Format("Класс с ограничением struct: {0}", typeof(T));
        }
    }

    public class ConstraintsDemo
    {
        public void MyDemoMethod()
        {
            RefDemo<string> refdemo = new RefDemo<string>();
            Console.WriteLine(refdemo.ToString());

            ValDemo<int> valdemo = new ValDemo<int>();
            Console.WriteLine(valdemo.ToString());
        }
    }
}
