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

    public partial class AppDependenceFile : XPLiteObject
    {
        string fFileName;
        [Key]
        [DevExpress.Xpo.DisplayName(@"File Name")]
        public string FileName
        {
            get { return fFileName; }
            set { SetPropertyValue<string>("FileName", ref fFileName, value); }
        }
        long fFileVersion;
        [DevExpress.Xpo.DisplayName(@"File Version")]
        public long FileVersion
        {
            get { return fFileVersion; }
            set { SetPropertyValue<long>("FileVersion", ref fFileVersion, value); }
        }
        byte[] fFileData;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"File Data")]
        public byte[] FileData
        {
            get { return fFileData; }
            set { SetPropertyValue<byte[]>("FileData", ref fFileData, value); }
        }
    }

}
