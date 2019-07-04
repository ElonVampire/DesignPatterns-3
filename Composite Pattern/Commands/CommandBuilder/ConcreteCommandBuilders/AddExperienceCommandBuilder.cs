namespace Composite_Pattern
{
    internal class AddExperienceCommandBuilder : IBuilder
    {
        public ICommand BuildCommand()
        {
            ICommand result = new AddExperienceCommand();
            return result;
        }
    }
}