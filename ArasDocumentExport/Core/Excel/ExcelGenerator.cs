using ArasDocumentExport.Core.Model;
using ClosedXML.Excel;

namespace ArasDocumentExport.Core.Excel
{
    internal class ExcelGenerator
    {
        public static void GenerateDocument(List<WtDocument> documents, string fileName)
        {
            using XLWorkbook wbook = new();

            IXLWorksheet ws = wbook.Worksheets.Add("Sheet1");

            int baseRowIndex = 1;
            foreach (WtDocument document in documents)
            {
                IEnumerable<ExcelColumnAttribute> dasicDefs = document.BasicProperties.GetColumnDefinitions();

                ws.Cell(baseRowIndex, 1).Value = "#BeginWTDocument";
                ws.Cell(baseRowIndex + 2, 1).Value = "BeginWTDocument";

                foreach (ExcelColumnAttribute def in dasicDefs)
                {
                    ws.Cell(baseRowIndex, def.Order + 1).Value = def.Name;
                    ws.Cell(baseRowIndex + 2, def.Order + 1).Value = def.Value;
                }

                List<IEnumerable<ExcelColumnAttribute>> propsCustomDefs = document.CustomProperties
                    .Select(p => p.GetColumnDefinitions())
                    .ToList();

                int customBaseIndex = baseRowIndex + 4;
                for (int i = 0; i < propsCustomDefs.Count(); i++)
                {
                    int currentBaseIndex = customBaseIndex + i * 3;

                    ws.Cell(currentBaseIndex, 1).Value = "#IBAValue";
                    ws.Cell(currentBaseIndex + 1, 1).Value = "IBAValue";

                    foreach (ExcelColumnAttribute customDef in propsCustomDefs[i])
                    {
                        ws.Cell(currentBaseIndex, customDef.Order + 1).Value = customDef.Name;
                        ws.Cell(currentBaseIndex + 1, customDef.Order + 1).Value = customDef.Value;
                    }
                }

                int fileBaseIndex = customBaseIndex + propsCustomDefs.Count() * 3;

                IEnumerable<ExcelColumnAttribute> fileDefs = document.FileReference.GetColumnDefinitions();

                ws.Cell(fileBaseIndex, 1).Value = "#EndWTDocument";
                ws.Cell(fileBaseIndex + 1, 1).Value = "EndWTDocument";

                foreach (ExcelColumnAttribute def in fileDefs)
                {
                    ws.Cell(fileBaseIndex, def.Order + 1).Value = def.Name;
                    ws.Cell(fileBaseIndex + 1, def.Order + 1).Value = def.Value;
                }

                baseRowIndex = fileBaseIndex + 3;
            }

            wbook.SaveAs(fileName);
        }

        public static void GeneratePartDocDescription(List<PartDocumentDescription> partDocDescriptions, string fileName)
        {
            using XLWorkbook wbook = new();

            IXLWorksheet ws = wbook.Worksheets.Add("Sheet1");

            int baseRowIndex = 1;
            foreach (PartDocumentDescription description in partDocDescriptions)
            {
                IEnumerable<ExcelColumnAttribute> dasicDefs = description.GetColumnDefinitions();

                ws.Cell(baseRowIndex, 1).Value = "#createPartDocDescribes";
                ws.Cell(baseRowIndex + 2, 1).Value = "PartDocDescribes";

                foreach (ExcelColumnAttribute def in dasicDefs)
                {
                    ws.Cell(baseRowIndex, def.Order + 1).Value = def.Name;
                    ws.Cell(baseRowIndex + 2, def.Order + 1).Value = def.Value;
                }

                baseRowIndex += 4;
            }

            wbook.SaveAs(fileName);
        }
    }
}
