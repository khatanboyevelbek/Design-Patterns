using FactoryPattern.Factories;
using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountry uzbekistan = CountryFactory.Create(CountryList.Uzbekistan);
            ICountry poland = CountryFactory.Create(CountryList.Poland);

            Console.WriteLine(uzbekistan.Capital());
            Console.WriteLine(poland.Population());
        }
    }
}