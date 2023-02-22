﻿using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Factories
{
    public class CountryFactory
    {
        public static ICountry Create(string countryName)
        {
            return countryName switch
            {
                "Uzbekistan" => 
                    new Uzbekistan(capital: "Tashkent", location: "Central Asia", population: 35000000),
                "Poland" =>
                    new Poland(capital: "Warsaw", location: "Central Europe", population: 38000000)
            };
        }
    }
}
