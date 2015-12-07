using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.DAL.Interfaces;
using MusicStore.DAL.Repository;



namespace MusicStore.DAL.MusicStore
{
    public class ProductRepository : IProductRepository
    {
        private MusicStoreContext context = new MusicStoreContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}


