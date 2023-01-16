namespace WebApplication1.Service
{
    public class ShortTimeService : ITimeService
    {
        public string GetTtime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
