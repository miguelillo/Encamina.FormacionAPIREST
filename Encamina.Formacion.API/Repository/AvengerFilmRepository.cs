

namespace Encamina.Formacion.API.Repository
{
    using Encamina.Formacion.API.Data;
    using Encamina.Formacion.API.Model;
    using Microsoft.Extensions.Logging;
    public class AvengerFilmRepository : RepositoryBase<AvengerFilm>, IAvengerFilmRepository
    {
        public AvengerFilmRepository(ILogger logger, AvengerDbContext dataContext) : base(logger, dataContext)
        {
        }
    }
}
