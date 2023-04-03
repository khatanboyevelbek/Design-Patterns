using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public class Subject : ISubject
    {
        public string Name;
        private readonly List<IObserver> Subscribers;
        private readonly HashSet<string> PublishedNews;

        public Subject(string name)
        {
            this.Name = name;
            this.Subscribers = new List<IObserver>();
            this.PublishedNews = new HashSet<string>();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.Subscribers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            this.Subscribers.Remove(observer);
        }

        public void PublishNewsPost(string post)
        {
            this.PublishedNews.Add(post);
            Notify(post);
        }

        public void Notify(string publishedNews)
        {
            this.Subscribers.ForEach(subscriber =>
            {
                subscriber.Update(this, publishedNews);
            });
        }
    }
}
