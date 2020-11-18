using System;
using System.Collections.Generic;

namespace CESDEUniversity.Models
{
    public class Student
    {

        //Una clase tipo 'Modelo' tiene sobre todo atributos. Métodos únicamente para validaciones.

        //el EntityFramework usa el ID en mayúscula. Con ese campo va a relacionar las tablas.
        //El ID se va a generar automaticamente (autoincrement) en la BD
        public int ID { get; set; }

        public String LastName { get; set; }

        public String FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}