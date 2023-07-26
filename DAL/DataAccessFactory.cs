using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Registration, int, Registration> RegistrationDataAccess() { return new RegistrationRepo(); }
        public static IRepo<Product, int, Product> ProductDataAccess() { return new ProductRepo(); }
        public static IRepo<Cart, int, Cart> CartDataAccess() { return new CartRepo(); }
        public static IRepo<Admin, int, Admin> AdminDataAccess() { return new AdminRepo(); }
        public static IRepo<TrackOrder, int, TrackOrder> TrackOrderDataAccess() { return new TrackOrderRepo(); }
        public static IRepo<Payment, int, Payment> PaymentDataAccess() { return new PaymentRepo(); }
        public static IRepo<Sold_Items, int, Sold_Items> SoldItemDataAccess() { return new SoldItemRepo(); }
        public static IRepo<ProductInventory, int, ProductInventory> ProductInventoryDataAccess() { return new ProductInventoryRepo(); }
       // public static IRepo<Auth, string, Auth> AuthDataAccess() { return new TokenRepo(); }
    }
}
