using System;

namespace Lab2QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader reader = new DataReader();
            QuadraticEquation e = reader.quadraticEquationCoefficientReader();
            Calculator c = new Calculator(e);
            e = c.calculateDelta();
            e.printResult();
        }
    }
}
