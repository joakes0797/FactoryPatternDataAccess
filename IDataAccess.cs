using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDataAccess
{
    public interface IDataAccess
    {
        public List<Product> LoadData();
        public void SaveData();
    }
}
