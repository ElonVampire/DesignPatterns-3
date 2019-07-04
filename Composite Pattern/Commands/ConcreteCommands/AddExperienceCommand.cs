using System;

namespace Composite_Pattern
{
    internal class AddExperienceCommand : BaseChainable, ICommand
    {
        private int _expGain;
        public string CommandText { get; set; } = "add experience";

        public IResult Execute(PartyModel repo, IRegisteredCommand comm)
        {
            if(comm.BaseCommandText == CommandText)
            {
                int experienceToAdd = Int32.Parse(comm.Parameters[0]);
                repo.AddExperience(experienceToAdd);
                return new Result(String.Format("The amount of {0} was added the the root party and divided among the children", experienceToAdd));
            }
            else
            {
                return _NextCommand.Execute(repo, comm);
            }
        }

    }
}