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

    public partial class rec_Applicant : XPLiteObject
    {
        int fapplicant_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"Id")]
        public int applicant_id
        {
            get { return fapplicant_id; }
            set { SetPropertyValue<int>("applicant_id", ref fapplicant_id, value); }
        }
        string fapplicant_name;
        [Indexed(Name = @"iapplicant_applicant_name")]
        [DevExpress.Xpo.DisplayName(@"Applicant name")]
        public string applicant_name
        {
            get { return fapplicant_name; }
            set { SetPropertyValue<string>("applicant_name", ref fapplicant_name, value); }
        }
        string fapplicant_email;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Email")]
        public string applicant_email
        {
            get { return fapplicant_email; }
            set { SetPropertyValue<string>("applicant_email", ref fapplicant_email, value); }
        }
        rec_City fapplicant_city_id;
        [Indexed(Name = @"iapplicant_city_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_City")]
        [DevExpress.Xpo.DisplayName(@"City")]
        public rec_City applicant_city_id
        {
            get { return fapplicant_city_id; }
            set { SetPropertyValue<rec_City>("applicant_city_id", ref fapplicant_city_id, value); }
        }
        string fapplicant_phone;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Phone")]
        public string applicant_phone
        {
            get { return fapplicant_phone; }
            set { SetPropertyValue<string>("applicant_phone", ref fapplicant_phone, value); }
        }
        string fapplicant_mobile;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Mobile")]
        public string applicant_mobile
        {
            get { return fapplicant_mobile; }
            set { SetPropertyValue<string>("applicant_mobile", ref fapplicant_mobile, value); }
        }
        rec_Nationality fapplicant_nationality_id;
        [Indexed(Name = @"iapplicant_nationality_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Nationality")]
        [DevExpress.Xpo.DisplayName(@"Nationality")]
        public rec_Nationality applicant_nationality_id
        {
            get { return fapplicant_nationality_id; }
            set { SetPropertyValue<rec_Nationality>("applicant_nationality_id", ref fapplicant_nationality_id, value); }
        }
        rec_Marital_Status fapplicant_marital_status_id;
        [Indexed(Name = @"iapplicant_marital_status_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Marital_Status")]
        [DevExpress.Xpo.DisplayName(@"Marital status")]
        public rec_Marital_Status applicant_marital_status_id
        {
            get { return fapplicant_marital_status_id; }
            set { SetPropertyValue<rec_Marital_Status>("applicant_marital_status_id", ref fapplicant_marital_status_id, value); }
        }
        rec_Military_Status fapplicant_military_id;
        [Indexed(Name = @"iapplicant_military_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Military_Status")]
        [DevExpress.Xpo.DisplayName(@"Military")]
        public rec_Military_Status applicant_military_id
        {
            get { return fapplicant_military_id; }
            set { SetPropertyValue<rec_Military_Status>("applicant_military_id", ref fapplicant_military_id, value); }
        }
        DateTime fapplicant_birth_date;
        [DevExpress.Xpo.DisplayName(@"Birth date")]
        public DateTime applicant_birth_date
        {
            get { return fapplicant_birth_date; }
            set { SetPropertyValue<DateTime>("applicant_birth_date", ref fapplicant_birth_date, value); }
        }
        rec_Work_Type fapplicant_work_type_id;
        [Indexed(Name = @"iapplicant_work_type_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Work_Type")]
        [DevExpress.Xpo.DisplayName(@"Work type")]
        public rec_Work_Type applicant_work_type_id
        {
            get { return fapplicant_work_type_id; }
            set { SetPropertyValue<rec_Work_Type>("applicant_work_type_id", ref fapplicant_work_type_id, value); }
        }
        double fapplicant_salary;
        [DevExpress.Xpo.DisplayName(@"Salary")]
        public double applicant_salary
        {
            get { return fapplicant_salary; }
            set { SetPropertyValue<double>("applicant_salary", ref fapplicant_salary, value); }
        }
        rec_Position fapplicant_position_id;
        [Indexed(Name = @"iapplicant_position_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Position")]
        [DevExpress.Xpo.DisplayName(@"Position")]
        public rec_Position applicant_position_id
        {
            get { return fapplicant_position_id; }
            set { SetPropertyValue<rec_Position>("applicant_position_id", ref fapplicant_position_id, value); }
        }
        bool fapplicant_driving_license;
        [DevExpress.Xpo.DisplayName(@"Driving license")]
        public bool applicant_driving_license
        {
            get { return fapplicant_driving_license; }
            set { SetPropertyValue<bool>("applicant_driving_license", ref fapplicant_driving_license, value); }
        }
        string fapplicant_skill;
        [Size(1000)]
        [DevExpress.Xpo.DisplayName(@"Skills")]
        public string applicant_skill
        {
            get { return fapplicant_skill; }
            set { SetPropertyValue<string>("applicant_skill", ref fapplicant_skill, value); }
        }
        string fapplicant_summary;
        [Size(1000)]
        [DevExpress.Xpo.DisplayName(@"Summary")]
        public string applicant_summary
        {
            get { return fapplicant_summary; }
            set { SetPropertyValue<string>("applicant_summary", ref fapplicant_summary, value); }
        }
        string fapplicant_national_id;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"National Id")]
        public string applicant_national_id
        {
            get { return fapplicant_national_id; }
            set { SetPropertyValue<string>("applicant_national_id", ref fapplicant_national_id, value); }
        }
        rec_Gender fapplicant_gender_id;
        [Indexed(Name = @"iapplicant_gender_id_rec_Applicant")]
        [Association(@"rec_ApplicantReferencesrec_Gender")]
        [DevExpress.Xpo.DisplayName(@"Gender")]
        public rec_Gender applicant_gender_id
        {
            get { return fapplicant_gender_id; }
            set { SetPropertyValue<rec_Gender>("applicant_gender_id", ref fapplicant_gender_id, value); }
        }
        string fapplicant_address;
        [Size(255)]
        [DevExpress.Xpo.DisplayName(@"Address")]
        public string applicant_address
        {
            get { return fapplicant_address; }
            set { SetPropertyValue<string>("applicant_address", ref fapplicant_address, value); }
        }
        string fapplicant_mobile2;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Mobile 2")]
        public string applicant_mobile2
        {
            get { return fapplicant_mobile2; }
            set { SetPropertyValue<string>("applicant_mobile2", ref fapplicant_mobile2, value); }
        }
        byte[] frec_Applicant_image;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Photo")]
        [DevExpress.Persistent.Base.ImageEditor(DetailViewImageEditorFixedHeight = 64, DetailViewImageEditorFixedWidth = 64, ListViewImageEditorCustomHeight = 64, ImageSizeMode = DevExpress.Persistent.Base.ImageSizeMode.Zoom)]
        public byte[] rec_Applicant_image
        {
            get { return frec_Applicant_image; }
            set { SetPropertyValue<byte[]>("rec_Applicant_image", ref frec_Applicant_image, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Applicant Courses")]
        [Association(@"rec_Applicant_CourseReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Course> rec_Applicant_Courses { get { return GetCollection<rec_Applicant_Course>("rec_Applicant_Courses"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Educations")]
        [Association(@"rec_Applicant_EducationReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Education> rec_Applicant_Educations { get { return GetCollection<rec_Applicant_Education>("rec_Applicant_Educations"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Experiences")]
        [Association(@"rec_Applicant_ExperienceReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Experience> rec_Applicant_Experiences { get { return GetCollection<rec_Applicant_Experience>("rec_Applicant_Experiences"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Projects")]
        [Association(@"rec_Applicant_ProjectReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Project> rec_Applicant_Projects { get { return GetCollection<rec_Applicant_Project>("rec_Applicant_Projects"); } }
        [DevExpress.Xpo.DisplayName(@"Order Calls")]
        [Association(@"rec_Employer_Order_Detail_CallReferencesrec_Applicant")]
        public XPCollection<rec_Employer_Order_Detail_Call> rec_Employer_Order_Detail_Calls { get { return GetCollection<rec_Employer_Order_Detail_Call>("rec_Employer_Order_Detail_Calls"); } }
        [DevExpress.Xpo.DisplayName(@"Suggest In Orders")]
        [Association(@"rec_Employer_Order_Detail_Suggest_ApplicatReferencesrec_Applicant")]
        public XPCollection<rec_Employer_Order_Detail_Suggest_Applicat> rec_Employer_Order_Detail_Suggest_Applicats { get { return GetCollection<rec_Employer_Order_Detail_Suggest_Applicat>("rec_Employer_Order_Detail_Suggest_Applicats"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Tags")]
        [Association(@"rec_Applicant_TagReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Tag> rec_Applicant_Tags { get { return GetCollection<rec_Applicant_Tag>("rec_Applicant_Tags"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant_Industries")]
        [Association(@"rec_Applicant_IndustryReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Industry> rec_Applicant_Industrys { get { return GetCollection<rec_Applicant_Industry>("rec_Applicant_Industrys"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Langauges")]
        [Association(@"rec_Applicant_LangaugeReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Langauge> rec_Applicant_Langauges { get { return GetCollection<rec_Applicant_Langauge>("rec_Applicant_Langauges"); } }
        [DevExpress.Xpo.DisplayName(@"Applicant Countries")]
        [Association(@"rec_Applicant_CountryReferencesrec_Applicant")]
        public XPCollection<rec_Applicant_Country> rec_Applicant_Countrys { get { return GetCollection<rec_Applicant_Country>("rec_Applicant_Countrys"); } }
        [DevExpress.Xpo.DisplayName(@"Order Connections")]
        [Association(@"rec_Employer_Order_Detail_Connection_DetailReferencesrec_Applicant")]
        public XPCollection<rec_Employer_Order_Detail_Connection_Detail> rec_Employer_Order_Detail_Connection_Details { get { return GetCollection<rec_Employer_Order_Detail_Connection_Detail>("rec_Employer_Order_Detail_Connection_Details"); } }
    }

}
