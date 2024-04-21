using ArasDocumentExport.Core.Excel;

namespace ArasDocumentExport.Core.Model
{
    internal class PartDocumentDescription : ModelBase
    {
        [ExcelColumn("docNumber", 1)]
        public string DocumentNumber { get; set; } = string.Empty;

        [ExcelColumn("docVersion", 2)]
        public string DocumentVersion { get; set; } = string.Empty;

        [ExcelColumn("docIteration", 3)]
        public string DocumentIteration { get; set; } = string.Empty;

        [ExcelColumn("partNumber", 4)]
        public string PartNumber { get; set; } = string.Empty;

        [ExcelColumn("partVersion", 5)]
        public string PartVersion { get; set; } = string.Empty;

        [ExcelColumn("partIteration", 6)]
        public string PartIteration { get; set; } = string.Empty;

        [ExcelColumn("partView", 7)]
        public string PartView { get; set; } = string.Empty;
    }
}
