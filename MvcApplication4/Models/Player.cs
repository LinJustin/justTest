using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication4.Models
{
    public class Player
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string CName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [StringLength(100)]
        public string Email {get; set;}
        [StringLength(20)]
        public string Mobile { get; set; }
        [StringLength(10)]
        public string Rating { get; set; }
    }

    public class PlayerDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}