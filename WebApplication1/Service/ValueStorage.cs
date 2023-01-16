using WebApplication1.Service.Interface;

namespace WebApplication1.Service
{
    public class ValueStorage : IGenerator, IReader
    {
        int value;

        public int GeneratorValue()
        {
            value = new Random().Next();
            return value;
        }

        public int ReadValue()=> value;
    }
}
