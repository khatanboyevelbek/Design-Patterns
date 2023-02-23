namespace BuilderPattern.Builders
{
    public class ChevroletBuilder : CarBuilder
    {
        public override void SetName()
        {
            GetCar().Name = "Chevrolet";
        }

        public override void SetAluminum()
        {
            GetCar().Aluminum = "15 kg";
        }

        public override void SetCopper()
        {
            GetCar().Copper = "14 kg";
        }

        public override void SetGlass()
        {
            GetCar().Glass = "12 kg";
        }

        public override void SetMagnesium()
        {
            GetCar().Magnesium = string.Empty;
        }

        public override void SetPlastics()
        {
            GetCar().Plastics = "18 kg";
        }

        public override void SetRubber()
        {
            GetCar().Rubber = "13 kg";
        }

        public override void SetSteel()
        {
            GetCar().Steel = "78 kg";
        }
    }
}
