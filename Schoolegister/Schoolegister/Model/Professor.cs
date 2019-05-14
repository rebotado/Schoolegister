using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schoolegister.Model
{
    [Table("Professors")]
    public class Professor : IEmployee
    {
        private decimal salary;

        [Key]
        public int Id { get; set; }
        [Column("Salary")]
        public string Salary { get => Convert.ToString(salary); set => salary = Convert.ToDecimal(value); }
        [Column("Bank")]
        public int Bank { get; set; }
        [Column("BankAccount")]
        public string BankAccount { get; set; }
        [Column("Job")]
        public int Job { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("BloodType")]
        public string BloodType { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("Curp")]
        public string Curp { get; set; }
        [Column("BirthDate")]
        public string BirthDate { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Email")]
        public string Email { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
