using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schoolegister.Model
{
    [Table("Schedule")]
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [Column("Monday")]
        public DateTime Monday { get; set; }
        [Column("Thursday")]
        public DateTime Thursday { get; set; }
        [Column("Wednesday")]
        public DateTime Wednesday { get; set; }
        [Column("Tuesday")]
        public DateTime Tuesday { get; set; }
        [Column("Friday")]
        public DateTime Friday { get; set; }
        [Column("Saturday")]
        public DateTime Saturday { get; set; }
        [Column("Sunday")]
        public DateTime Sunday { get; set; }
    }
}
