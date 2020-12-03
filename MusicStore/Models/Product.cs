using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models
{

    public enum Category
    {
        pianos, guitars, basses, percussion, amps, trumpet, books
    }

    public class Product
    {

        //Introducir la clave primaria manualmente y que no la genere la BD (autoinceremnt)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int ProductID { get; set; }
        
        public String ProductName { get; set; }
        
        public String ProductDescr { get; set; }
        
        //public String Picture { get; set; }
        public byte[] Picture { get; set; }

        public Category? Category { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }

    }
}