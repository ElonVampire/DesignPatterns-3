using System.Collections.Generic;

namespace Composite_Pattern
{
    internal interface ICommandMaker
    {
        void BuildCommands();
        List<ICommand> GetCommands();
    }
}