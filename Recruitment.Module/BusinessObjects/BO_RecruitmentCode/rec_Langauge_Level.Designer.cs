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

    public partial class rec_Langauge_Level : XPLiteObject
    {
        int frec_lang_level_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"Id")]
        public int rec_lang_level_id
        {
            get { return frec_lang_level_id; }
            set { SetPropertyValue<int>("rec_lang_level_id", ref frec_lang_level_id, value); }
        }
        string frec_lang_level_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Level")]
        [DevExpress.Persistent.Validation.RuleUniqueValue("", DevExpress.Persistent.Validation.DefaultContexts.Save, "Object with the same name exists")]
        public string rec_lang_level_name
        {
            get { return frec_lang_level_name; }
            set { SetPropertyValue<string>("rec_lang_level_name", ref frec_lang_level_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Applicant Langauges")]
        [Association(@"rec_Applicant_LangaugeReferencesrec_Langauge_Level")]
        public XPCollection<rec_Applicant_Langauge> rec_Applicant_Langauges { get { return GetCollection<rec_Applicant_Langauge>("rec_Applicant_Langauges"); } }
    }

}
