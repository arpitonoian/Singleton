using System;

namespace SingletonDemo
{
    public sealed class CounterService
    {
        private static int count = 0;
        private static CounterService instance = null;
        public static CounterService GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new CounterService();
                return instance;
            }
        }

        private CounterService()
        {

        }

        public int Add()
        {
            count++;
            return count;
        }

        public void Print()
        {
            Console.WriteLine(count);
        }
    }
}
