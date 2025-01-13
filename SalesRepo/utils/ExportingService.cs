using ClosedXML.Excel;
using SalesRepo.Models;
using System.Data;

namespace SalesRepo.utils
{
    public class ExportingService
    {
        public async Task<byte[]> GetBytesFromData(IEnumerable<Sales> sales)  
        {
            var listOfSales = sales.ToList();
            sales.ToList();
            var salesData = SalesToDataTable(sales); // Método que retorna un DataTable

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sales");

                // Inserta los datos automáticamente
                worksheet.Cell(1, 1).InsertTable(salesData);

                // Ajusta automáticamente el tamaño de las columnas
                worksheet.Columns().AdjustToContents();

                // Devuelve el archivo Excel como un archivo descargable
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return content;
                }
            }
        }
        private DataTable SalesToDataTable( IEnumerable<Sales> data) 
        {

            // Convierte a DataTable
            var dataTable = new DataTable();

            // Agrega columnas automáticamente basadas en las propiedades del modelo
            var properties = typeof(Sales).GetProperties();
            foreach (var prop in properties)
            {
                dataTable.Columns.Add(prop.Name, prop.PropertyType);
            }

            // Agrega filas automáticamente
            foreach (var item in data)
            {
                var row = dataTable.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
