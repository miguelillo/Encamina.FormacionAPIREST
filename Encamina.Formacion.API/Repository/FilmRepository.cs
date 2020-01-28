using Encamina.Formacion.API.Model;

namespace Encamina.Formacion.API.Repository
{
    using Encamina.Formacion.API.Data;
    using Microsoft.Extensions.Logging;
    public class FilmRepository : RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(ILogger logger, AvengerDbContext dataContext) : base(logger, dataContext)
        {
        }
    }
}
