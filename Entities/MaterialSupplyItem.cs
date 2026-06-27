namespace ERP.Entities;

public class MaterialSupplyItem
{
   public int Id { get; set; }
   public int MaterialSupplyId { get; set; }
   public DateTime dateTime {get; set;} 
}

public class MaterialSupplyItemPrintMedia : MaterialSupplyItem
{
   public int PrintMediaId { get; set; }
   public PrintMedia Material { get; set; } = new();
   public double LengthMeters { get; set; }
   public string Note { get; set; } = "";
}
