using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class MaxNumber
   {
        public int MaxNum(int Num1, int Num2, int Num3, int Num4, int Num5)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 && Num1.CompareTo(Num4) > 0 && Num1.CompareTo(Num5) > 0)
            {
                return Num1;
            }
            else if (Num2.CompareTo(Num3) > 0 && Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num4) > 0 && Num2.CompareTo(Num5) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 && Num3.CompareTo(Num4) > 0 && Num3.CompareTo(Num5) > 0)
            {
                return Num3;
            }
            else if (Num4.CompareTo(Num3) > 0 && Num4.CompareTo(Num1) > 0 && Num4.CompareTo(Num2) > 0 && Num4.CompareTo(Num5) > 0)
            {
                return Num4;
            }
            else if (Num5.CompareTo(Num3) > 0 && Num5.CompareTo(Num2) > 0 && Num5.CompareTo(Num4) > 0 && Num5.CompareTo(Num1) > 0)
            {
                return Num5;
            }
            return Num1;
        }
        public double MaxxFloat(double Num1, double Num2, double Num3, double Num4, double Num5)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 && Num1.CompareTo(Num4) > 0 && Num1.CompareTo(Num5) > 0)
            {
                return Num1;
            }
            else if (Num2.CompareTo(Num3) > 0 && Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num4) > 0 && Num2.CompareTo(Num5) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 && Num3.CompareTo(Num4) > 0 && Num3.CompareTo(Num5) > 0)
            {
                return Num3;
            }
            else if (Num4.CompareTo(Num3) > 0 && Num4.CompareTo(Num1) > 0 && Num4.CompareTo(Num2) > 0 && Num4.CompareTo(Num5) > 0)
            {
                return Num4;
            }
            else if (Num5.CompareTo(Num3) > 0 && Num5.CompareTo(Num2) > 0 && Num5.CompareTo(Num4) > 0 && Num5.CompareTo(Num1) > 0)
            {
                return Num5;
            }
            return Num1;
        }
        public string MaxxString(string Value1, string Value2, string Value3, string Value4, string Value5)
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0 && Value1.CompareTo(Value4) > 0 && Value1.CompareTo(Value5) > 0)
            {
                return Value1;
            }
            else if (Value2.CompareTo(Value3) > 0 && Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value4) > 0 && Value2.CompareTo(Value5) > 0)
            {
                return Value2;
            }
            else if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0 && Value3.CompareTo(Value4) > 0 && Value3.CompareTo(Value5) > 0)
            {
                return Value3;
            }
            else if (Value4.CompareTo(Value3) > 0 && Value4.CompareTo(Value1) > 0 && Value4.CompareTo(Value2) > 0 && Value4.CompareTo(Value5) > 0)
            {
                return Value4;
            }
            else if (Value5.CompareTo(Value3) > 0 && Value5.CompareTo(Value2) > 0 && Value5.CompareTo(Value4) > 0 && Value5.CompareTo(Value1) > 0)
            {
                return Value5;
            }
            return Value1;
        }
   }
}
