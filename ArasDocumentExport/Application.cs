using ArasDocumentExport.Core.Excel;
using ArasDocumentExport.Core.Model;
using ArasDocumentExport.Models;
using ArasDocumentExport.Settings;
using Microsoft.EntityFrameworkCore;

namespace ArasDocumentExport
{
    internal class Application
    {
        private readonly ArasContext _arasContext;

        private readonly DbSettings _dbSettings;

        public Application(ArasContext arasContext, DbSettings dbSettings)
        {
            _arasContext = arasContext;
            _dbSettings = dbSettings;
        }

        public void Start()
        {
            CreateDocumentExcel();
            CreatePartExcel();
        }

        private void CreateDocumentExcel()
        {
            List<WtDocument> wtDocuments = new();
            _arasContext.Documents
                .Where(doc => doc.IsCurrent == "1")
                .Include(doc => doc.DocumentFiles.Where(file => file.IsCurrent == "1"))
                .ThenInclude(file => file.Related)
                .ToList()
                .ForEach(doc =>
                {
                    BasicProperties basicProps = new()
                    {
                        Number = doc.ItemNumber,
                        Name = doc.Name ?? string.Empty,
                        Title = doc.Name ?? string.Empty,
                        Type = "Document",
                        Description = doc.Description ?? string.Empty,
                        Department = "DESIGN",
                        SaveIn = "/Default/DMR",
                        TeamTemplate = "",
                        Domain = "",
                        LifeCycleTemplate = "IMMDoc_LC",
                        LifeCycleState = "RELEASED",
                        TypeDef = "tw.com.immc.plmtest.DMR",
                        Version = "A",
                        Iteration = "1",
                        SecurityLabels = "",
                    };

                    List<CustomProperty> properties = new()
                    {
                        new()
                        {
                            Definition = "classify_str",
                            Value1 = doc.ClassifyStr ?? string.Empty,
                        },
                        new()
                        {
                            Definition = "Record_Type",
                            Value1 = doc.RecordType ?? string.Empty,
                        },
                        new()
                        {
                            Definition = "Document_Version",
                            Value1 = doc.DocumentVersion ?? string.Empty,
                        },
                        new()
                        {
                            Definition = "Updated_Date",
                            Value1 = doc.UpdatedDate?.ToString() ?? DateTime.Now.ToString(),
                        },
                    };

                    if (doc.DocumentFiles.Count == 0)
                    {
                        wtDocuments.Add(new(basicProps, properties, new()
                        {
                            PrimaryContentType = "ApplicationData",
                            Path = "",
                        }));
                    }
                    else
                    {
                        Models.File file = doc.DocumentFiles.ToList()[0].Related!;
                        string fileName = file.Filename;
                        string id = file.Id;
                        string firstFolder = id.Substring(0, 1);
                        string secondFolder = id.Substring(1, 2);
                        string thirdFolder = id.Substring(3);
                        FileReference fileReference = new()
                        {
                            PrimaryContentType = "ApplicationData",
                            Path = Path.Combine(
                                _dbSettings.VaultPath,
                                _dbSettings.DatabaseName,
                                firstFolder,
                                secondFolder,
                                thirdFolder,
                                file.Filename),
                        };
                        wtDocuments.Add(new(basicProps, properties, fileReference));
                    }
                });
            ExcelGenerator.GenerateDocument(wtDocuments, Path.Combine(_dbSettings.OutputFolder, _dbSettings.DocumentExcel));
        }

        private void CreatePartExcel()
        {
            List<PartDocumentDescription> partDocuments = new();

            _arasContext.Parts
                .Where(part => part.IsCurrent == "1")
                .Include(part => part.PartDocuments.Where(part => part.IsCurrent == "1"))
                .ThenInclude(file => file.Related)
                .ToList()
                .ForEach(part =>
                {
                    Document? doc = part.PartDocuments.FirstOrDefault()?.Related;
                    PartDocumentDescription description = new()
                    {
                        DocumentNumber = doc?.ItemNumber ?? string.Empty,
                        PartNumber = part.ItemNumber,
                        PartVersion = "A",
                        PartIteration = "1",
                        PartView = "Design",
                    };
                    partDocuments.Add(description);
                });

            ExcelGenerator.GeneratePartDocDescription(partDocuments, Path.Combine(_dbSettings.OutputFolder, _dbSettings.PartExcel));
        }
    }
}
