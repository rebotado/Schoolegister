using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite.EF6;

namespace Schoolegister.Model
{
    [Table("Grade")]
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Column("Unit1")]
        public double Unit1 { get; set; }
        [Column("Unit2")]
        public double Unit2 { get; set; }
        [Column("Unit3")]
        public double Unit3 { get; set; }
        [Column("Unit4")]
        public double Unit4 { get; set; }
        [Column("Unit5")]
        public double Unit5 { get; set; }
        [Column("Unit6")]
        public double Unit6 { get; set; }
    }
}
