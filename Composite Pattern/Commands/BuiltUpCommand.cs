using System.Collections.Generic;

namespace Composite_Pattern
{
    internal class BuiltUpCommand : IRegisteredCommand
    {
        public string BaseCommandText { get; set; }
        public List<string> Parameters {get; set;}
    }
}