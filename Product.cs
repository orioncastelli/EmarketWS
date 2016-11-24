using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmarketWS
{
    public class Product
    {
        public int idStore
        {
            get;
            set;
        }

        public int idProduct
        {
            get;
            set;
        }

        public int idCategory
        {
            get;
            set;
        }

        public String ProductNameImport
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }

        public DateTime LastUpdDt
        {
            get;
            set;
        }

        public String LastUpdHr
        {
            get;
            set;
        }

        public bool AllBranch
        {
            get;
            set;
        }

        public int QtdeOK
        {
            get;
            set;
        }

        public int QtdeNok
        {
            get;
            set;
        }
    }
}