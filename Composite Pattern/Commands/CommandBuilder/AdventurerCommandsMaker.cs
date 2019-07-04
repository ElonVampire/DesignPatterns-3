using System.Collections.Generic;

namespace Composite_Pattern
{
    internal class AdventurerCommandsMaker : ICommandMaker
    {
        private List<ICommand> _builtCommands;
        private List<IBuilder> _myBuilders;

        public AdventurerCommandsMaker()
        {
            _myBuilders = new List<IBuilder>
            {
                new AddPartyMemberCommandBuilder(),
                new RemovePartyMemberCommandBuilder(),
                new AddGroupCommandBuilder(),
                new RemoveGroupCommandBuilder(),
                new AddExperienceCommandBuilder(),
                new AddMoneyCommandBuilder(),
                new RemoveMoneyCommandBuilder(),
                new PrettyPrintPartyStatsCommandBuilder(),
                new NullEndLineCommandBuilder()
            };
        }

        public void BuildCommands()
        {
            _builtCommands = new List<ICommand>();
            foreach(IBuilder builder in _myBuilders)
            {
                _builtCommands.Add(builder.BuildCommand());
            }
        }

        public List<ICommand> GetCommands()
            => _builtCommands != null ? _builtCommands : null;

    }
}