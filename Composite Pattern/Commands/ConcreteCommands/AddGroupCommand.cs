namespace Composite_Pattern
{
    internal class AddGroupCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "add group";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                if (comm.Parameters == null || comm.Parameters.Count == 0)
                    return new Result("Group was not made, there was no parameters that matched what was required.");
                if(comm.Parameters.Count > 1)
                {
                    repo.AddGroup(comm.Parameters[0], comm.Parameters[1]);
                    return new Result(string.Format("The group {0} was made with the parent {1}",
                        comm.Parameters[0], 
                        comm.Parameters[1])
                        );
                }
                else
                {
                    repo.AddGroup(comm.Parameters[0]);
                    return new Result(string.Format("The group {0} was made",
                        comm.Parameters[0])
                        );
                }
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}