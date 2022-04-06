using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDataAccess
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name = "doll", Price= 8.99m},
            new Product(){Name = "brush", Price = 3.00m},
            new Product(){Name = "Polly Pocket", Price = 9.99m}
        };

        public void SaveData()
        {
            Console.WriteLine("I am saving data to Mongo database.");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database.");
            return products;
        }
    }
}
