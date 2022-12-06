using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons.Domain.Factories
{
    internal class GymPlusPoolFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymPlusPoolFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymPlusPool gymPlusPool = new(_price)
            {
                Description = _description,
            };
            return gymPlusPool;
        }
    }
}
