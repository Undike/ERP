namespace ERP.Entities;

public class DieForm
{
   public int Id { get; set; }
   public string Name { get; set; } = null!;
   public int TotalYield { get; set; }
   public int Columns { get; set; }
   public int Rows { get; set; }
}
