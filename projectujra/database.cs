using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projectujra
{
    public class database : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Order> order { get; set; }

        public database(DbContextOptions<database> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Pizzaname1 { get; set; }
        [Required]
        public string Pizzaname2 { get; set; }
        [Required]
        public string Pizzaname3 { get; set; }
        [Required]
        public Int32 Pizza1size { get; set; }
        [Required]
        public Int32 Pizza2size { get; set; }
        [Required]
        public Int32 Pizza3size { get; set; }
        [Required]
        public Int32 Pizza1count { get; set; }
        [Required]
        public Int32 Pizza2count { get; set; }
        [Required]
        public Int32 Pizza3count { get; set; }
        [Required]
        public Int32 Summa { get; set; }
        public DateTime Date { get; set; }


    }
}
