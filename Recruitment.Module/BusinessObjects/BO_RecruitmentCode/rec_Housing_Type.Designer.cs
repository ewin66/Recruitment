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
namespace Recruitment.Module.BusinessObjects.Recruitment
{

    public partial class rec_Housing_Type : XPLiteObject
    {
        int frec_housing_type_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"Id")]
        public int rec_housing_type_id
        {
            get { return frec_housing_type_id; }
            set { SetPropertyValue<int>("rec_housing_type_id", ref frec_housing_type_id, value); }
        }
        string frec_housing_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Housing")]
        public string rec_housing_name
        {
            get { return frec_housing_name; }
            set { SetPropertyValue<string>("rec_housing_name", ref frec_housing_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Order Details")]
        [Association(@"rec_Employer_Order_DetailReferencesrec_Housing_Type")]
        public XPCollection<rec_Employer_Order_Detail> rec_Employer_Order_Details { get { return GetCollection<rec_Employer_Order_Detail>("rec_Employer_Order_Details"); } }
    }

}
