﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Recruitment.Web.BO.Recruitment
{

    public partial class rec_Applicant
    {
        public rec_Applicant(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
