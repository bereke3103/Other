namespace WebApplication1.Service
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}
