namespace WebApplication1.Service
{
    public class CounterService
    {
        public ICounter Value { get; }

        public CounterService(ICounter value)
        {
            Value = value;
        }
    }
}
