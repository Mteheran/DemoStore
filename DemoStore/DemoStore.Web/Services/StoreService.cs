using DemoStore.Web.Helper;
using DemoStore.Web.Models;
using DemoStore.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DemoStore.Web.Services
{
    public class StoreService
    {

        Repository.LocalDBEntities localdbRepository { get; set; }
        const string CATEGORIES = "CATEGORIES";
        const string PRODUCTS = "PRODUCTS";

        public StoreService()
        {
            localdbRepository = new LocalDBEntities();
        }

        public async Task<List<Repository.Category>> GetCategories()
        {
            List<Repository.Category> lst = new List<Repository.Category>();
            if (VarsHelper.GetDataMode() == Enums.ModeType.SQLData)
            {
                lst = localdbRepository.Categories.ToList();
            }
            else if (VarsHelper.GetDataMode() == Enums.ModeType.InMemory)
            {
                lst = (List<Repository.Category>)InMemoryAdapter.Get(CATEGORIES);

                if (lst==null)
                {
                    lst = new List<Repository.Category>();
                    lst.Add(new Repository.Category() { Id = Guid.NewGuid().ToString(), Name = "Food" });
                    lst.Add(new Repository.Category() { Id = Guid.NewGuid().ToString(), Name = "Shoes" });
                    lst.Add(new Repository.Category() { Id = Guid.NewGuid().ToString(), Name = "Books" });
                    InMemoryAdapter.Set<List<Repository.Category>>(CATEGORIES, lst);
                }
            }
            

            return lst;
        }


        public async Task<List<Repository.Product>> GetProducts()
        {
            List<Repository.Product> lst = new List<Repository.Product>();

            if (VarsHelper.GetDataMode() == Enums.ModeType.SQLData)
            {
                lst = localdbRepository.Products.ToList();
            }
            else if (VarsHelper.GetDataMode() == Enums.ModeType.InMemory)
            {
                lst = (List<Repository.Product>)InMemoryAdapter.Get(PRODUCTS);
                if (lst==null)
                    lst = new List<Repository.Product>();
            }


            return lst;
        }


        public async Task<bool> SaveProduct(ProductViewModel product)
        {
            try
            {            
            // TODO: Add insert logic here
            product.Product_obj.Id = Guid.NewGuid().ToString();

            if (VarsHelper.GetDataMode() == Enums.ModeType.SQLData)
             {
                    localdbRepository.Products.Add(product.Product_obj);

                    foreach (var item in product.CategoryId)
                    {
                        localdbRepository.Product_Category.Add(new Product_Category() { Id = Guid.NewGuid().ToString(), Category_Id = item, Product_Id = product.Product_obj.Id });
                    }


                    await localdbRepository.SaveChangesAsync();

            }
                else
                {
                    List<Repository.Product> lst = new List<Repository.Product>();
                    lst = (List<Repository.Product>)InMemoryAdapter.Get(PRODUCTS);
                    if (lst == null)
                        lst = new List<Repository.Product>();

                    lst.Add(product.Product_obj);

                    InMemoryAdapter.Set<List<Repository.Product>>(PRODUCTS, lst);

                }

            return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
        
      }
}