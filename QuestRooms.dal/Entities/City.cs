using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.dal.Entities
{
 
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Street> Streets { get; set; }

    }
}
