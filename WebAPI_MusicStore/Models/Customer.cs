using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_MusicStore.Models
{
    public class Customer
    {

        //Introducir la clave primaria manualmente y que no la genere la BD (autoinceremnt)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int ID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public String Country { get; set; }


    }
}
