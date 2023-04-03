using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject admin = new("Elbek");

            Observer observer1 = new("Jahongir");
            admin.RegisterObserver(observer1);

            Observer observer2 = new("Alisher");
            admin.RegisterObserver(observer2);

            admin.PublishNewsPost("Dapper vs EF Core");
        }
    }
}