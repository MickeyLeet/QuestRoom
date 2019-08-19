namespace QuestRooms.dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuestRoom : DbContext
    {
    
        public QuestRoom()
            : base("name=QuestRoom")
        {
        }

       
    }
}