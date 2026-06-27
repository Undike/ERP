namespace ERP.Entities;

public class Product
{
   public int Id { get; set; }
   public string Article { get; set; } = "";
   public string IndexClientProduct { get; set; } = "";


   public int BaseMaterialId { get; set; }
   public Material BaseMaterial { get; set; } = null!;

   public int ProductShapeId { get; set; }
   public ProductShape Shape { get; set; } = null!;
   public List<ProductionTask> ProductionTasks { get; set; } = new();
   public DateOnly? DateLastOrder { get; set; }
}
