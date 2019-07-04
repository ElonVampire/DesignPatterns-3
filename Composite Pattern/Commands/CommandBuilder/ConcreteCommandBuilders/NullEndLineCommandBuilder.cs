namespace Composite_Pattern
{
    internal class NullEndLineCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new NullEndLineCommand();
            return result;
        }
    }
}