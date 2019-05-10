using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schoolegister.Model
{
    [Table("Employee")]
    public class Employee : IEmployee
    {
        [Key]
        public int Id { get; set; }
        [Column("Salary")]
        public decimal Salary { get; set; }
        [Column("Bank")]
        public string Bank { get; set; }
        [Column("BankAccount")]
        public string BankAccount { get; set; }
        [Column("Job")]
        public string Job { get; set; }
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
        public DateTime BirthDate { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Email")]
        public string Email { get; set; }
    }
}
