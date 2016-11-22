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
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteList(List list);
        /***********************************************************************************************/
    }
}
