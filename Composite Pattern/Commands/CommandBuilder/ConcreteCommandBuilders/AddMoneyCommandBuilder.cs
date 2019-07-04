namespace Composite_Pattern
{
    internal class AddMoneyCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new AddMoneyCommand();
            return result;
        }
    }
}