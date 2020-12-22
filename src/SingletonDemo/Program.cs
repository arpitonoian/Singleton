namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterService counterService = CounterService.GetInstance;
            counterService.Add();
            CounterService counterService1 = CounterService.GetInstance;
            counterService1.Add();
            CounterService counterService2 = CounterService.GetInstance;
            counterService2.Add();
            counterService.Print();
        }
    }
}