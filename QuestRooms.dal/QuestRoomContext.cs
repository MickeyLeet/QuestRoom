namespace QuestRooms.dal
{
    using QuestRooms.dal.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuestRoomContext : DbContext
    {

        public QuestRoomContext()
            : base("name=QuestRoom")
        {
        }

        public DbSet<Address> address { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Company> company { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Room> room { get; set; }
        public DbSet<Street> street { get; set; }
       

    }
}