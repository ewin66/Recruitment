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

    public partial class rec_Employer_Person : XPLiteObject
    {
        int femployer_person_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"Id")]
        public int employer_person_id
        {
            get { return femployer_person_id; }
            set { SetPropertyValue<int>("employer_person_id", ref femployer_person_id, value); }
        }
        rec_Employer femployer_id;
        [Association(@"rec_Employer_PersonReferencesrec_Employer")]
        [DevExpress.Xpo.DisplayName(@"Employer")]
        public rec_Employer employer_id
        {
            get { return femployer_id; }
            set { SetPropertyValue<rec_Employer>("employer_id", ref femployer_id, value); }
        }
        string fperson_name;
        [DevExpress.Xpo.DisplayName(@"Person name")]
        public string person_name
        {
            get { return fperson_name; }
            set { SetPropertyValue<string>("person_name", ref fperson_name, value); }
        }
        string fperson_title;
        [DevExpress.Xpo.DisplayName(@"Title")]
        public string person_title
        {
            get { return fperson_title; }
            set { SetPropertyValue<string>("person_title", ref fperson_title, value); }
        }
        string fperson_mobile;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Mobile")]
        public string person_mobile
        {
            get { return fperson_mobile; }
            set { SetPropertyValue<string>("person_mobile", ref fperson_mobile, value); }
        }
        string fperson_phone;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Phone")]
        public string person_phone
        {
            get { return fperson_phone; }
            set { SetPropertyValue<string>("person_phone", ref fperson_phone, value); }
        }
        string fperson_mail;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Email")]
        public string person_mail
        {
            get { return fperson_mail; }
            set { SetPropertyValue<string>("person_mail", ref fperson_mail, value); }
        }
    }

}
