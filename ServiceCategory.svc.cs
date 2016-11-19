using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmarketWS 
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCategory" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCategory.svc or ServiceCategory.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCategory : IServiceCategory
    {
        public bool create(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    int idStore = Convert.ToInt32(category.idStore);
                    CategoryEntity cat = new CategoryEntity();
                    cat.idCategory  = idCategory;
                    cat.idStore = idStore;
                    cat.Name = category.Name;
                    mdeEmarket.CategoryEntities.Add(cat);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool delete(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    CategoryEntity cat = mdeEmarket.CategoryEntities.Single(p => p.idCategory == idCategory);

                    mdeEmarket.SaveChanges();
                    mdeEmarket.CategoryEntities.Remove(cat);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool edit(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    int idStore = Convert.ToInt32(category.idStore);
                    CategoryEntity cat = mdeEmarket.CategoryEntities.Single( p => p.idCategory == idCategory );
                    cat.idCategory = idCategory;
                    cat.idStore = idStore;
                    cat.Name = category.Name;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public Category find(String id)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {

                int idCategory = Convert.ToInt32(id); 
                 return mdeEmarket.CategoryEntities.Where(cat => cat.idCategory == idCategory).Select(cat => new Category
                {
                    idCategory = Convert.ToString(cat.idCategory),
                    idStore = Convert.ToString(cat.idStore),
                    Name = cat.Name
                }).First();
            }
        }

        public List<Category> findAll()
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                return mdeEmarket.CategoryEntities.Select(cat => new Category {
                    idCategory = Convert.ToString(cat.idCategory),
                    idStore    = Convert.ToString(cat.idStore),
                    Name       = cat.Name
                }).ToList();
            }
        }
    }
}
