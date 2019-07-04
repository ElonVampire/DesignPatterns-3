using System.Collections.Generic;

namespace Composite_Pattern
{
    internal class Group : IParty
    {
        public string Name { get; set; }

        public Group(string groupName)
        {
            Name = groupName;
        }

        public List<IParty> _parties { get; set; } = new List<IParty>();

        public void AddExperience(int amountToBeAdded)
        {
            int split = amountToBeAdded / _parties.Count;
            foreach (var party in _parties)
            {
                party.AddExperience(split);
            }
        }

        public void AddGroup(string groupName, string parent = "root")
        {
            if (parent == Name)
            {
                _parties.Add(new Group(Name));
            }
            else
            {
                foreach (var party in _parties)
                    party.AddGroup(Name, parent);
            }
        }

        public void AddMoney(int amountToBeAdded)
        {
            int split = amountToBeAdded / _parties.Count;
            foreach(var party in _parties)
            {
                party.AddMoney(split);
            }
        }

        public void AddPartyMember(string memberName, string groupName = "root")
        {
            if (groupName == Name)
            {
                _parties.Add(new Member(memberName));
            }
            else
            {
                foreach (var party in _parties)
                    party.AddPartyMember(memberName, groupName);
            }
        }

        public string PrettyPrint()
        {
            string result = "";
            result += string.Format("\t Group name: {0}\n", Name);
            foreach (var party in _parties)
            {
                
                result += "\t";
                result += party.PrettyPrint();
            }
            return result;

        }

        public void RemoveExperience(int amountToBeDeducted)
        {
            int split = amountToBeDeducted / _parties.Count;
            foreach (var party in _parties)
            {
                party.RemoveExperience(split);
            }
        }

        public void RemoveGroup(string groupName)
        {
            foreach (var party in _parties)
            {
                if(party.Name == groupName)
                {
                    _parties.Remove(party);
                }
            }
        }

        public void RemoveMoney(int amountToBeDeducted)
        {
            int split = amountToBeDeducted / _parties.Count;
            foreach (var party in _parties)
            {
                party.RemoveMoney(split);
            }
        }

        public void RemovePartyMember(string memberName, string groupName = "root")
        {
            foreach (var party in _parties)
            {
                if (party.Name == groupName)
                {
                    _parties.Remove(party);
                }
            }
        }
    }
}