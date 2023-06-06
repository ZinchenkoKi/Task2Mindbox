using System;

namespace Task2
{
    public class GeometricShape
    {
        public double Area(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "The value cannot be less than one.");
            }
            else
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return RoundResult(area, 6);
            }
        }

        public double Area(double first, double second, double third)
        {
            if (!IsExist(first, second, third))
            {
                throw new ArgumentException();
            }
            else
            {
                double halfMeter = (first + second + third) / 2;
                double area = Math.Sqrt(halfMeter * (halfMeter - first) * (halfMeter - second) * (halfMeter - third));
                return RoundResult(area, 6);
            } 
        }

        public bool IsRectangular(double first, double second, double third)
        {
            if (!IsExist(first, second, third))
            {
                throw new ArgumentException();
            }
            else
            {
                return Math.Pow(first,2) + Math.Pow(second, 2) == Math.Pow(third, 2);
            }
        }

        private double RoundResult(double value, int roundingValue)
        {
            return Math.Round(value, roundingValue);
        }

        private bool IsExist(double a, double b, double c)
        {
           return a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0;
        }
    }
}
