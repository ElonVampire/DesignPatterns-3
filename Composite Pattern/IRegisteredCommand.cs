using System.Collections.Generic;

namespace Composite_Pattern
{
    public interface IRegisteredCommand
    {
        string BaseCommandText { get; set; }
        List<string> Parameters { get; set; }
    }
}