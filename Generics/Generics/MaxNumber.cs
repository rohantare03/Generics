using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class MaxNumber<K> where K : IComparable 
   {
        public K MaxNum(K Value1, K Value2, K Value3, K Value4, K Value5)
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0 && Value1.CompareTo(Value4) > 0 && Value1.CompareTo(Value5) > 0)
            {
                Console.WriteLine("Maximum value :" + Value1);
            }
            else if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0 && Value2.CompareTo(Value4) > 0 && Value2.CompareTo(Value5) > 0)
            {
                Console.WriteLine("Maximum Value :" + Value2);
            }
            else if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0 && Value3.CompareTo(Value4) > 0 && Value3.CompareTo(Value5) > 0)
            {
                Console.WriteLine("Maximum Value :" + Value3);
            }
            else if (Value4.CompareTo(Value1) > 0 && Value4.CompareTo(Value2) > 0 && Value4.CompareTo(Value3) > 0 && Value4.CompareTo(Value5) > 0)
            {
                Console.WriteLine("Maximum Value :" + Value4);
            }
            else if (Value5.CompareTo(Value1) > 0 && Value5.CompareTo(Value2) > 0 && Value5.CompareTo(Value3) > 0 && Value5.CompareTo(Value4) > 0)
            {
                Console.WriteLine("Maximum Value :" + Value5);
            }
            return Value1;
        }
    }
}
