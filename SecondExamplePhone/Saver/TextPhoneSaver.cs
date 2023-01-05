using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExamplePhone.Saver
{
    public class TextPhoneSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            using StreamWriter stream = new StreamWriter(fileName, true);
            stream.WriteLine(phone.Model);
            stream.WriteLine(phone.Price);
        }
    }
}
