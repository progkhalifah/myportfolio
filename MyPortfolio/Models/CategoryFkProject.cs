using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MyPortfolio.Models
{
    public partial class CategoryFkProject
    {
        public int Id { get; set; }
        public int? IdCategory { get; set; }
        public int? IdProject { get; set; }
    }
}
