// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxInteger maxInteger = new MaxInteger();
            int MaximumInteger = maxInteger.MaxNumber(11, 43, 56);
            Console.WriteLine("The Maximum Integer Value is " + MaximumInteger);
        }
    }
}
