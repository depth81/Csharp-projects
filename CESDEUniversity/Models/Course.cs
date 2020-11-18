using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CESDEUniversity.Models
{
    public class Course
    {
        //Introducir la clave primaria manualmente y que no la genere la BD (autoinceremnt)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int CourseID { get; set; }

        public String Title { get; set; }

        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}