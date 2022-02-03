using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class DynamicContent
    {
        public int ContentId { get; set; }
        public string PageName { get; set; } = null!;
        public string SectionName { get; set; } = null!;
        public string SectionContent { get; set; } = null!;
        public string SiteName { get; set; } = null!;
    }
}
