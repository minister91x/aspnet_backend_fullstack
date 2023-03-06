using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFullStack.Models
{
    public class StudentInfor
    {
        public int id { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCode { get; set; }

        public int StudentClassID { get; set; }

        public string StudentClassName { get; set; }
    }

    public class ReturnData
    {
        public int responseCode { get; set; }
        public string Description { get; set; }
    }
}