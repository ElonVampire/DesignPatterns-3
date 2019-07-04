using System.Collections.Generic;

namespace Composite_Pattern
{
    public interface IParty
    {
        string Name { get; set; }
        List<IParty> _parties { get; set; }
        void AddGroup(string groupName, string parent = "root");
        void RemoveGroup(string groupName);
        void AddPartyMember(string memberName, string groupName = "root");
        void RemovePartyMember(string memberName, string groupName = "root");
        void AddMoney(int amountToBeAdded);
        void RemoveMoney(int amountToBeDeducted);
        void AddExperience(int amountToBeAdded);
        void RemoveExperience(int amountToBeDeducted);
        string PrettyPrint();
    }
}