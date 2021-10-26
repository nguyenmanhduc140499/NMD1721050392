using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NMD1721050392.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public String PersonID { get; set; }
        public String PersonName { get; set; }
    }
}