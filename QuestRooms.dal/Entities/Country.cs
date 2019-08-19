using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.dal.Entities
{
    
   public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
