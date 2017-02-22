using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Praise2017.Models
{
    public class Detail
    {
        [Key]
        public int UpdateId { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Descrip { get; set; }
        public string ToWho { get; set; }

        //public virtual ICollection<Name> Name { get; set; }
    }
}