using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public abstract class CarBuilder : ICarBuilder
    {
        protected Car car;

        public void CreateCar()
        {
            car = new Car();
        }
        public abstract void SetName();

        public abstract void SetAluminum();

        public abstract void SetCopper();

        public abstract void SetGlass();

        public abstract void SetMagnesium();

        public abstract void SetPlastics();

        public abstract void SetRubber();

        public abstract void SetSteel();

        public Car GetCar()
        {
            return car;
        }
    }
}
