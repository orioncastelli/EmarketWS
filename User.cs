using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmarketWS
{
    public class User
    {
        public int iduser
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }

        public string MiddleName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Picture
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public int CPF
        {
            get;
            set;
        }

        public int CNPJ
        {
            get;
            set;
        }

        public string Hash
        {
            get;
            set;
        }
    }
}