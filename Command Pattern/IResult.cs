csusing System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public interface IResult
    {
        IResult WriteResultToLine();
    }
}
