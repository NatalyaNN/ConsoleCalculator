using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        private string? cache;
        public string Cache
        {
            get
            {
                return cache ?? "Пусто...";
            }
            set
            {
                cache += value + "\n";
            }
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }
        public void CleanCache()
        {
            cache = null;
        }
    }
}
