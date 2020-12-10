using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApp
{
    public class DeveloperListRepository
    {
        private List<DeveloperListRepository> _listOfDevelopers = new List<DeveloperListRepository>();

        public void AddDevelopersToList(DeveloperListRepository developer)
        {
            _listOfDevelopers.Add(developer);
        }
        public List<Developers> GetDeveloperList()
        {
            return _listOfDevelopers;
        }
        public DeveloperListRepository GetDeveloperByName(string name)
        {
            foreach(DeveloperListRepository developer in _listOfDevelopers)
            {
                if(developer.Name == name)
                {
                    return developer;
                }
            }

            return null;
        }

        
    }

}
