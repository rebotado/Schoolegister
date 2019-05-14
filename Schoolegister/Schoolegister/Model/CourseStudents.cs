using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;

namespace Schoolegister.Model
{
    [Table("CourseStudents")]
    public class CourseStudents
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }
        public int SutdentID { get; set; }
    }
}
