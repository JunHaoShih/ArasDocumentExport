using ArasDocumentExport.Core.Excel;

namespace ArasDocumentExport.Core.Model
{
    internal class WtDocument
    {
        public BasicProperties BasicProperties {  get; set; }

        public IEnumerable<CustomProperty> CustomProperties { get; set; }

        public FileReference FileReference { get; set; }

        public WtDocument(BasicProperties basicProperties, IEnumerable<CustomProperty> customProperties, FileReference fileReference)
        {
            BasicProperties = basicProperties;
            CustomProperties = customProperties;
            FileReference = fileReference;
        }
    }

    internal class BasicProperties : ModelBase
    {
        [ExcelColumn("number", 1)]
        public string Number { get; set; } = string.Empty;

        [ExcelColumn("name", 2)]
        public string Name { get; set; } = string.Empty;

        [ExcelColumn("title", 3)]
        public string Title { get; set; } = string.Empty;

        [ExcelColumn("type", 4)]
        public string Type { get; set; } = string.Empty;

        [ExcelColumn("description", 5)]
        public string Description { get; set; } = string.Empty;

        [ExcelColumn("department", 6)]
        public string Department { get; set; } = string.Empty;

        [ExcelColumn("saveIn", 7)]
        public string SaveIn { get; set; } = string.Empty;

        [ExcelColumn("teamTemplate", 8)]
        public string TeamTemplate { get; set; } = string.Empty;

        [ExcelColumn("domain", 9)]
        public string Domain { get; set; } = string.Empty;

        [ExcelColumn("lifecycletemplate", 10)]
        public string LifeCycleTemplate { get; set; } = string.Empty;

        [ExcelColumn("lifecyclestate", 11)]
        public string LifeCycleState { get; set; } = string.Empty;

        [ExcelColumn("typedef", 12)]
        public string TypeDef { get; set; } = string.Empty;

        [ExcelColumn("version", 13)]
        public string Version { get; set; } = string.Empty;

        [ExcelColumn("iteration", 14)]
        public string Iteration { get; set; } = string.Empty;

        [ExcelColumn("securityLabels", 15)]
        public string SecurityLabels { get; set; } = string.Empty;
    }

    internal class CustomProperty : ModelBase
    {
        [ExcelColumn("definition", 1)]
        public string Definition { get; set; } = string.Empty;

        [ExcelColumn("value1", 2)]
        public string Value1 { get; set; } = string.Empty;

        [ExcelColumn("value2", 3)]
        public string Value2 { get; set; } = string.Empty;

        [ExcelColumn("dependency_id", 4)]
        public string DependencyId { get; set; } = string.Empty;
    }

    internal class FileReference : ModelBase
    {
        [ExcelColumn("primarycontenttype", 1)]
        public string PrimaryContentType { get; set; } = string.Empty;

        [ExcelColumn("path", 2)]
        public string Path { get; set; } = string.Empty;

        [ExcelColumn("format", 3)]
        public string Format { get; set; } = string.Empty;

        [ExcelColumn("contdesc", 4)]
        public string ContentDescription { get; set; } = string.Empty;

        [ExcelColumn("parentContainerPath", 5)]
        public string ParentContainerPath { get; set; } = string.Empty;
    }
}
