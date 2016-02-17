﻿using System.Collections.Generic;
using System.Web.Mvc;
using EmpleoDotNet.Core.Domain;
using EmpleoDotNet.Core.Dto;
using PagedList;

namespace EmpleoDotNet.ViewModel
{
    public class JobOpportunitySearchViewModel
    {
        public int SelectedLocation { get; set; }
        public SelectList Locations { get; set; }
        public IPagedList<Core.Domain.JobOpportunity> Result { get; set; }
        public string Keyword { get; set; }
        public JobCategory JobCategory { get; set; }
        public bool IsRemote { get; set; }
        public List<JobCategoryCountDto> CategoriesCount { get; set; }
    }
}