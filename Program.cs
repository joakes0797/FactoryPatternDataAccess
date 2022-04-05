using System;

namespace FactoryPatternDataAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create:
            //A class called Product with 2 properties, Name and Price (I used decimal, ends with m)      --done
            //An interface called IDataAccess with 2 methods, LoadData() and SaveData()     --done
            //3 classes that implement the interface and its members (the methods), ListDataAccess,
            //      SQLDataAccess, and MongoDataAccess      --done
            //Last you will need to create a class called DataAccessFactory         --done

            //The 3 classes should provide implementations for the 2 methods:
            //LoadData(): Just print to the console “I am reading data from
            //      {whatever type class this is, i.e: list, SQL database, mongo database}” and then
            //       return a new list of Product.
            //SaveData(): Print “I am saving data to a { whatever type } database” to the console       --done

            //Fill out your factory:
            //This shall be a public static class       --done
            //There will be one method with the following signature:
            //      public static IDataAccess GetDataAccessType(string databaseType)        --done
            //Switch on the databaseType variable
            //          If a user types in “list” this should return a new instance of the ListDataAccess
            //          If a user types in “sql” this should return a new instance of the SQLDataAccess
            //          If a user types in “mongo” this should return a new instance of the MongoDataAccess     --done

            //In Main():
            //Ask the user what database they want to use: a List, SQL, or Mongo        --done
            //Store their response in a variable        --done
            //Call your factory method and pass in what the user types and store what your factory method
            //      returns in an IDataAccess variable      --done
            //Call the LoadData and SaveData methods of the IDataAccess variable        --done
            //Run the program a few times using the different types.        --done

            Console.WriteLine("Welcome to the Database Manager.");

            string result;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter which database you want to use.  Type List, SQL, or Mongo: ");
                result = Console.ReadLine().ToLower();
                if (result == "list" || result == "sql" || result == "mongo")
                {
                    isValid = true;
                }
            }while (!isValid);           
            

            IDataAccess database = DataAccessFactory.GetDataAccessType(result);
            var products = database.LoadData();
            database.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
            }
        }
    }
}
