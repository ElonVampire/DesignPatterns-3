namespace Composite_Pattern
{
    internal interface ICommand : IChainable
    {
        string CommandText { get; set; }
        IResult Execute(PartyModel repo, IRegisteredCommand comm);
    }
}