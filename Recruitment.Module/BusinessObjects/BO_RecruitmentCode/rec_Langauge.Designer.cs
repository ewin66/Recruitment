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

    public partial class rec_Langauge : XPLiteObject
    {
        int flangauge_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"Id")]
        public int langauge_id
        {
            get { return flangauge_id; }
            set { SetPropertyValue<int>("langauge_id", ref flangauge_id, value); }
        }
        string flangauge_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Langauge name")]
        public string langauge_name
        {
            get { return flangauge_name; }
            set { SetPropertyValue<string>("langauge_name", ref flangauge_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Applicant Langauges")]
        [Association(@"rec_Applicant_LangaugeReferencesrec_Langauge")]
        public XPCollection<rec_Applicant_Langauge> rec_Applicant_Langauges { get { return GetCollection<rec_Applicant_Langauge>("rec_Applicant_Langauges"); } }
    }

}
