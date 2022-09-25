﻿using Investex.Domain.Entities.Interface;
using Investex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investex.Domain.Entities.Concrete
{
    public class Category : IBaseEntity
    {
        public Category()
        {
            Status = Status.Active;
        }

        public Guid ID { get; set; }
        public string CategoryName { get; set; }
        public Status Status { get; set; }

        public string CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedAdUsername { get; set; }
        public string CreatedBy { get; set; }

        public string UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedAdUsername { get; set; }
        public string UpdatedBy { get; set; }

        //Relations
        public virtual List<NewsArticle> NewsArticles { get; set; }
        public virtual List<NewsAnalysis> NewsAnalyses { get; set; }
        public virtual List<Video> Videos { get; set; }

    }
}
