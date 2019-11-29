using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace recyclingapp.Models
{

    public class Topic
    {
        [PrimaryKey, AutoIncrement]
        public int TopicID { get; set; }
        public string TotpicTitle { get; set; }
        public string TopicDes { get; set; }
        public int UserId { get; set; }  //101  Amar

    } //one to many relatioship
    public class Discuss
    {
        [PrimaryKey, AutoIncrement]
        public int DissID { get; set; }
        public int UserId { get; set; } //102 Ram, 103 Sid
        public string TDiscussion { get; set; }
        public int TopicID { get; set; }
     
    }
}
