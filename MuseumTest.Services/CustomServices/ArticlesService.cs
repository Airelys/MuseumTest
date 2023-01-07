using MuseumTest.Domain.Entities;
using MuseumTest.Repository;
using MuseumTest.Services.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTest.Services.CustomServices
{
    public class ArticlesService: CrudService<Article>, IArticleService 
    {
        private readonly IRepository<Article> _articleRepository;

        public ArticlesService(IRepository<Article> articleRepository) : base(articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public CrudService<Article> GetCrud()
        {
            return this;
        }

        public IEnumerable<Article> GetArticles(Museum museum)
        {
            var museums = _articleRepository.GetAll().Where(m => m.MuseumId == museum.Id);
            return museums;
        }
    }
}
