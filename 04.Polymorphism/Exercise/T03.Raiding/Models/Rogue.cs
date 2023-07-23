using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int RoguePower = 80;
        public Rogue(string name) : base(name, RoguePower)
        {
        }

        public override string CastAbility()
            => $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}
