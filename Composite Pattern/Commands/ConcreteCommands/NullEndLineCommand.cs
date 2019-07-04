namespace Composite_Pattern
{
    internal class NullEndLineCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; }

        public NullEndLineCommand()
        {
            isEndItem = true;
        }

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            string mes = "Command of " + comm.BaseCommandText;
            if(comm.Parameters != null)
            {
                mes += " with the parameters of ";
                foreach (var i in comm.Parameters)
                {
                    mes += i + ", ";
                }
            }
            
            mes += " was not found please try again";
             return new Result(mes);
        }

    }
}