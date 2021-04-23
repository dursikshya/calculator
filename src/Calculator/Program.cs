using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace Calculator
{
    interface ICalculator
    {
        public int Operate();
    }
    class Calc:ICalculator
    {
        public Calc(int value, string operationCode)
        {
            this.Value = value;
        }

        private int InitialValue { get; set; }
        private int Value { get; set; }
        public string op { get; set; }
        public int Operate()
        {
            int value = 0;
            try
            {
                value = InitialValue / value;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Don't divide by");
            }
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc(0,"+");
            Console.WriteLine(calc.Operate());

            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine("running");
            }
        }
    }
}