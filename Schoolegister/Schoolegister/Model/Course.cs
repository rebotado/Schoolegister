using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schoolegister.Model
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Code")]
        public string Code { get; set; }
        [Column("TotalStudents")]
        public int TotalStudents { get; set; }

        [ForeignKey("ScheduleID")]
        public virtual Schedule Schedule { get; set; }
        public int ScheduleID { get; set; }

        [ForeignKey("ProfessorID")]
        public virtual Professor Professor { get; set; }
        public int ProfessorID { get; set; }

        public virtual ICollection<CourseStudents> Students {get; set;}
    }
}
