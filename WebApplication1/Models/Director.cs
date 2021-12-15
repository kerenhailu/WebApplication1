using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Director
    {
        public string name;
        public string lname;
        public string phone;
        public Director(string name, string lname, string phone)
        {
            this.name = name;
            this.lname = lname;
            this.phone = phone;
        }
    }
}