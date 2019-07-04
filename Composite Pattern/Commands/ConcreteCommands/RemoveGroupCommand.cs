namespace Composite_Pattern
{
    internal class RemoveGroupCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "remove group";

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