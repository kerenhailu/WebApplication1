using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Teacher
    {
        public string name;
        public string lname;
        public int year;
        public int monney;
        public Teacher(string name, string lname, int year, int monney)
        {
            this.name = name;
            this.lname = lname;
            this.year = year;
            this.monney = monney;
        }
    }
}