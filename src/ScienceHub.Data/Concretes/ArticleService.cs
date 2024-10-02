using ScienceHub.Core.Abstarctions;
using ScienceHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceHub.Data.Concretes
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetAll() => new()
        {
            new(){ Id = 1, CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow,IsActive = true, Title ="A1",Subtitle ="a1" , Content = "nem" ,ImageUrl ="png" ,ViewCount =+ 1},
            new(){ Id = 2, CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow,IsActive = true, Title ="A2",Subtitle ="a2" , Content = "nem" ,ImageUrl ="png" ,ViewCount =+ 1},
            new(){ Id = 3, CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow,IsActive = true, Title ="A3",Subtitle ="a3" , Content = "nem" ,ImageUrl ="png" ,ViewCount =+ 1},
            new(){ Id = 4, CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow,IsActive = true, Title ="A4",Subtitle ="a4" , Content = "nem" ,ImageUrl ="png" ,ViewCount =+ 1}
        };
    }
}
