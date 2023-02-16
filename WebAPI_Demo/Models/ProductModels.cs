using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Demo.Models
{
   
    public class ProductViewsModels
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

       
        public string SupplierName { get; set; }
    }

    public class StudentViewsModel
    {
        public int id { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCode { get; set; }
    }
}