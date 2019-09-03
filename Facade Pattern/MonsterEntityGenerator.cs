using System;

namespace Facade_Pattern
{
    public class MonsterEntityGenerator
    {
        INamer monsterNamer;
        IStatProvider monsterStatProvider;

        public MonsterEntityGenerator(INamer aMonsterNamer, IStatProvider aStatProvider)
        {
            monsterNamer = aMonsterNamer;
            monsterStatProvider = aStatProvider;
        }

        public Monster Generate()
        {
            Monster monster = new Monster();
            monster = monsterNamer.NameMonster(monster);
            monster = monsterStatProvider.GenerateMonsterStats(monster);
            return monster;
        }
    }
}   