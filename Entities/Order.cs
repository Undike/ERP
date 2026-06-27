namespace ERP.Entities;

public class Order
{
   public int Id { get; set; }
   public string OrderNumber { get; set; } = null!;
   public int CLientId { get; set; }
   public Client Client { get; set; } = null!;
   public DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.Today);

   public List<OrderItem> OrderItems { get; set; } = new();
}

public class OrderItem
{
   public int Id { get; set; }

   public int OrderId { get; set; }
   public Order Order { get; set; } = null!;

   public int ProductId { get; set; }
   public Product Product { get; set; } = null!;

   public PrintSheetFormat PrintSheetFormat { get; set; } = null!;
   public int PrintSheetCount { get; set; }

   public double PlannedLengthMeters { get; set; }

   public int TargetQuantity { get; set; }

   public List<ProductionTask> ProductionTasks { get; set; } = new();
}