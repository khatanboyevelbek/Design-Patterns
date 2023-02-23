namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = Singleton.Instance.GetRandomNumberInList();
            Console.WriteLine(randomNumber);
        }

        public sealed class Singleton
        {
            private static Singleton instance = null;
            private static readonly object padlock = new object();
            private static readonly Random randomizer = new Random();
            private static List<int> numberList;

            private Singleton() 
            {
                numberList = new List<int>
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9,10
                };
            }

            public static Singleton Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if(instance == null)
                        {
                            instance = new Singleton();
                        }

                        return instance;
                    }
                }
            }

            public int GetRandomNumberInList()
            {
                int randomNumber =  randomizer.Next(0, numberList.Count);
                return numberList[randomNumber];
            }
        }
    }
}