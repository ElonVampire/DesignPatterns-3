using System.Collections.Generic;

namespace Composite_Pattern
{
    internal class Member : IParty
    {
        public string Name { get; set; }
        public int money { get; set; } = 0;
        public int experience { get; set; } = 0;
        public List<IParty> _parties { get; set; } = null;

        public Member(string memberName)
        {
            this.Name = memberName;
        }

        public void AddExperience(int amountToBeAdded)
        {
            experience += amountToBeAdded;
        }

        public void AddGroup(string groupName, string parent = "root")
        {
            return;
        }

        public void AddMoney(int amountToBeAdded)
        {
            money += amountToBeAdded;
        }

        public void AddPartyMember(string memberName, string groupName = "root")
        {
            return;
        }

        public string PrettyPrint(int counterToken)
        {

            string result = string.Empty;
            string indent = "";
            for (var i = 0; i <= counterToken; i++)
            {
                indent += "\t";
            }
            result += string.Format("{0}Party Member: {1} \n {0}Money: {2} \n {0}Experience {3}\n", indent, Name, money, experience);
            return result;
        }

        public void RemoveExperience(int amountToBeDeducted)
        {
            experience -= amountToBeDeducted;
        }

        public void RemoveGroup(string groupName)
        {
            throw new System.Exception();
        }

        public void RemoveMoney(int amountToBeDeducted)
        {
            money -= amountToBeDeducted;
        }

        public void RemovePartyMember(string memberName, string groupName = "root")
        {
            throw new System.Exception();
        }
    }
}