namespace WebApplication1.Service
{
    public class TimeService
    {
        public string Time { get; }

        public TimeService()
        {
          Time = DateTime.Now.ToLongTimeString();
        }
    }
}
