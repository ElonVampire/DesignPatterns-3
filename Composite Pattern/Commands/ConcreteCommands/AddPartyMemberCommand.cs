namespace Composite_Pattern
{
    internal class AddPartyMemberCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "add member";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                string memberName = comm.Parameters[0];
                string parentGroup = "";
                if (comm.Parameters.Count == 2)
                {
                    parentGroup = comm.Parameters[1];
                }
                else
                {
                    parentGroup = "root";
                }
                repo.AddPartyMember(memberName, parentGroup);
                return new Result("member " + comm.Parameters[0] + " was made successfully"  );
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}