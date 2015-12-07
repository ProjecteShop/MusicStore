using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MusicStore.DAL.Repository;

namespace MusicStore.DAL.MusicStore
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
