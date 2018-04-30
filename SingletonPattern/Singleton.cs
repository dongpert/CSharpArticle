using System;

namespace SingletonPattern
{
    //public sealed class Singleton
    //{
    //    private static Singleton instance = null;
    //    private static readonly object padlock = new object();
    //    public int Flag { get; set; }

    //    private Singleton()
    //    {
    //        Flag = 0;
    //    }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                lock (padlock)
    //                {
    //                    if (instance == null)
    //                    {
    //                        instance = new Singleton();
    //                    }
    //                }
    //            }
    //            return instance;
    //        }
    //    }
    //}

    //public sealed class Singleton
    //{
    //    private static readonly Lazy<Singleton> lazy =
    //        new Lazy<Singleton>(() => new Singleton());

    //    public static Singleton Instance { get { return lazy.Value; } }

    //    private Singleton()
    //    {
    //    }
    //}

    sealed class Singleton
    {
        static int instanceCounter = 0;
        private static readonly Lazy<Singleton> singleInstance = new Lazy<Singleton>(() => new Singleton()); //private static Singleton singleInstance = null;  
        private Singleton()
        {
            instanceCounter++;
        }
        public static Singleton SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }
        public string LogMessage(string message)
        {
            return message;
        }
    }
}