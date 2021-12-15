using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pupil
    {
        public string name;
        public string lname;
        public int yearBorn;
        public int great;
     public  Pupil(string name,string lname,int yearBorn,int great)
        {
            this.name = name;
            this.lname = lname;
            this.yearBorn = yearBorn;
            this.great = great;
        }
    }
}