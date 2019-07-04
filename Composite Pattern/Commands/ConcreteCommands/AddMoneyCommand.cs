using System;

namespace Composite_Pattern
{
    internal class AddMoneyCommand : BaseChainable, ICommand
    {
        public string CommandText { get; set; } = "add money";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if (comm.BaseCommandText == CommandText)
            {
                int moneyToAdd = Int32.Parse(comm.Parameters[0]);
                repo.AddMoney(moneyToAdd);
                return new Result(String.Format("The amount of {0} was added the the root party and divided among the children", moneyToAdd));
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}