namespace ERP.Entities;

public class ProductionReport
{
   public int Id { get; set; }

   public int ProductTaskId { get; set; }
   public ProductionTask ProductionTask { get; set; } = null!;

   public DateOnly DateFinished { get; set; } = DateOnly.FromDateTime(DateTime.Today);

   public int RunMinutesSpent { get; set; }

   public string OperatorComment { get; set; } = string.Empty;
}

public class PrintingReport : ProductionReport
{
   public int SetupMinutesSpent { get; set; }

   public double ActualMaterialUsedMeters { get; set; }

   public int SnapshotMaterialWidthMm { get; set; }

   public double ActualMaterialUsedSquareMeters
   {
      get
      {
         double widthInMeters = SnapshotMaterialWidthMm / 1000.0;
         return ActualMaterialUsedMeters * widthInMeters;
      }
   }
}

public class PlotterReport : ProductionReport
{
   public int SetupMinutesSpent { get; set; }

   public double? ActualMaterialUsedMeters { get; set; }

   public int? SnapshotMaterialWidthMm { get; set; }

   public double ActualMaterialUsedSquareMeters
   {
      get
      {
         if (ActualMaterialUsedMeters == null || SnapshotMaterialWidthMm == null)
         {
            return 0;
         }

         double widthInMeters = SnapshotMaterialWidthMm.Value / 1000.0;
         return ActualMaterialUsedMeters.Value * widthInMeters;
      }
   }
}

//! Laminator
public class LaminationReport : ProductionReport
{
   public double? ActualBaseMaterialUsedMeters { get; set; }
   public int? SnapshotBaseMaterialWidthMm { get; set; }

   public List<LaminatorReportMaterial> UsedMaterials { get; set; } = new();

   public double ActualBaseMaterialUsedSquareMeters
   {
      get
      {
         if (ActualBaseMaterialUsedMeters == null || SnapshotBaseMaterialWidthMm == null)
            return 0;

         return ActualBaseMaterialUsedMeters.Value * (SnapshotBaseMaterialWidthMm.Value / 1000.0);
      }
   }
}

public class LaminatorReportMaterial
{
   public int Id { get; set; }

   public int LaminationReportId { get; set; }
   public LaminationReport LaminationReport { get; set; } = null!;

   public int LaminationStepOperationId { get; set; }
   public LaminationStepOperation LaminationStepOperation { get; set; } = null!;

   public double ActualMaterialUsedMeters { get; set; }

   public int SnapshotMaterialWidthMm { get; set; }

   public double ActualMaterialUsedSquareMeters
   {
      get
      {
         return ActualMaterialUsedMeters * (SnapshotMaterialWidthMm / 1000.0);
      }
   }
}

public class PolyurethaneReport : ProductionReport
{
   public int SetupMinutesSpent { get; set; }
   public int PostProcessingMinutesSpent { get; set; }

   public double ActualPolyurethaneUsedKg { get; set; }
}