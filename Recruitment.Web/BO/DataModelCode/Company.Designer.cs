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
namespace Recruitment.Web.BO.Recruitment
{

    public partial class Company : XPLiteObject
    {
        int fAutoId;
        [Key(true)]
        public int AutoId
        {
            get { return fAutoId; }
            set { SetPropertyValue<int>("AutoId", ref fAutoId, value); }
        }
        string fCompanyCountry;
        [Size(255)]
        public string CompanyCountry
        {
            get { return fCompanyCountry; }
            set { SetPropertyValue<string>("CompanyCountry", ref fCompanyCountry, value); }
        }
        string fCompanyLogo;
        [Size(255)]
        public string CompanyLogo
        {
            get { return fCompanyLogo; }
            set { SetPropertyValue<string>("CompanyLogo", ref fCompanyLogo, value); }
        }
        string fCompanyName;
        [Size(255)]
        public string CompanyName
        {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fCompanyURL;
        [Size(255)]
        public string CompanyURL
        {
            get { return fCompanyURL; }
            set { SetPropertyValue<string>("CompanyURL", ref fCompanyURL, value); }
        }
    }

}
