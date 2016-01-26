using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.DAL.Repository;

namespace MusicStore.Models
{
    public class CartView
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}