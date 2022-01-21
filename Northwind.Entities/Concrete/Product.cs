using Northwind.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        //[Required]///Do not use this method
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
