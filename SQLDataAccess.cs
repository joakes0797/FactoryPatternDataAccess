﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDataAccess
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>() 
        { 
            new Product(){Name = "basketball", Price= 19.99m},
            new Product(){Name = "baseball", Price = 12.99m},
            new Product(){Name = "volleyball", Price = 15.99m}        
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
