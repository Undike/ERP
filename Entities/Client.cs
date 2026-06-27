namespace ERP.Entities;

public class Client
{
   public int Id { get; set; }
   public string Name { get; set; } = "NoName";
   public string Email { get; set; } = "";
   public string Phone { get; set; } = "";
   public string Adress { get; set; } = "";
   public string Country { get; set; } = "";
   public string City { get; set; } = "";
   public string PostalCode { get; set; } = "";
   public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Today);
   public List<Order> Orders { get; set; } = new List<Order>();

   //TODO Добавить другие данные клиента 
}
