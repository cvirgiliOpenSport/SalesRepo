using Newtonsoft.Json;
using SalesRepo.utils;
using System.ComponentModel.DataAnnotations;

namespace SalesRepo.Models
{
    public class Sales
    {
        
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Date { get; set; }

        
        public string Cuit { get; set; }

        
        public int StoreCode { get; set; }


        
        public string StoreName { get; set; } = null!;


        
        public string InvoiceType { get; set; } = null!;


        
        public string InvoiceNumber { get; set; } = null!;

        public string SKU { get; set; } = null!;

        
        public string ArticleDescription { get; set; }
        
        public string Brand { get; set; }
        

        public string Category { get; set; }

        
        public string Size { get; set; } = null!;


        
        public int Quantity { get; set; }


        
        public decimal SalePrice { get; set; }

        
        public decimal SaleAmount { get; set; }

        
        public decimal CostPrice { get; set; }

        
        public decimal CostAmount { get; set; }
        public static IEnumerable<Sales> GetMockSales()
        {
            return new List<Sales>
    {
        new Sales
        {
            Date = DateTime.Now.AddDays(-10),
            Cuit = "20304050601",
            StoreCode = 1,
            StoreName = "Sucursal Centro",
            InvoiceType = "Factura A",
            InvoiceNumber = "0001-00000001",
            SKU = "SKU001",
            ArticleDescription = "Producto A",
            Brand = "Marca X",
            Category = "Electrodomésticos",
            Size = "N/A",
            Quantity = 5,
            SalePrice = 1500.50m,
            SaleAmount = 7502.50m,
            CostPrice = 1200.00m,
            CostAmount = 6000.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-9),
            Cuit = "20304050602",
            StoreCode = 2,
            StoreName = "Sucursal Norte",
            InvoiceType = "Factura B",
            InvoiceNumber = "0002-00000002",
            SKU = "SKU002",
            ArticleDescription = "Producto B",
            Brand = "Marca Y",
            Category = "Hogar",
            Size = "M",
            Quantity = 3,
            SalePrice = 800.00m,
            SaleAmount = 2400.00m,
            CostPrice = 600.00m,
            CostAmount = 1800.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-8),
            Cuit = "20304050603",
            StoreCode = 3,
            StoreName = "Sucursal Sur",
            InvoiceType = "Factura C",
            InvoiceNumber = "0003-00000003",
            SKU = "SKU003",
            ArticleDescription = "Producto C",
            Brand = "Marca Z",
            Category = "Tecnología",
            Size = "L",
            Quantity = 10,
            SalePrice = 2000.00m,
            SaleAmount = 20000.00m,
            CostPrice = 1800.00m,
            CostAmount = 18000.00m
        },
        // Puedes agregar más objetos con datos variados
        new Sales
        {
            Date = DateTime.Now.AddDays(-7),
            Cuit = "20304050604",
            StoreCode = 4,
            StoreName = "Sucursal Este",
            InvoiceType = "Factura A",
            InvoiceNumber = "0004-00000004",
            SKU = "SKU004",
            ArticleDescription = "Producto D",
            Brand = "Marca W",
            Category = "Ropa",
            Size = "S",
            Quantity = 7,
            SalePrice = 500.00m,
            SaleAmount = 3500.00m,
            CostPrice = 400.00m,
            CostAmount = 2800.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-6),
            Cuit = "20304050605",
            StoreCode = 5,
            StoreName = "Sucursal Oeste",
            InvoiceType = "Factura B",
            InvoiceNumber = "0005-00000005",
            SKU = "SKU005",
            ArticleDescription = "Producto E",
            Brand = "Marca V",
            Category = "Deportes",
            Size = "XL",
            Quantity = 15,
            SalePrice = 300.00m,
            SaleAmount = 4500.00m,
            CostPrice = 250.00m,
            CostAmount = 3750.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-5),
            Cuit = "20304050606",
            StoreCode = 6,
            StoreName = "Sucursal Central",
            InvoiceType = "Factura C",
            InvoiceNumber = "0006-00000006",
            SKU = "SKU006",
            ArticleDescription = "Producto F",
            Brand = "Marca U",
            Category = "Electrónica",
            Size = "M",
            Quantity = 2,
            SalePrice = 1000.00m,
            SaleAmount = 2000.00m,
            CostPrice = 800.00m,
            CostAmount = 1600.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-4),
            Cuit = "20304050607",
            StoreCode = 7,
            StoreName = "Sucursal Premium",
            InvoiceType = "Factura A",
            InvoiceNumber = "0007-00000007",
            SKU = "SKU007",
            ArticleDescription = "Producto G",
            Brand = "Marca T",
            Category = "Accesorios",
            Size = "XS",
            Quantity = 20,
            SalePrice = 150.00m,
            SaleAmount = 3000.00m,
            CostPrice = 100.00m,
            CostAmount = 2000.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-3),
            Cuit = "20304050608",
            StoreCode = 8,
            StoreName = "Sucursal Externa",
            InvoiceType = "Factura B",
            InvoiceNumber = "0008-00000008",
            SKU = "SKU008",
            ArticleDescription = "Producto H",
            Brand = "Marca S",
            Category = "Muebles",
            Size = "L",
            Quantity = 1,
            SalePrice = 5000.00m,
            SaleAmount = 5000.00m,
            CostPrice = 4000.00m,
            CostAmount = 4000.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-2),
            Cuit = "20304050609",
            StoreCode = 9,
            StoreName = "Sucursal Nueva",
            InvoiceType = "Factura C",
            InvoiceNumber = "0009-00000009",
            SKU = "SKU009",
            ArticleDescription = "Producto I",
            Brand = "Marca R",
            Category = "Limpieza",
            Size = "N/A",
            Quantity = 30,
            SalePrice = 50.00m,
            SaleAmount = 1500.00m,
            CostPrice = 40.00m,
            CostAmount = 1200.00m
        },
        new Sales
        {
            Date = DateTime.Now.AddDays(-1),
            Cuit = "20304050610",
            StoreCode = 10,
            StoreName = "Sucursal Clásica",
            InvoiceType = "Factura A",
            InvoiceNumber = "0010-00000010",
            SKU = "SKU010",
            ArticleDescription = "Producto J",
            Brand = "Marca Q",
            Category = "Calzado",
            Size = "N/A",
            Quantity = 8,
            SalePrice = 700.00m,
            SaleAmount = 5600.00m,
            CostPrice = 600.00m,
            CostAmount = 4800.00m
        }
    };
        }

    }
}
