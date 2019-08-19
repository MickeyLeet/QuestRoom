using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.dal.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public string RoomPassingTime { get; set; }
        public int RoomMaxPlayers { get; set; }
        public int RoomMinPlayers { get; set; }
        public int RoomMinAgePlayers { get; set; }
        public string Address { get; set; }
        public string RoomPhoneNumber { get; set; }
        public string RoomEmail { get; set; }
        public string RoomCompany { get; set; }
        public string RoomRating { get; set; }
        public int RoomFearRating { get; set; }
        public int RoomDifficultiesRating { get; set; }
        public string RoomLogo { get; set; }
        public string RoomGalary { get; set; }
    }
}
