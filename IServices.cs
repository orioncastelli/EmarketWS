using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmarketWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServices" in both code and config file together.
    [ServiceContract]
    public interface IServices
    {
/**************************************** CATEGORIES *******************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Category/findAll", ResponseFormat = WebMessageFormat.Json)]
        List<Category> findAllCategory();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Category/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Category findCategory(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Category/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createCategory(Category category);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Category/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editCategory(Category category);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Category/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteCategory(Category category);

        /***********************************************************************************************/

        /**************************************** LIST *************************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "List/findAll", ResponseFormat = WebMessageFormat.Json)]
        List<List> findAllList();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "List/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        List findList(String id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "List/findByUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<List> findListByUser(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "List/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createList(List list);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "List/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editList(List list);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "List/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteList(List list);
        /***********************************************************************************************/

        /**************************************** NFC **************************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "NFC/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        NFC findNFC(String id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "NFC/findByUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<NFC> findNFCByUser(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "NFC/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createNFC(NFC objNFC);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "NFC/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editNFC(NFC objNFC);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "NFC/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteNFC(NFC objNFC);

        /***********************************************************************************************/

        /**************************************** Product **********************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Product/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Product findProduct(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Product/findByFilter", ResponseFormat = WebMessageFormat.Json)]
        List<Product> findProductByUser(Product Filter);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Product/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createProduct(Product Product);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Product/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editProduct(Product Product);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Product/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteProduct(Product Product);


        /***********************************************************************************************/


        /***************************************** STORES **********************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Store/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Store findStore(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Store/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createStore(Store objStore);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Store/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editStore(Store objStore);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Store/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteStore(Store objStore);

        /***********************************************************************************************/


        /***************************************** USER ************************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "User/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        User findUser(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "User/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createUser(User objUser);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "User/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editUser(User objUser);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "User/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteUser(User objUser);
        /***********************************************************************************************/

        /************************************ USER_SCAN ************************************************/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UserScan/find/{id}", ResponseFormat = WebMessageFormat.Json)]
        UserScan findUserScan(String id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UserScan/create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createUserScan(UserScan objUserScan);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "UserScan/edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editUserScan(UserScan objUserScan);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "UserScan/delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteUserScan(UserScan objUserScan);
        /***********************************************************************************************/
    }
}
