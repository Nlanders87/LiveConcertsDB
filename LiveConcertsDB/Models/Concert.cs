using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveConcertsDB.Models
{
    public class Concert
    {
        public int ID { get; set; }
        public string Band { get; set; }
        public string Venue { get; set; }
        public DateTime Date {get; set;}


    }

}