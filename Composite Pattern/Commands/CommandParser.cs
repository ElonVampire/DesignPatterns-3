using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite_Pattern
{
    internal class CommandParser
    {
        private ICommandMaker commandMaker;
        private List<ICommand> _myCommands;
        private PartyModel _myParty = new PartyModel();


        public CommandParser(ICommandMaker aCommandMaker)
        {
            commandMaker = aCommandMaker;
            commandMaker.BuildCommands();
            _myCommands = commandMaker.GetCommands();
            foreach (ICommand command in _myCommands)
            {
                if (!command.isEndItem)
                {
                    command.SetNext(_myCommands[_myCommands.IndexOf(command) + 1]);
                }
                else
                {
                    return;
                }
            }
        }

        internal IResult ParseCommand(string rawCommandInput)
        {
            IRegisteredCommand command = new BuiltUpCommand()
            {
                BaseCommandText = GetBaseCommandText(rawCommandInput),
                Parameters = GetParameterText(rawCommandInput)
            };
            return _myCommands[0].Execute(_myParty, command);
        }

        private List<string> GetParameterText(string rawCommandInput)
        {
            var commandSplit = rawCommandInput.Split(" ");
            if (commandSplit.Length < 2)
            {
                return null;
            }
            var commandList = commandSplit.OfType<string>().ToList();
            var result = new List<string>();
            commandList.RemoveRange(0, 2);
            foreach (var parameter in commandList)
            {
                result.Add(parameter);
            }
            return result;
        }

        private string GetBaseCommandText(string rawCommandInput)
        {
            var commandSplit = rawCommandInput.Split(" ");
            if(commandSplit.Length < 2)
            {
                return null;
            }
            var result = commandSplit[0] + " " + commandSplit[1];
            return result;
        }
    }
}