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

    public partial class rec_Gender : XPLiteObject
    {
        int frec_gender_id;
        [Key(true)]
        public int rec_gender_id
        {
            get { return frec_gender_id; }
            set { SetPropertyValue<int>("rec_gender_id", ref frec_gender_id, value); }
        }
        string frec_gender_name;
        public string rec_gender_name
        {
            get { return frec_gender_name; }
            set { SetPropertyValue<string>("rec_gender_name", ref frec_gender_name, value); }
        }
        [Association(@"rec_ApplicantReferencesrec_Gender")]
        public XPCollection<rec_Applicant> rec_Applicants { get { return GetCollection<rec_Applicant>("rec_Applicants"); } }
        [Association(@"rec_EmployerReferencesrec_Gender")]
        public XPCollection<rec_Employer> rec_Employers { get { return GetCollection<rec_Employer>("rec_Employers"); } }
    }

}
