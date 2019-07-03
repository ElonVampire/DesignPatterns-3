using System.Collections.Generic;

namespace Command_Pattern
{
    public class 
        CommandParser
    {
        private List<ICommand> _myCommands;
        private Character _myCharacter;
        public CommandParser()
        {
            _myCharacter = new Character();
            _myCommands = new List<ICommand>
            {
                new AddMoneyCommand(),
                new AddExperienceCommand(),
                new RemoveMoneyCommand(),
                new RemoveExperienceCommand(),
                new ShowStatsCommand()
            };

            _myCommands[0].SetNext(_myCommands[1])
                .SetNext(_myCommands[2])
                .SetNext(_myCommands[3])
                .SetNext(_myCommands[4])
                .SetNext(new EndOfChainItem());
            
        }


        public IResult ParseCommand(string command)
        {
            return _myCommands[0].Execute(_myCharacter, command);
        }

    }
}