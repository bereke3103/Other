using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons.Domain.Factories
{
    internal class PersonalTrainingsFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public PersonalTrainingsFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            PersonalTraining personalTrainig = new(_price)
            {
                Description = _description,
            };
            return personalTrainig;
        }
    }
}
