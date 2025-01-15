using System.Diagnostics;
using System.Security.AccessControl;
using DevExpress.Data.Helpers;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using SalesRepo.Models;
using SalesRepo.utils;

namespace SalesRepo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExportingService exporting;

        public HomeController(ILogger<HomeController> logger, ExportingService exporting)
        {
            _logger = logger;
            this.exporting = exporting;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Test() 
        {
            GetSalePreviewVM toView = new GetSalePreviewVM
            {
                SalesFrom=DateTime.Now,
                SalesUpTo=DateTime.Now,
                userId="asd"
            };
            return View(toView);
        }
        public async Task<object> GetSalesPivotGet(DataSourceLoadOptions loadOptions, string start, string end, string userId) 
        {
            var MockedSales = Sales.GetMockSales();
            return DataSourceLoader.Load(MockedSales,loadOptions);
        }
        public async Task<FileResult> Excel()
        {


            // use for example only




            var GetResult = Sales.GetMockSales();

            // here, we need to get access to the currents filters in the ${loadOptions}, but we get a [null,"contains","The parameter"]
            // we dont know why the in the loaderOption dont have a columnName/dataField. 
            //var data = await _previewHttpClient.GetSalesTransaction();
            try
            {
                byte[] result = await exporting.GetBytesFromData(GetResult);
                return File(result, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Sales.xlsx");
            }
            catch (Exception ex)
            {

                throw;
            }
            // export data
        }
       
        [HttpPost]
        public async Task<IActionResult> ExportSalesToExcel(DataSourceLoadOptions loadOptions, [FromBody] object gridState)
        {
        

            // use for example only
           
           


            var GetResult = Sales.GetMockSales();

            // here, we need to get access to the currents filters in the ${loadOptions},
            // but we get a [null,"contains","The parameter"]
            // we dont know why in the loaderOption dont have a columnName/dataField. 
            var dataFiltered = (IEnumerable<Sales>)DataSourceLoader.Load(GetResult, loadOptions).data;
            var dataToExport = dataFiltered.ToList();

            string tempFileName = "";
            try
            {
                byte[] result = await exporting.GetBytesFromData(dataToExport);
                
               
                return File(result, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Sales.xlsx");

            }
            catch (Exception)
            {
                throw;
            }
        }

    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
