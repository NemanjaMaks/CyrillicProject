using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyrillicProject.Models
{
    public class APICall
    {
        public int ID { get; set; }
        public String Request { get; set; }
        public DateTime Date { get; set; }
        public String Username { get; set; }
    }
}