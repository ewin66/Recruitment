﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Xpo;
using Recruitment.Module.BusinessObjects.Recruitment;
using DevExpress.Web;


namespace Recruitment.Web
{
    public partial class Apply : System.Web.UI.Page
    {
        private string _dataFolder = "~/App_Data/tempfiles/";
        
        public rec_job_post Job = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.QueryString["id"] == null)
                Response.Redirect("Jobs.aspx");

            XpoDSGender.Session = ((XPObjectSpace)WebApplication.Instance.CreateObjectSpace()).Session;
            XpoDSNationality.Session = ((XPObjectSpace)WebApplication.Instance.CreateObjectSpace()).Session;
            GetJobInfo(Convert.ToInt32(Request.QueryString["id"]));
            if (!IsPostBack)
            {
                Session["filename"] = null;
                UpdateCounting(Convert.ToInt32(Request.QueryString["id"]));
            }
        }
        private void UpdateCounting(int id)
        {
            IObjectSpace objectspace = WebApplication.Instance.CreateObjectSpace();
            Job = objectspace.FindObject<rec_job_post>(CriteriaOperator.Parse($"job_post_id = {id} And jp_date_start <= #{DateTime.Now.ToShortDateString()}# And jp_date_end >= #{DateTime.Now.ToShortDateString()}# And jp_visible = True"));
            if (Job == null)
                Response.Redirect("Jobs.aspx");
            Job.jp_view_count += 1;
            Job.Save();
            objectspace.CommitChanges();
        }
        private void GetJobInfo(int id)
        {
            IObjectSpace objectspace = WebApplication.Instance.CreateObjectSpace();
            Job = objectspace.FindObject<rec_job_post>(CriteriaOperator.Parse($"job_post_id = {id} And jp_date_start <= #{DateTime.Now.ToShortDateString()}# And jp_date_end >= #{DateTime.Now.ToShortDateString()}# And jp_visible = True"));
            if (Job == null)
                Response.Redirect("Jobs.aspx");

            jp_image.ContentBytes = ConvertToByte((System.Drawing.Bitmap) Job.jp_image);
            jp_date_start.InnerText = Job.jp_date_start.ToShortDateString();
            industry_name.InnerText = Job.jp_industry_id.industry_name;
            jp_view_count.InnerText = Job.jp_view_count.ToString() + " Views";
            jp_content.InnerText = Job.jp_content;

        }
        public byte[] ConvertToByte(Bitmap bmp)
        {
            using (var stream = new MemoryStream())
            {
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        protected void DocumentsUploadControl_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
        {
            string filename = _dataFolder + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day +
                              DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
            e.UploadedFile.SaveAs(MapPath(filename));
            if (e.IsValid)
            {
                e.CallbackData = filename;
                Session["filename"] = filename;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            bool allFilesExist = true;
            if (Session["filename"] == null || !File.Exists(Session["filename"].ToString()))
                allFilesExist = false;
        }
    }
}