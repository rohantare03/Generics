﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxInteger
    {
        public int Num1, Num2, Num3;
        public int MaxNumber(int Num1, int Num2, int Num3)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1;
            }
            else if (Num2.CompareTo(Num3) > 0 && Num2.CompareTo(Num1) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            return Num1;
        }
    }
}