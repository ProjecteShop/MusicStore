using System.Collections.Generic;
using MusicStore.DAL.Repository;


namespace MusicStore.Models {
    public class ProductsListViewModel {

        public IEnumerable<Product> Products { get; set; }
        public InformationPage PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}