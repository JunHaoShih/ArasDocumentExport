// See https://aka.ms/new-console-template for more information
using ArasDocumentExport.Core.Excel;
using ArasDocumentExport.Core.Model;

BasicProperties basicProps = new()
{
    Number = "1",
    Name = "2",
    Title = "3",
    Type = "4",
    Description = "5",
    Department = "6",
    SaveIn = "7",
    TeamTemplate = "8",
    Domain = "9",
    LifeCycleTemplate = "10",
    LifeCycleState = "11",
    TypeDef = "12",
    Version = "13",
    Iteration = "14",
    SecurityLabels = "15",
};

List<CustomProperty> properties = new()
{
    new()
    {
        Definition = "classify_str",
        Value1 = "PM-",
    },
    new()
    {
        Definition = "Record_Type",
        Value1 = "Raw Material",
    },
    new()
    {
        Definition = "Document_Version",
        Value1 = "C",
    },
    new()
    {
        Definition = "Updated_Date",
        Value1 = "2015-04-30 00:00:00.000",
    },
};

FileReference fileReference = new()
{
    PrimaryContentType = "ApplicationData",
    Path = "E:\\Document_Demo\\DMR\\DMR_3PC001_REV.A\\1.PM-IME002.C.pdf",
};

WtDocument doc = new(basicProps, properties, fileReference);

ExcelGenerator.GenerateDocument(new()
{
    doc,
    doc,
}, "simple.xlsx");

PartDocumentDescription description = new()
{
    DocumentNumber = "1",
    PartNumber = "1",
    PartVersion = "A",
    PartIteration = "1",
    PartView = "Design",
};

ExcelGenerator.GeneratePartDocDescription(new()
{
    description,
    description,
}, "simple2.xlsx");
