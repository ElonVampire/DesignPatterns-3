namespace Composite_Pattern
{
    internal class AddPartyMemberCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new AddPartyMemberCommand();
            return result;
        }
    }
}