using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDataAccess
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new MongoDataAccess();
            }
        }
    }
}
