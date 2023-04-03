using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public interface IObserver
    {
        void Update(ISubject subject, string publishedNews);
    }
}
