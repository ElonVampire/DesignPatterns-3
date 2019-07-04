namespace Composite_Pattern
{
    internal class RemoveGroupCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new RemoveGroupCommand();
            return result;
        }
    }
}