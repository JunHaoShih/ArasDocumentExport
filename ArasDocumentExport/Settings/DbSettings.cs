namespace ArasDocumentExport.Settings
{
    internal class DbSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string VaultPath { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string DocumentExcel { get; set; } = null!;

        public string PartExcel { get; set; } = null!;

        public string OutputFolder { get; set; } = null!;
    }
}
