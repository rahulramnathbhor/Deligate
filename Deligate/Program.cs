using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemos
{
    public delegate int MyDelegate(int n1, int n2);
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            MyDelegate myDelegate = new MyDelegate(c.Add); // added method reference
            int result = myDelegate.Invoke(50, 40);
            Console.WriteLine(result);

        }

    }
}

