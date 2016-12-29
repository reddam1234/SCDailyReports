using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using SCDailyReport.DAL;

namespace SCDailyReport.Models
{
    public class ProductDetails
    {
        public string ProductName { get; set; }
        public string AreaName { get; set; }
        public DateTime AsOfDate { get; set; }
        public int ProductType { get; set; }
        public decimal Value { get; set; }



        public static List<ProductDetails> GetAllProducts()
        {
            return DBAccess.GetConnection().Query<ProductDetails>("select * from [ProductDetails]").ToList();
        }
    }
}