using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    interface ICommand
    {
        bool Execute();
    }
}
