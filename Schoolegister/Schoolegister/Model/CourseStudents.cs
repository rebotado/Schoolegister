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
        [Key, Column(Order = 0)]
        public int CourseID { get; set; }
        [Key, Column(Order = 1)]
        public int SutdentID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
