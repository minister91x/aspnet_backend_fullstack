using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFullStack.Models
{
    public class ProductViewsModels
    {

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không trống")]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [MaxLength(255)]
        public string SupplierName { get; set; }
    }
}