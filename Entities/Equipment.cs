using System.ComponentModel.DataAnnotations;

namespace ERP.Entities;

public class Plotter
{
   public int Id { get; set; }

   [MaxLength(50)]
   public string Name { get; set; } = null!;
}

public class Printer
{
   public int Id { get; set; }

   [MaxLength(50)]
   public string Name { get; set; } = null!;
}
