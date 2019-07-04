namespace Composite_Pattern
{
    internal abstract class BaseChainable : IChainable
    {
        public ICommand _NextCommand { get; set; }
        public bool isEndItem { get; set; }

        public virtual ICommand SetNext(ICommand aCommand)
        {
            _NextCommand = aCommand;
            return _NextCommand;
        }
    }
}