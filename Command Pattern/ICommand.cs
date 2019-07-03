namespace Command_Pattern
{
    internal interface ICommand : IChainable
    {
        string CommandString { get; set; }
        IResult Execute(Character aChar, string aaCommand);

    }
}