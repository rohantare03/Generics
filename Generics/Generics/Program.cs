// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Maximum Number is");
            MaxNumber maxValue = new MaxNumber();
            int Max = maxValue.MaxNum(11, 55, 34, 123, 145);
            Console.WriteLine("Maximum Integer Value : " + Max);
            double Max2 = maxValue.MaxxFloat(22.3, 121.233, 66.45, 77.34, 88.227);
            Console.WriteLine("Maximum Float Value : " + Max2);
            string Max3 = maxValue.MaxxString("Apple", "Banana", "Orange", "Pineapple", "Grapes");
            Console.WriteLine("Maximum String Value : " + Max3);
        }
    }
}
