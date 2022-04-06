using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDataAccess
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>() 
        { 
            new Product(){Name = "toy car", Price= 0.99m},
            new Product(){Name = "Tonka truck", Price = 33.00m},
            new Product(){Name = "Big Wheels", Price = 25.99m}        
        };        

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQL database.");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database.");
            return products;
        }
    }
}
