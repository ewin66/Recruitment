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

    public partial class rec_Job : XPLiteObject
    {
        int fjob_id;
        [Key(true)]
        public int job_id
        {
            get { return fjob_id; }
            set { SetPropertyValue<int>("job_id", ref fjob_id, value); }
        }
        string fjob_name;
        [Size(50)]
        public string job_name
        {
            get { return fjob_name; }
            set { SetPropertyValue<string>("job_name", ref fjob_name, value); }
        }
    }

}
