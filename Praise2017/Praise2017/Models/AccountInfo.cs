using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Praise2017.Models
{
    public class AccountInfo
    {
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