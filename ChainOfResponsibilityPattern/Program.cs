using ChainOfResponsibilityPattern.MyHandlers;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new LoanRequest { InterestOverride = false, LoanRequired = 99000 };
            var assMng = new AssistantManager();
            var Mng = new Manager();
            var brcMng = new BranchManager();
            var rgnMng = new RegionalManager();
            var ntnMng = new NationalManager();
            var ExcMng = new ExecutiveManager();
            var nullmng = new NullEndManager();
            assMng.SetNext(Mng).SetNext(brcMng).SetNext(rgnMng).SetNext(ntnMng).SetNext(ExcMng).SetNext(nullmng);
            var result = assMng.Handle(request);
            Console.WriteLine(result);
        }
    }
}
