using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public class Observer : IObserver
    {
        private readonly string Name;

        public Observer(string name)
        {
            this.Name = name;
        }

        public void Update(ISubject subject, string publishedNews)
        {
            if (subject is Subject admin)
            {
                Console.WriteLine($"Hey {this.Name}! {admin.Name} published new post: {publishedNews}");
            }
        }
    }
}
