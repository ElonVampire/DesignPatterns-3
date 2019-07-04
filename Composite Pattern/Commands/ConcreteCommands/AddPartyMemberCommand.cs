namespace Composite_Pattern
{
    internal class AddPartyMemberCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "add member";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                repo.AddPartyMember(comm.Parameters[0]);
                return new Result("member " + comm.Parameters[0] + " was made successfully in root"  );
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}