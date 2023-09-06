using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHelloworld
{
    abstract class Math
    {
        protected double number1 { get; set; }
        protected double number2 { get; set; }
        protected Math(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public abstract void calculate();
    }

    class Addition : Math
    {
        public Addition(double number1, double number2) : base(number1, number2) { }
        public override void calculate()
        {
            Console.WriteLine(number1 + number2);
        }
    }

    class Subtraction : Math
    {
        public Subtraction(double number1, double number2) : base(number1, number2) { }
        public override void calculate()
        {
            Console.WriteLine(number1 - number2);
        }
    }

    class Multiplication : Math
    {
        public Multiplication(double number1, double number2) : base(number1, number2) { }
        public override void calculate()
        {
            Console.WriteLine(number1 * number2);
        }
    }

    class Division : Math
    {
        public Division(double number1, double number2) : base(number1, number2) { }
        public override void calculate()
        {
            Console.WriteLine(number1 / number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition(10, 5);
            addition.calculate();

            Subtraction subtraction = new Subtraction(10, 5);
            subtraction.calculate();

            Multiplication multiplication = new Multiplication(10, 5);
            multiplication.calculate();

            Division division = new Division(10, 5);
            division.calculate();
        }
    }
}
