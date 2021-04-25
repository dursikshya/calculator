using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace Calculator
{
    interface ICalculator
    {
        public int Operate(Operation operation,int operationValue);
        public void Reset();
    }

    enum Operation
    {
        Addition,
        Multiplication,
        Division,
    }
    class Calc:ICalculator
    {
        private int Value { get; set; }
        // public Operation op { get; set; }
        public int Operate(Operation operation,int operationValue)
        {
            try
            {
                switch (operation)
                {
                    case Operation.Addition:
                        Value += operationValue;
                        break;
                    case Operation.Division:
                        Value /= operationValue;
                        break;
                    case Operation.Multiplication:
                        Value *= operationValue;
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            return this.Value;
        }

        public void Reset()
        {
            this.Value = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            var calc = new Calc();
            Console.WriteLine(calc.Operate(Operation.Addition,2));
            Console.WriteLine(calc.Operate(Operation.Multiplication,9));
            Console.WriteLine(calc.Operate(Operation.Division,0));

            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine("running");
            }
        }
    }
}