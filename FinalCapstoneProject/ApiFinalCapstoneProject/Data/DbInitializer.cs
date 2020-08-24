using ApiFinalCapstoneProject.Data;
using FinalCapstoneProject.Models;
using System.Linq;

namespace FinalCapstoneProject.Data
{
    public class DbInitializer
    {
        public static void Initialize(CarContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Cars.Any())
            {
                context.Cars.Add(new Car() { Make = "Ford", Model = "Edge", Year = 2020, Color = "Red" });
                context.Cars.Add(new Car() { Make = "Ford", Model = "Fusion", Year = 2020, Color = "White" });
                context.Cars.Add(new Car() { Make = "Tesla", Model = "Model 3", Year = 2020, Color = "Black" });
                context.Cars.Add(new Car() { Make = "Ram", Model = "2500", Year = 2020, Color = "Black" });
                context.Cars.Add(new Car() { Make = "Tesla", Model = "Model X", Year = 2020, Color = "Grey" });
            }
            context.SaveChanges();
        }
    }
}
