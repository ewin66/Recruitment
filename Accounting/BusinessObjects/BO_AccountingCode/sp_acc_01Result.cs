﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Accounting.BusinessObjects.Recruitment
{

    [NonPersistent]
    public partial class sp_acc_01Result
    {
        public DateTime entry_date { get; set; }
        public int account_id { get; set; }
        public string account_name { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public double Total { get; set; }
        public string owner { get; set; }
    }

}
