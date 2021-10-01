using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class Security
    {
        [DisplayName("Login")]
        public string Login { get; set; }
        
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}