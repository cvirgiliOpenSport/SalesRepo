using SalesRepo.utils;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalesRepo.Models
{
    public class SalesToTable
    {
        [Display(Name = "Fecha")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Date { get; set; }

        [Display(Name = "Cuit")]
        public string? Cuit { get; set; }

        [Display(Name = "Codigo Sucursal")]
        public int StoreCode { get; set; }


        [Display(Name = "Nombre Sucursal")]
        public string StoreName { get; set; } = null!;


        [Display(Name = "Tipo de Comprobante")]
        public string InvoiceType { get; set; } = null!;


        [Display(Name = "Nro Comprobante")]
        public string InvoiceNumber { get; set; } = null!;

        public string SKU { get; set; } = null!;

        [Display(Name = "Descripcion")]
        public string ArticleDescription { get; set; }
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        [Display(Name = "Linea")]

        public string Category { get; set; }

        [Display(Name = "Talle")]
        public string Size { get; set; } = null!;


        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }


        [Display(Name = "Precio de venta")]
        public decimal SalePrice { get; set; }

        [Display(Name = "Importe de venta")]
        public decimal SaleAmount { get; set; }

        [Display(Name = "Precio de Costo")]
        public decimal CostPrice { get; set; }

        [Display(Name = "Importe de costo")]
        public decimal CostAmount { get; set; }
    }
}
