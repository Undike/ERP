using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Pages
{
    public class OrdersModel : PageModel
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        public void OnGet()
        {
            Orders.Add(new Order
            {
                Id = 1,
                ClientId = 1,
                ClientName = "Marble",
                OrderDate = DateTime.Now.AddDays(-2),
                PrintingMethod = PrintingMethod.MATAN,
                Is3D = true,
                Status = OrderStatus.Processing,
                DeliveryDate = DateTime.Now.AddDays(5),
                SalesManager = new Employee("Alice", "Smith", EmployeeRole.SalesManager)
            });
            Orders.Add(new Order
            {
                Id = 2,
                ClientId = 2,
                ClientName = "StoneCo",
                OrderDate = DateTime.Now.AddDays(-1),
                PrintingMethod = PrintingMethod.RESIN,
                Is3D = false,
                Status = OrderStatus.Pending,
                DeliveryDate = DateTime.Now.AddDays(10),
                SalesManager = new Employee("Bob", "Johnson", EmployeeRole.SalesManager)
            });
            Orders.Add(new Order
            {
                Id = 3,
                ClientId = 3,
                ClientName = "RockSolid",
                OrderDate = DateTime.Now,
                PrintingMethod = PrintingMethod.ROLAND,
                Is3D = true,
                Status = OrderStatus.Shipped,
                DeliveryDate = DateTime.Now.AddDays(3),
                SalesManager = new Employee("Charlie", "Brown", EmployeeRole.SalesManager)
            });
        }
    }
}
