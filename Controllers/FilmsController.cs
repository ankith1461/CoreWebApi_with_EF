using Microsoft.AspNetCore.Mvc;
using WebApiCoreEdx.Models;
using System.Linq;

namespace WebApiCoreEdx.Controllers
{
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        private WebApiCoreEdxDbContext dbContext;

        public FilmsController()
        {
            string connectionString ="server=localhost;port=3306;database=sakila;userid=root;pwd=admin;sslmode=none";
            dbContext = WebApiCoreEdxDbContextFactory.Create(connectionString);
        }
        
        [HttpGet]
        public Film[] GetFilm()
        {
            return dbContext.Film.ToArray();
        }

        [HttpGet("{id}")]
        public Film GetFilm(int id)
        {
            var film = dbContext.Film.SingleOrDefault(f=>f.Film_ID==id);
            return film;
        }

    }
}