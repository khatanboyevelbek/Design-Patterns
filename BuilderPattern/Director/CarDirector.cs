using BuilderPattern.Builders;
using BuilderPattern.Models;

namespace BuilderPattern.Director
{
    public class CarDirector
    {
        public static Car MakeCar(CarBuilder carBuilder)
        {
            carBuilder.CreateCar();
            carBuilder.SetName();
            carBuilder.SetRubber();
            carBuilder.SetAluminum();
            carBuilder.SetCopper();
            carBuilder.SetGlass();
            carBuilder.SetMagnesium();
            carBuilder.SetPlastics();
            carBuilder.SetRubber();
            carBuilder.SetSteel();

            return carBuilder.GetCar();
        }
    }
}
