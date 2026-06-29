namespace ERP.Entities;

public class ProductionTask
{
   public int Id { get; set; }
   public int ProductId { get; set; }

   public int? ProductionReportId { get; set; }
   public ProductionReport? Report { get; set; }
}

public class PrintingTask : ProductionTask
{
   public int RequiredPrinterId { get; set; }
   public Printer RequiredPrinter { get; set; } = null!;
   public List<Ink> RequiredInks { get; set; } = new();
}

public class PlotterTask : ProductionTask
{
   public int? PlotterId { get; set; }
   public Plotter? Plotter { get; set; }
   public PlotterOperationType OperationType { get; set; }
}

//!Laminator
public class LaminationStepOperation
{
   public int Id { get; set; }
   public LaminationOperationType LaminationOperationType { get; set; }

   public int MaterialId { get; set; }
   public Material Material { get; set; } = null!;
}

public class LaminationTask : ProductionTask
{
   public List<LaminationStepOperation> LaminationStepOperation { get; set; } = new();
}

public class PolyurethaneTask : ProductionTask
{
   public PolyurethaneHardness PolyurethaneHardness { get; set; }
}

public class GuillotineTask : ProductionTask
{
   public GuillotineCutType GuillotineCutType { get; set; }
}

public class DieCuttingTask : ProductionTask
{
   public DieForm DieForm { get; set; } = null!;
}

public class WeedingTask : ProductionTask
{
   public WeedingComplexity WeedingComplexity { get; set; }
}

public class PackingTask : ProductionTask
{
   public CartonBox? CartonBox { get; set; }
   public int QuantityPerPackage { get; set; }
   public int TotalPackagesCount { get; set; }
}