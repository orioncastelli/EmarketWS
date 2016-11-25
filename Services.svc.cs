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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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
            using (EmarketEntities mdeEmarket = new EmarketEntities())
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


        /**************************************** NFC **************************************************/
        public bool createNFC(NFC objNFC)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    int idScan = Convert.ToInt32(objNFC.idScan);
                    int idUser = Convert.ToInt32(objNFC.idUser);
                    NFCeEntity entNFC = new NFCeEntity();
                    entNFC.idNF = objNFC.idNF;
                    entNFC.idUser = idUser;
                    entNFC.idScan = idScan;
                    entNFC.StoreCNPJ = objNFC.StoreCNPJ;
                    mdeEmarket.NFCeEntities.Add(entNFC);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteNFC(NFC objNFC)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    NFCeEntity NFC = mdeEmarket.NFCeEntities.Single(p => p.idNF == objNFC.idNF);

                    mdeEmarket.NFCeEntities.Remove(NFC);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editNFC(NFC objNFC)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    int idUser = Convert.ToInt32(objNFC.idUser);
                    int idScan = Convert.ToInt32(objNFC.idScan);
                    int StoreCNPJ = Convert.ToInt32(objNFC.StoreCNPJ);
                    NFCeEntity NFC = mdeEmarket.NFCeEntities.Single(p => p.idNF   == objNFC.idNF &&
                                                                         p.idUser == idUser &&
                                                                         p.idScan == idScan);

                    NFC.idNF = objNFC.idNF;
                    NFC.idUser = idUser;
                    NFC.idScan = idScan;
                    NFC.StoreCNPJ = StoreCNPJ;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public NFC findNFC(string id)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {

                return mdeEmarket.NFCeEntities.Where(objNFC => objNFC.idNF == id).Select(objNFC => new NFC
                {
                    idNF        = objNFC.idNF,
                    idUser      = objNFC.idUser,
                    idScan      = objNFC.idScan
                }).First();
            }
        }

        public List<NFC> findAllNFC()
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                return mdeEmarket.NFCeEntities.Select(NFC => new NFC
                {
                    idNF = NFC.idNF,
                    idUser = NFC.idUser,
                    idScan = NFC.idScan,
                    StoreCNPJ = NFC.StoreCNPJ
                }).ToList();
            }
        }

        public List<NFC> findNFCByUser(string idUser)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                int id = Convert.ToInt32(idUser);
                return mdeEmarket.NFCeEntities.Where(objNFC => objNFC.idUser == id).Select(objNFC => new NFC
                {
                    idNF      = objNFC.idNF,
                    idUser    = objNFC.idUser,
                    idScan    = objNFC.idScan,
                    StoreCNPJ = objNFC.StoreCNPJ
                }).ToList();
            }
        }
        /***********************************************************************************************/

        /************************************* Product *************************************************/
        public Product findProduct(string id)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {

                int idProduct = Convert.ToInt32(id);
                return mdeEmarket.ProductEntities.Where(Product => Product.idProduct == idProduct).Select(Product => new Product
                {
                    idProduct = Product.idProduct,
                    idCategory = Product.idCategory,
                    idStore = Product.idStore,
                    ProductImportCode = Product.ProductImportCode,
                    ProductImportName = Product.ProductImportName,
                    Name = Product.Name,
                    Price = Product.Price,
                    Image = Product.Image,
                    LastUpdDt = Product.LastUpdtDt,
                    LastUpdHr = Product.LastUpdtHr,
                    AllBranch = Product.AllBranch,
                    QtdeNok = Product.QtdeNok,
                    QtdeOK  = Product.QtdeOk
                }).First();
            }
        }

        public List<Product> findProductByUser(Product Filter)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                 return mdeEmarket.ProductEntities.Where(product => product.idProduct == Filter.idProduct &&
                                                                    product.Name.Contains(Filter.Name)).Select(product => new Product
                {
                    idProduct = product.idProduct,
                    idCategory = product.idCategory,
                    idStore = product.idStore,
                    ProductImportName = product.ProductImportName,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    LastUpdDt = product.LastUpdtDt,
                    LastUpdHr = product.LastUpdtHr,
                    AllBranch = product.AllBranch,
                    QtdeNok = product.QtdeNok,
                    QtdeOK = product.QtdeOk
                }).ToList();
            }
        }

        public bool createProduct(Product Product)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    ProductEntity EntProduct = new ProductEntity();
                    EntProduct.idProduct = Product.idProduct;
                    EntProduct.idCategory = Product.idCategory;
                    EntProduct.idStore = Product.idStore;
                    EntProduct.ProductImportName = Product.ProductImportName;
                    EntProduct.Name = Product.Name;
                    EntProduct.Price = Product.Price;
                    EntProduct.Image = Product.Image;
                    EntProduct.LastUpdtDt = Product.LastUpdDt;
                    EntProduct.LastUpdtHr = Product.LastUpdHr;
                    EntProduct.AllBranch = Product.AllBranch;
                    EntProduct.QtdeNok = Product.QtdeNok;
                    EntProduct.QtdeOk = Product.QtdeOK;
                    mdeEmarket.ProductEntities.Add(EntProduct);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editProduct(Product Product)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    ProductEntity EntProduct = mdeEmarket.ProductEntities.Single(p =>  p.idStore == Product.idStore &&
                                                                                p.idProduct == Product.idProduct);

                    EntProduct.idProduct = Product.idProduct;
                    EntProduct.idCategory = Product.idCategory;
                    EntProduct.idStore = Product.idStore;
                    EntProduct.ProductImportName = Product.ProductImportName;
                    EntProduct.Name = Product.Name;
                    EntProduct.Price = Product.Price;
                    EntProduct.Image = Product.Image;
                    EntProduct.LastUpdtDt = Product.LastUpdDt;
                    EntProduct.LastUpdtHr = Product.LastUpdHr;
                    EntProduct.AllBranch = Product.AllBranch;
                    EntProduct.QtdeNok = Product.QtdeNok;
                    EntProduct.QtdeOk = Product.QtdeOK;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteProduct(Product Product)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    ProductEntity EntProduct = mdeEmarket.ProductEntities.Single(p => p.idStore   == Product.idStore &&
                                                                                      p.idProduct == Product.idProduct);

                    mdeEmarket.ProductEntities.Remove(EntProduct);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        /***********************************************************************************************/

        /**************************************** STORES ***********************************************/
        public Store findStore(string id)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {

                int idStore = Convert.ToInt32(id);
                return mdeEmarket.StoreEntities.Where(store => store.idStore == idStore).Select(store => new Store
                {
                    idStore = store.idStore,
                    idBranch = store.idBranch,
                    CompanyName = store.CompanyName,
                    CNPJ = store.CNPJ,
                    Name = store.Name,
                    GPS = store.GPS
                }).First();
            }
        }

        public bool createStore(Store objStore)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    StoreEntity store = new StoreEntity();
                    store.idStore = objStore.idStore;
                    store.idBranch = objStore.idBranch;
                    store.Name = objStore.Name;
                    store.CompanyName = objStore.CompanyName;
                    store.CNPJ = objStore.CNPJ;
                    store.GPS = objStore.GPS;
                    mdeEmarket.StoreEntities.Add(store);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editStore(Store objStore)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    StoreEntity store = mdeEmarket.StoreEntities.Single(p => p.idStore == objStore.idStore &&
                                                                             p.idBranch == objStore.idBranch);                    
                    store.idStore = objStore.idStore;
                    store.idBranch = objStore.idBranch;
                    store.Name = objStore.Name;
                    store.CompanyName = objStore.CompanyName;
                    store.CNPJ = objStore.CNPJ;
                    store.GPS = objStore.GPS;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteStore(Store objStore)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    StoreEntity store = mdeEmarket.StoreEntities.Single(p => p.idStore == objStore.idStore &&
                                                                             p.idBranch == objStore.idBranch);
                    mdeEmarket.StoreEntities.Remove(store);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        /***********************************************************************************************/
        
        /**************************************** USER *************************************************/
        public User findUser(string id)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {

                int idUser = Convert.ToInt32(id);
                return mdeEmarket.UserEntities.Where(user => user.idUser == idUser).Select(user => new User
                {
                    iduser = user.idUser,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    CNPJ    = user.CNPJ,
                    CPF     = user.CPF,
                    Email   = user.Email,
                    Hash    = user.Hash,
                    Picture = user.Picture
                }).First();
            }
        }

        public bool createUser(User objUser)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserEntity user = new UserEntity();
                    user.idUser     = objUser.iduser;
                    user.FirstName  = objUser.FirstName;
                    user.MiddleName = objUser.MiddleName;
                    user.LastName   = objUser.LastName;
                    user.CNPJ       = objUser.CNPJ;
                    user.CPF        = objUser.CPF;
                    user.Email      = objUser.Email;
                    user.Hash       = objUser.Hash;
                    user.Picture    = objUser.Picture;
                    mdeEmarket.UserEntities.Add(user);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editUser(User objUser)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserEntity user = mdeEmarket.UserEntities.Single(p => p.idUser == objUser.iduser);
                    user.idUser = objUser.iduser;
                    user.FirstName = objUser.FirstName;
                    user.MiddleName = objUser.MiddleName;
                    user.LastName = objUser.LastName;
                    user.CNPJ = objUser.CNPJ;
                    user.CPF = objUser.CPF;
                    user.Email = objUser.Email;
                    user.Hash = objUser.Hash;
                    user.Picture = objUser.Picture;
                    mdeEmarket.UserEntities.Add(user);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteUser(User objUser)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserEntity user = mdeEmarket.UserEntities.Single(p => p.idUser == objUser.iduser);
                    mdeEmarket.UserEntities.Remove(user);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        /***********************************************************************************************/

        /*********************************** USER_SCAN *************************************************/
        public UserScan findUserScan(string id)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {

                int idScan = Convert.ToInt32(id);
                return mdeEmarket.UserScanEntities.Where(userscan => userscan.idScan == idScan).Select(userscan => new UserScan
                {
                    idScan = userscan.idScan,
                    idUser = userscan.idUser,
                    idNF = userscan.idNF,
                    idProduct = userscan.idProduct,
                    idStore = userscan.idStore,
                    Status = userscan.Status,
                    Type   = userscan.Type
                }).First();
            }
        }

        public bool createUserScan(UserScan objUserScan)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserScanEntity userscan = new UserScanEntity();
                    userscan.idScan = objUserScan.idScan;
                    userscan.idUser = objUserScan.idUser;
                    userscan.idNF = objUserScan.idNF;
                    userscan.idProduct = objUserScan.idProduct;
                    userscan.idStore = objUserScan.idStore;
                    userscan.Status = objUserScan.Status;
                    userscan.Type = objUserScan.Type;
                    mdeEmarket.UserScanEntities.Add(userscan);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool editUserScan(UserScan objUserScan)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserScanEntity userscan = mdeEmarket.UserScanEntities.Single(p => p.idScan == objUserScan.idScan &&
                                                                                      p.idProduct == objUserScan.idProduct &&
                                                                                      p.idUser == objUserScan.idUser);
                    userscan.idScan = objUserScan.idScan;
                    userscan.idUser = objUserScan.idUser;
                    userscan.idNF = objUserScan.idNF;
                    userscan.idProduct = objUserScan.idProduct;
                    userscan.idStore = objUserScan.idStore;
                    userscan.Status = objUserScan.Status;
                    userscan.Type = objUserScan.Type;
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteUserScan(UserScan objUserScan)
        {
            using (EmarketEntities mdeEmarket = new EmarketEntities())
            {
                try
                {
                    UserScanEntity userscan = mdeEmarket.UserScanEntities.Single(p => p.idScan == objUserScan.idScan &&
                                                                                      p.idProduct == objUserScan.idProduct &&
                                                                                      p.idUser == objUserScan.idUser);
                    mdeEmarket.UserScanEntities.Remove(userscan);
                    mdeEmarket.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        /***********************************************************************************************/
    }


}
