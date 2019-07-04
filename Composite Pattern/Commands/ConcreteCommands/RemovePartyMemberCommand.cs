namespace Composite_Pattern
{
    internal class RemovePartyMemberCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "remove member";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                return new Result();
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }
    }
}