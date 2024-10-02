using ScienceHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceHub.Core.Abstarctions
{
    public interface IArticleService
    {
        List<Article> GetAll();
    }
}
