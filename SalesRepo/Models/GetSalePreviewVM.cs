using System.ComponentModel.DataAnnotations;

namespace SalesRepo.Models
{
    public class GetSalePreviewVM
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ventas Desde")]
        public DateTime SalesFrom { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ventas Hasta")]
        public DateTime SalesUpTo { get; set; }
        public string userId { get; set; }

    }
}
