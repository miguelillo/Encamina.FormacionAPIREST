namespace Encamina.Formacion.API.Repository
{
    using Encamina.Formacion.API.Data;
    using Encamina.Formacion.API.Model;
    using Microsoft.Extensions.Logging;

    public class AvengerRepository : RepositoryBase<Avenger>, IAvengerRepository
    {
        public AvengerRepository(ILogger logger, AvengerDbContext dataContext) : base(logger, dataContext)
        {
        }
    }
}
