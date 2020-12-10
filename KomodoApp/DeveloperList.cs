using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApp
{
    public class DeveloperList
    {
        public string Name { get; set; }
        public int IdNumber { get; set;}
        public bool HasPluralSight { get; set; }

        public DeveloperList() { }
        public DeveloperList(string name, int idNumber, bool hasPluralSight )
        {
            Name = name;
            IdNumber = idNumber;
            HasPluralSight = hasPluralSight;
        }
    }
}
