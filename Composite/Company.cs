using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Company : StackHolder
    {
        private List<Person> _owners;

        public Company(string name, List<Person> owners)
        {
            Name = name;
            _owners = owners;
        }
        public override double Networth
        {
            get => _owners.Select(o => o.Networth).Sum();
            set => _owners.ForEach(o => o.Networth += value / _owners.Count);
        }

        public override void GetNetworth()
        {
            foreach (var person in _owners)
            {
                person.GetNetworth();
            }
        }
    }
}
