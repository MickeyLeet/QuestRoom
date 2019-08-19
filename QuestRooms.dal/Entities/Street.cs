using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.dal.Entities
{
    
    public class Street
    {
        [Key]
        public int StreetId { get; set; }
        public string StreetName { get; set; }
    }
}
