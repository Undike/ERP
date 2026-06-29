namespace ERP.Entities;

public class CartonBox
{
   public int Id { get; set; }
   public string Name { get; set; } = null!;
   public double LengthMm { get; set; }
   public double WidthMm { get; set; }
   public double HeightMm { get; set; }
}
