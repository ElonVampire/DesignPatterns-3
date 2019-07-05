using System.Collections.Generic;

namespace Composite_Pattern
{
    internal class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> _parties { get; set; }

        public Group(string groupName)
        {
            Name = groupName;
            _parties = new List<IParty>();
        }


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
                _parties.Add(new Group(groupName));
            }
            else
            {
                foreach (var party in _parties)
                    party.AddGroup(groupName, parent);
            }
        }

        public void AddMoney(int amountToBeAdded)
        {
            if (_parties.Count == 0)
                return; 
            int split = amountToBeAdded / _parties.Count;
            foreach (var party in _parties)
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

        public string PrettyPrint(int counterToken)
        {
            
            string result = "";
            for(var i = 0; i <= counterToken; i++)
            {
                result += "\t";
            }
            counterToken++;
            result += string.Format("Group name: {0}\n", Name);
            foreach (var party in _parties)
            {
                
                result += party.PrettyPrint(counterToken);
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
                if (party.Name == groupName)
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