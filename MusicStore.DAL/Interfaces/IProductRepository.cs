using MusicStore.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Interfaces
{
    public interface IProductRepository
    {

        IEnumerable<Product> Products { get; }
    }
}
