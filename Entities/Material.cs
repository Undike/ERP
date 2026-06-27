namespace ERP.Entities;

public class Material
{
   public int Id { get; set; }
   public string Name { get; set; } = "";
   public string UnitOfMeasure { get; set; } = "";
}

public class PrintMedia : Material
{
   public string Type { get; set; } = "";
   public int WitdthMm { get; set; }
   public int DensityGsm { get; set; }
   public double LengthMeters { get; set; }
   public string Color { get; set; } = "";
   public PrintMedia()
   {
      UnitOfMeasure = "M";
   }
}

public class Ink : Material
{
   public string ColorNumber { get; set; } = "";
   public string ColorName { get; set; } = "";
   public string InkType { get; set; } = "";
   public Ink()
   {
      UnitOfMeasure = "Szt";
   }
}

public class Drum3D : Material
{
   public double DrumWeight { get; set; }
   public Drum3D()
   {
      UnitOfMeasure = "Kg";
   }
}