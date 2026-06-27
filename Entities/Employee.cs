namespace ERP.Entities;

public class Employee
{
   public int Id { get; set; }
   public string Name { get; set; } = "John";
   public string Surname { get; set; } = "Doe";
   public EmployeeRole Role { get; set; } = EmployeeRole.SalesManager;
   public string EmployeeInitials { get; set; } = "";
   public string PhoneNumber { get; set; } = "";
   public string Email { get; set; } = "";

   public Employee(string name, string surname, EmployeeRole role)
   {
      Name = name;
      Surname = surname;
      Role = role;

      char firstInitial = string.IsNullOrEmpty(Name) ? '?' : Name[0];
      char lastInitial = string.IsNullOrEmpty(Surname) ? '?' : Surname[0];
      EmployeeInitials = $"{firstInitial}{lastInitial}";
   }
}
