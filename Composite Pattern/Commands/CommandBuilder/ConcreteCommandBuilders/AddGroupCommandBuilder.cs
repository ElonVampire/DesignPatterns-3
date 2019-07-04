namespace Composite_Pattern
{
    internal class AddGroupCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new AddGroupCommand();
            return result;
        }
    }
}