using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Poland : ICountry
    {
        private readonly string capital;
        private readonly string location;
        private readonly int population;

        public Poland(string capital, string location,
            int population)
        {
            this.capital = capital;
            this.location = location;
            this.population = population;
        }

        public string Capital()
        {
            return this.capital;
        }

        public string Location()
        {
            return this.location;
        }

        public long Population()
        {
            return this.population;
        }
    }
}
