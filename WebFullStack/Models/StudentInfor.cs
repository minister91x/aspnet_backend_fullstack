using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFullStack.Models
{
    public class StudentInfor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReturnData
    {
        public int responseCode { get; set; }
        public string Description { get; set; }
    }
}