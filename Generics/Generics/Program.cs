// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            int MaximumInteger = maxNumber.MaxInteger(11, 43, 56); 
            Console.WriteLine("The Maximum Integer Value is " + MaximumInteger);
        }
    }
}
