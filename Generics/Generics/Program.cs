// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            MaxNumber<int> genericsMax = new MaxNumber<int>();
            genericsMax.MaxNum(23, 45, 67, 112, 8);

            MaxNumber<double> genericsMax2 = new MaxNumber<double>();
            genericsMax2.MaxNum(23.45, 76.44, 8.12, 174.222, 44.61);

            MaxNumber<string> genericsMax3 = new MaxNumber<string>();
            genericsMax3.MaxNum("Apple", "Orange", "Kiwi", "Watermelon", "pear");
        }
    }
}
