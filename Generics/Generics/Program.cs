// See https://aka.ms/new-console-template for more information
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            string MaximumString = maxNumber.MaximumString("Apple", "Kiwi", "Watermelon");
            Console.WriteLine("Maximum String Value is " + MaximumString);

        }
    }
}
