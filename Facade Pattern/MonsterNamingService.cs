using System;
using System.Collections.Generic;

namespace Facade_Pattern
{
    public class MonsterNamingService : INamer
    {
        public List<string> PossibleNames { get; set; } = new List<string>()
        {
            "Jeff",
            "Thomas",
            "Kris",
            "Hayden"
        };

        public Monster NameMonster(Monster monster)
        {
            monster.Name = PossibleNames[new Random().Next(0, PossibleNames.Count)];
            return monster;
        }
    }
}