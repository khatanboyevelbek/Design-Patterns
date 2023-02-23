namespace BuilderPattern.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Steel { get; set; }
        public string Aluminum { get; set; }
        public string Magnesium { get; set; }
        public string Copper { get; set; }
        public string Plastics { get; set; }
        public string Glass { get; set; }
        public string Rubber { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Name} is ready");
        }

    }
}
