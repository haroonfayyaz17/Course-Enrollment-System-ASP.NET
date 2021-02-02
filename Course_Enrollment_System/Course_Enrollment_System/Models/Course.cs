using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Enrollment_System.Models
{
    public class Course
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Display(Name = "Number")]

        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }


        public int Credits { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
