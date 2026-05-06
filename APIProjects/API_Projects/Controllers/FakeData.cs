using API_Projects.Models;
namespace API_Projects.Controllers
{
    public static class Data
    {
        public static List<API_Projects.Models.Product> Products = [
                new API_Projects.Models.Product{Id=1,Name="TV Samsung",Category="Electronics",IsAvailable=true,Price=500},
                new API_Projects.Models.Product{Id=2,Name="TV LG",Category="Electronics",IsAvailable=true,Price=400},
                new API_Projects.Models.Product{Id=3,Name="Hummer",Category="Equipment",IsAvailable=true,Price=300},
                new API_Projects.Models.Product{Id=4,Name="TV Samsung",Category="Electronics",IsAvailable=true,Price=200},
                new API_Projects.Models.Product{Id=5,Name="PS5",Category="Game",IsAvailable=true,Price=1500},
                new API_Projects.Models.Product{Id=6,Name="LG Motor",Category="Transport",IsAvailable=true,Price=2500},
                new API_Projects.Models.Product{Id=7,Name="Bike",Category="Transport",IsAvailable=true,Price=700},
                new API_Projects.Models.Product{Id=8,Name="Sumsung Watch",Category="Watches",IsAvailable=true,Price=350},
                new API_Projects.Models.Product{Id=9,Name="Apple Watch",Category="Watches",IsAvailable=true,Price=1700},
            ];
        public static List<API_Projects.Models.Order> Orders = [];
    }

    }

