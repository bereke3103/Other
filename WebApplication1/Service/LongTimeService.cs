namespace WebApplication1.Service
{
    public class LongTimeService : ITimeService
    {
        public string GetTtime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
