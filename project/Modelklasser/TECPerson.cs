using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Modelklasser
{
    internal class TECPerson 
    {

        public SchoolingCatagory Uddannelseslinje { get; set; }
        public string? FullName { get; set; }
        public int Compareto(TECPerson? item)
        {
            //return string.Compare(Schooling, item.FullName);
            return FullName.CompareTo(item.FullName);
        }

    }
}
        
    
