using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void Notify(string publishedNews);
    }
}
