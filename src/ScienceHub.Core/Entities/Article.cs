using ScienceHub.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceHub.Core.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int ViewCount { get; set; }
    }
}
