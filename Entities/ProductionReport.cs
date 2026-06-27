namespace ERP.Entities;

public class ProductionReport
{
   public int Id { get; set; }
   public DateOnly DateFinished { get; set; } = DateOnly.FromDateTime(DateTime.Today);
   public int MinutsSpend { get; set; }
   public int ProductTaskId { get; set; }
   public ProductionTask ProductionTask { get; set; } = null!;
   public int WorkersCount { get; set; }
   public double ActualQuantityUsed { get; set; }
}

