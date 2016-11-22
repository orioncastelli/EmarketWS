using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmarketWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Services" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Services.svc or Services.svc.cs at the Solution Explorer and start debugging.
    public class Services : IServices
    {
        /**************************************** CATEGORIES *******************************************/
        public bool createCategory(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    int idStore = Convert.ToInt32(category.idStore);
                    CategoryEntity cat = new CategoryEntity();
                    cat.idCategory = idCategory;
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

        public bool deleteCategory(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    CategoryEntity cat = mdeEmarket.CategoryEntities.Single(p => p.idCategory == idCategory);

                    mdeEmarket.CategoryEntities.Remove(cat);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editCategory(Category category)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idCategory = Convert.ToInt32(category.idCategory);
                    int idStore = Convert.ToInt32(category.idStore);
                    CategoryEntity cat = mdeEmarket.CategoryEntities.Single(p => p.idCategory == idCategory);
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

        public Category findCategory(String id)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {

                int idCategory = Convert.ToInt32(id);
                return mdeEmarket.CategoryEntities.Where(cat => cat.idCategory == idCategory).Select(cat => new Category
                {
                    idCategory = cat.idCategory,
                    idStore = cat.idStore,
                    Name = cat.Name
                }).First();
            }
        }

        public List<Category> findAllCategory()
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                return mdeEmarket.CategoryEntities.Select(cat => new Category
                {
                    idCategory = cat.idCategory,
                    idStore = cat.idStore,
                    Name = cat.Name
                }).ToList();
            }
        }

        /***********************************************************************************************/

        /**************************************** LIST *************************************************/
        public bool createList(List List)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idList = Convert.ToInt32(List.idList);
                    int idUser = Convert.ToInt32(List.idUser);
                    ListEntity list = new ListEntity();
                    list.idList = idList;
                    list.idUser = idUser;
                    list.Name = List.Name;
                    list.idProductName = List.idProductName;
                    mdeEmarket.ListEntities.Add(list);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteList(List List)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idList = Convert.ToInt32(List.idList);
                    ListEntity list = mdeEmarket.ListEntities.Single(p => p.idList == idList);

                    mdeEmarket.ListEntities.Remove(list);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editList(List List)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                try
                {
                    int idList = Convert.ToInt32(List.idList);
                    int idUser = Convert.ToInt32(List.idUser);
                    ListEntity list = mdeEmarket.ListEntities.Single(p => p.idList == idList && 
                                                                          p.idUser == idUser && 
                                                                          p.idProductName == List.idProductName );
                                                                            
                    list.idList = idList;
                    list.idUser = idUser;
                    list.Name = List.Name;
                    list.idProductName = List.idProductName;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List findList(string id)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {

                int idList = Convert.ToInt32(id);
                return mdeEmarket.ListEntities.Where(list => list.idList == idList).Select(list => new List
                {
                    idList = list.idList,
                    idUser = list.idUser,
                    Name = list.Name,
                    idProductName = list.idProductName
                }).First();
            }
        }

        public List<List> findAllList()
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                return mdeEmarket.ListEntities.Select(list => new List
                {
                    idList = list.idList,
                    idUser = list.idUser,
                    Name = list.Name,
                    idProductName = list.idProductName
                }).ToList();
            }
        }

        public List<List> findListByUser(string idUser)
        {
            using (EMarktEntities mdeEmarket = new EMarktEntities())
            {
                int id = Convert.ToInt32(idUser);
                return mdeEmarket.ListEntities.Where(list => list.idUser == id).Select(list => new List
                {
                    idList = list.idList,
                    idUser = list.idUser,
                    Name = list.Name,
                    idProductName = list.idProductName
                }).ToList();
            }
        }
        /***********************************************************************************************/
    }

}
