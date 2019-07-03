namespace Command_Pattern
{
    internal interface IChainable
    {
        ICommand _nextLink { get; set; }
        IChainable SetNext(ICommand next);
    }
}