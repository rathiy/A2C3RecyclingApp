using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace recyclingapp.Models
{
    public class Reply
    {
        [PrimaryKey, AutoIncrement]
        public int ReplyID { get; set; }
        public int DissID { get; set; }
        public string ReplyText { get; set; }
    }
}
