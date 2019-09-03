using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterNamingService monsterNamer = new MonsterNamingService();
            MonsterStatProvider monsterStatProvider = new MonsterStatProvider();
            Monster monster = new Monster();
            monster = monsterNamer.NameMonster(monster);
            monster = monsterStatProvider.GenerateMonsterStats(monster);
            monster.Examine();


            MonsterEntityGenerator monsterGenerator = new MonsterEntityGenerator(monsterNamer, monsterStatProvider);
            Monster newMonster = monsterGenerator.Generate();
            newMonster.Examine();
        }
    }
}
