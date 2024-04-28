using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Chart
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? BackgroundStyle { get; set; }

    public int? BarSpacing { get; set; }

    public int? BorderBottom { get; set; }

    public int? BorderLeft { get; set; }

    public int? BorderRight { get; set; }

    public int? BorderTop { get; set; }

    public string? ChartType { get; set; }

    public int? Height { get; set; }

    public string? Legend { get; set; }

    public string? LegendBoxStyle { get; set; }

    public int? LegendHeight { get; set; }

    public string? LegendTextStyle { get; set; }

    public int? LegendWidth { get; set; }

    public int? LegendX { get; set; }

    public int? LegendY { get; set; }

    public int? MarkerSize { get; set; }

    public string? MarkerStyle { get; set; }

    public string? Name { get; set; }

    public int? Radius { get; set; }

    public string? Title { get; set; }

    public string? TitleStyle { get; set; }

    public int? Width { get; set; }

    public string? XAxis { get; set; }

    public string? XAxisLabel { get; set; }

    public string? XAxisLabelStyle { get; set; }

    public string? XAxisStyle { get; set; }

    public string? XAxisValueLabelStyle { get; set; }

    public string? XAxisValueLabels { get; set; }

    public string? XGrid { get; set; }

    public double? XGridInterval { get; set; }

    public string? XGridStyle { get; set; }

    public double? XMax { get; set; }

    public double? XMin { get; set; }

    public string? YAxis { get; set; }

    public string? YAxisLabel { get; set; }

    public string? YAxisLabelStyle { get; set; }

    public string? YAxisStyle { get; set; }

    public string? YAxisValueLabelStyle { get; set; }

    public string? YAxisValueLabels { get; set; }

    public string? YGrid { get; set; }

    public double? YGridInterval { get; set; }

    public string? YGridStyle { get; set; }

    public double? YMax { get; set; }

    public double? YMin { get; set; }

    public virtual ICollection<ChartSeries> ChartSeries { get; set; } = new List<ChartSeries>();

    public virtual ICollection<DashboardChart> DashboardCharts { get; set; } = new List<DashboardChart>();
}
