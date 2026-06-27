namespace ERP.Entities;

public abstract class ProductShape
{
   public int Id { get; set; }
}

public class ProductCircleShape : ProductShape
{
   public double Radius { get; set; }
}

public class ProductBoxShape : ProductShape
{
   public double Witdth { get; set; }
   public double Height { get; set; }

   public bool IsCustomContour { get; set; }
}
