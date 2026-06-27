namespace ERP.Entities;

public class MaterialStock
{
   public int Id { get; set; }

   public int MaterialId { get; set; }
   public Material Material { get; set; } = null!;

   public double Quantity { get; set; }
}
