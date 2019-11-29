using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace recyclingapp.Models
{
    public class campaign
    {
        [PrimaryKey, AutoIncrement]
        public int CampID { get; set; }
        public string campname { get; set; }
        public string describtion { get; set; }
        public string datecreated { get; set; }
        public string address { get; set; }
        

      
    }

   
}
