using System;
using System.Collections.Generic;

#nullable disable

namespace AdventureWorksLT_Sample_CsApp.Models
{
    public partial class VGetAllCategory
    {
        public string ParentProductCategoryName { get; set; }
        public string ProductCategoryName { get; set; }
        public int? ProductCategoryId { get; set; }
    }
}
