namespace Composite_Pattern
{
    internal class RemovePartyMemberCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new RemovePartyMemberCommand();
            return result;
        }
    }
}