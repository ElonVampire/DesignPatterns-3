namespace Composite_Pattern
{
    internal class PrettyPrintPartyStatsCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "show tree";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                string printString = repo.PrettyPrint();
                return new Result(printString);
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}