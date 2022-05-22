// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            double MaximumNumber = maxNumber.MaximumFloat(111.3, 52.43, 89.345);
            Console.WriteLine("Maximum Float Number is " + MaximumNumber);

        }
    }
}
