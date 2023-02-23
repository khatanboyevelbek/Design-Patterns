using BuilderPattern.Builders;
using BuilderPattern.Director;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chevroletBuilder = new ChevroletBuilder();
            var carDirector = CarDirector.MakeCar(chevroletBuilder);

            Console.WriteLine(carDirector.Name);
        }
    }
}