using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPages.DataBaseModels;

namespace TestPages.Repo
{
    public class DataBaseRepo
    {
        public ICrud<Product> Products { get; private set; }
        public DataBaseRepo(DataBaseContext context)
        {
            Products = new ProductsRepo(context);
        }

    }
}
