using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFullStack.Models
{
    public class ProductEditModels
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
    }
}