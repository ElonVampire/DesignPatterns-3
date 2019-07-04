namespace Composite_Pattern
{
    internal class RemoveMoneyCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new RemoveMoneyCommand();
            return result;
        }
    }
}