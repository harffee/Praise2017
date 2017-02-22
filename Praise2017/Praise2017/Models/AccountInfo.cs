using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Praise2017.Models
{
    public class AccountInfo
    {
        [Key]
        public string Name { get;set;}
        public string Alias { get; set;}
        public Role Role { get; set; }
    }
    public enum Role
    {
        Admin,
        User
    }

}