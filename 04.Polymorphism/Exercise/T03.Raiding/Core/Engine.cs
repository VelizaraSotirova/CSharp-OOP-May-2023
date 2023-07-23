using Raiding.Core.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IConsoleReader reader;
        private readonly IConsoleWriter writer;
        private readonly IHeroFactory heroFactory;

        private readonly ICollection<IBaseHero> heroes;

        public Engine(IConsoleReader reader, IConsoleWriter writer, IHeroFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;

            heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int count = int.Parse(reader.ReadLine());

            while (count > 0) 
            {
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                try
                {
                    heroes.Add(heroFactory.Create(type, name));
                    count--;
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            foreach (var hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
            }

            int bossPower = int.Parse(reader.ReadLine());

            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }
    }
}
