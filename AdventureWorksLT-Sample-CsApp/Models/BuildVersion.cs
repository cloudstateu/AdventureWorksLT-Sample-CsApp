﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AdventureWorksLT_Sample_CsApp.Models
{
    public partial class BuildVersion
    {
        public byte SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; }
        public DateTime VersionDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
