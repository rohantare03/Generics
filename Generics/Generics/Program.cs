// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            int MaximumNumber = maxNumber.MaxInteger(11, 55, 85);
            Console.WriteLine("Maximum Integer is " + MaximumNumber);

        }
    }
}
