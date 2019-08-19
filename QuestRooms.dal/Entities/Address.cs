using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.dal.Entities
{
    
   public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string AddressName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
