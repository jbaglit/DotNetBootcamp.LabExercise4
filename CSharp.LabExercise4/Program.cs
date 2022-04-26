using System;

namespace CSharp.LabExercise4
{

    //Shape Area
    interface IShape
    {
        public void ComputeArea();
        public void DisplayArea();
        public string ShapeDescription
        {
            get;
            set;
        }
    }

    abstract class ShapeName
    {
        public decimal Area
        {
            get;
            set;
        }

        string _ShapeName;
        public string ShapeDescription { get => _ShapeName; set => _ShapeName = value; }
    }

    class Circle : ShapeName, IShape
    {
        public void ComputeArea()
        {
            this.ShapeDescription = "Circle";
            
            const double pi = Math.PI;
            decimal pi2 = (decimal)pi;
            decimal radius = 5.5M;

            this.Area = (radius * radius) * pi2;
        }

        public void DisplayArea()
        {
            Console.WriteLine("{0}: \n\tArea = {1} square units", ShapeDescription, Area);

        }
    }

    class Square : ShapeName, IShape
    {
        public void ComputeArea()
        {
            this.ShapeDescription = "Square";
            decimal sideLength = 5.5M;

            this.Area = (sideLength * sideLength);
        }

        public void DisplayArea()
        {
            Console.WriteLine("{0}: \n\tArea = {1} square units", ShapeDescription, Area);
        }
    }

    class Rectangle : ShapeName, IShape
    {
        public void ComputeArea()
        {
            this.ShapeDescription = "Rectangle";

            decimal length = 5.5M;
            decimal width = 11M;
            this.Area = (length * width);
        }

        public void DisplayArea()
        {
            Console.WriteLine("{0}: \n\tArea = {1} square units", ShapeDescription, Area);
        }
    }


    // Calculator
    interface ICalculator
    {
        public void Compute(decimal num1, decimal num2);
        public void DisplayAnswer();
        public string OperationType
        {
            get;
            set;
        }
    }

    abstract class Numbers
    {
        public decimal Answer
        {
            get;
            set;
        }

        decimal _Num1;
        public decimal Num1 { get => _Num1; set => _Num1 = value; }

        decimal _Num2;
        public decimal Num2 { get => _Num2; set => _Num2 = value; }

        string _OperationType;
        public string OperationType { get => _OperationType; set => _OperationType = value; }
    }

    class Addition : Numbers, ICalculator
    {
        public void Compute(decimal num1, decimal num2)
        {
            this.OperationType = "Addition";

            this.Num1 = num1;
            this.Num2 = num2;
            this.Answer = num1 + num2;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} :\n\t {1} + {2} = {3}", OperationType, Num1, Num2, Answer);
        }
    }

    class Subtraction : Numbers, ICalculator
    {
        public void Compute(decimal num1, decimal num2)
        {
            this.OperationType = "Subtraction";

            this.Num1 = num1;
            this.Num2 = num2;
            this.Answer = num1 - num2;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} :\n\t {1} - {2} = {3}", OperationType, Num1, Num2, Answer);
        }
    }

    class Multiplication : Numbers, ICalculator
    {
        public void Compute(decimal num1, decimal num2)
        {
            this.OperationType = "Multiplication";

            this.Num1 = num1;
            this.Num2 = num2;
            this.Answer = num1 * num2;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} :\n\t {1} * {2} = {3}", OperationType, Num1, Num2, Answer);
        }
    }

    class Division : Numbers, ICalculator
    {
        public void Compute(decimal num1, decimal num2)
        {
            this.OperationType = "Division";

            this.Num1 = num1;
            this.Num2 = num2;
            this.Answer = num1 / num2;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} :\n\t {1} / {2} = {3}", OperationType, Num1, Num2, Answer);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape Area
            Console.WriteLine("~Shape Area~\n");

            IShape circle = new Circle();
            circle.ComputeArea();
            circle.DisplayArea();

            IShape square = new Square();
            square.ComputeArea();
            square.DisplayArea();

            IShape rectangle = new Rectangle();
            rectangle.ComputeArea();
            rectangle.DisplayArea();

            //Calculator
            Console.WriteLine("\n\n~Basic Calculator~\n");

            ICalculator add = new Addition();
            add.Compute(5.5M, 5.5M);
            add.DisplayAnswer();

            ICalculator subtract = new Subtraction();
            subtract.Compute(11M, 5.5M);
            subtract.DisplayAnswer();

            ICalculator multiply = new Multiplication();
            multiply.Compute(5.5M, 5.5M);
            multiply.DisplayAnswer();

            ICalculator divide = new Division();
            divide.Compute(22M, 5.5M);
            divide.DisplayAnswer();

        }
    }
}
