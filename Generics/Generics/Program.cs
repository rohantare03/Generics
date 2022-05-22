// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 119, 23, 63, 73, 231, 56 };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            maxNumber.PrintMax();

            double[] doubleArray = { 4.55, 34.12, 56.33, 89.49, 111.71 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            maxDouble.PrintMax();

            string[] stringArray = { "Apple", "Grapes", "Banana", "Jackfruit" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            maxString.PrintMax();

        }
    }
}
