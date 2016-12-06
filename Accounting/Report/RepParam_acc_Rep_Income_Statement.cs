﻿using System;
using System.ComponentModel;
using Accounting.BusinessObjects.Recruitment;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.Validation;

namespace Accounting.Report
{
    [DomainComponent]
    [DevExpress.ExpressApp.DC.XafDisplayName("Income Statement Parameters")]
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113594.aspx.
    // ReSharper disable once InconsistentNaming
    public class RepParam_acc_Rep_Income_Statement : ReportParametersObjectBase
    {
        public RepParam_acc_Rep_Income_Statement(IObjectSpaceCreator provider) : base(provider)
        {
        }
        protected override IObjectSpace CreateObjectSpace()
        {return objectSpaceCreator.CreateObjectSpace(null);
        }

        public override CriteriaOperator GetCriteria()
        {
            return CriteriaEditorHelper.GetCriteriaOperator("1=1", typeof(sp_Trial_BalanceResult), ObjectSpace);
        }

        public override SortProperty[] GetSorting()
        {
            //SortProperty[] sorting = {new SortProperty("applicant_name", SortingDirection.Ascending)};
            SortProperty[] sorting = new SortProperty[0];
            return sorting;
        }

        private acc_Year _fiscalyear;
        [RuleRequiredField("RepParam_acc_Rep_Income_Statement_FiscalYear_vld_req", DefaultContexts.Save, "Fiscal Year should not be empty!")]
        [System.ComponentModel.DisplayName("Fiscal Year")]
        public acc_Year FiscalYear
        {
            get { return _fiscalyear; }
            set { _fiscalyear = value; }
        }

        private DateTime _startdate;
        [RuleRequiredField("RepParam_acc_Rep_Income_Statement_Startdate_vld_req", DefaultContexts.Save, "From Date should not be empty!")]
        [System.ComponentModel.DisplayName("From Date")]
        public DateTime Startdate
        {
            get { return _startdate; }
            set { _startdate = value; }
        }

        private DateTime _enddate;
        [RuleRequiredField("RepParam_acc_Rep_Income_Statement_Enddate_vld_req", DefaultContexts.Save, "To Date should not be empty!")]
        [System.ComponentModel.DisplayName("To Date")]
        public DateTime Enddate
        {
            get { return _enddate; }
            set { _enddate = value; }
        }

        private acc_Account_Category _cateogry;
        [RuleRequiredField("RepParam_acc_Rep_Income_Statement_Cateogry_vld_req", DefaultContexts.Save, "Cateogry should not be empty!")]
        [System.ComponentModel.DisplayName("Cateogry")]
        public acc_Account_Category Cateogry
        {
            get { return _cateogry; }
            set { _cateogry = value; }
        }

    }

}
