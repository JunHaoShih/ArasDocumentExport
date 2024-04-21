using ArasDocumentExport.Core.Excel;
using System.Reflection;

namespace ArasDocumentExport.Core.Model
{
    internal class ModelBase
    {
        public IEnumerable<ExcelColumnAttribute> GetColumnDefinitions()
        {
            PropertyInfo[] props = GetType().GetProperties();
            return props
                .Select(p =>
                {
                    ExcelColumnAttribute? def = p.GetCustomAttribute<ExcelColumnAttribute>(true);
                    if (def != null)
                    {
                        def.Value = p.GetValue(this)?.ToString() ?? "";
                    }
                    return def;
                })
                .Where(d => d is not null)
                .Select(d => d!);
        }
    }
}
