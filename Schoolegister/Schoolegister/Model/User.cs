using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schoolegister.Model
{
    public enum PermissionLevel
    {
        Admin = 0,
        Professor = 1,
        Student = 2
    }


    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column("Username")]
        public string Username { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("PermissionLevel")]
        public int PermissionLevel { get; set; }

    }
}
