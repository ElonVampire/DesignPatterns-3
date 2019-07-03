using System.Collections.Generic;

namespace Command_Pattern
{
    public class CommandParser
    {
        private List<ICommand> _myCommands;
        private Character _myCharacter;
        public CommandParser()
        {
            myCommands = new List<ICommand>
            {
                new AddMoneyCommand(),
                new AddExperienceCommand(),
                new 
            }
        }


    }
}