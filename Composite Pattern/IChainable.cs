namespace Composite_Pattern
{
    internal interface IChainable
    {
        ICommand _NextCommand { get; set; }
        bool isEndItem { get; set; }
        ICommand SetNext(ICommand aCommand);
    }
}