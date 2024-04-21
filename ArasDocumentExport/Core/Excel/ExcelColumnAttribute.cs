namespace ArasDocumentExport.Core.Excel
{
    internal class ExcelColumnAttribute : Attribute
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public string Value { get; set; } = string.Empty;

        public ExcelColumnAttribute(string name, int order)
        {
            Name = name;
            Order = order;
        }
    }
}
