using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public interface ICarBuilder
    {
        void CreateCar();
        void SetName();
        void SetSteel();
        void SetAluminum();
        void SetMagnesium();
        void SetCopper();
        void SetPlastics();
        void SetGlass();
        void SetRubber();
        Car GetCar();
    }
}
