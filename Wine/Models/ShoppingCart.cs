using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wine.Models;

namespace Wine.Models
{
    public class ShoppingCart
    {
        public int shoppingcartitemID { get; set; }
        public Wine wine { get; set; }
        public int Amount { get; set; }
        public string shoppingcartID { get; set; }
    }
}