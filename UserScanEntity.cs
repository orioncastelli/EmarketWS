//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmarketWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserScanEntity
    {
        public int idScan { get; set; }
        public int idProduct { get; set; }
        public int idUser { get; set; }
        public string idNF { get; set; }
        public int idStore { get; set; }
        public int Status { get; set; }
        public string Type { get; set; }
    
        public virtual NFCeEntity TB_NFCE { get; set; }
    }
}
