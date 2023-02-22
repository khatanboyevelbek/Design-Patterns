using FactoryPattern.Factories;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountry uzbekistan = CountryFactory.Create("Uzbekistan");
            ICountry poland = CountryFactory.Create("Poland");

            Console.WriteLine(uzbekistan.Capital());
            Console.WriteLine(poland.Population());
        }
    }
}