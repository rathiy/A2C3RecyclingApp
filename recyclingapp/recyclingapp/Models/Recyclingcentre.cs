using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace recyclingapp.Models
{
    public class Recyclingcentre
    {
        [PrimaryKey, AutoIncrement]
        public int RcID { get; set; }
        public string Adress { get; set; }
        public string Recycling { get; set; }
        public string datecreated { get; set; }
        public string Keyword { get; set; }
        public string langitute { get; set; }
        public string latitute { get; set; }
    }
}
