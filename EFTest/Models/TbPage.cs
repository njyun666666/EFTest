﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class TbPage
    {
        public TbPage()
        {
            TbPageSection = new HashSet<TbPageSection>();
        }

        public int PageId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public virtual ICollection<TbPageSection> TbPageSection { get; set; }
    }
}