using System;
using System.Data.Entity;

namespace MvcApplication4.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email {get; set;}
        public string Mobile { get; set; }
    }

    public class PlayerDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}