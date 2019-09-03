using System;

namespace Facade_Pattern
{
    public class MonsterStatProvider : IStatProvider
    {
        public Monster GenerateMonsterStats(Monster monster)
        {
            monster.Health = new Random().Next(1, 99);
            monster.Strength = new Random().Next(1, 99);
            monster.Accuracy = new Random().Next(1, 99);
            return monster;
        }
    }
}