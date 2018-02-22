using LiveConcertsDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveConcertsDB.DAL
{
    public class ConcertContext: DbContext
    {
        public DbSet<Concert> Concerts { get; set; }
    }
}