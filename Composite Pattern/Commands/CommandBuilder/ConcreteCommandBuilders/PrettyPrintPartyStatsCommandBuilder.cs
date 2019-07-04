namespace Composite_Pattern
{
    internal class PrettyPrintPartyStatsCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new PrettyPrintPartyStatsCommand();
            return result;
        }
    }
}