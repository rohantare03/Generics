// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 119, 23, 63, 73, 231 };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            Console.WriteLine("The Maximum Integer is " + maxNumber.MaxMethod());

            double[] doubleArray = { 4.55, 34.12, 56.33, 89.49, 111.71 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            Console.WriteLine("The Maximum Float Value is " + maxDouble.MaxMethod());

            string[] stringArray = { "Apple", "Grapes", "Banana", "Jackfruit" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            Console.WriteLine("The Maximum String Value is " + maxString.MaxMethod());

        }
    }
}
