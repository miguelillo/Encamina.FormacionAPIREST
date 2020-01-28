

namespace Encamina.Formacion.API.Domain
{
    using Encamina.Formacion.API.Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IFilmDomain
    {
        Task<IEnumerable<Film>> GetAllAsync();
        Task<Film> GetByIdAsync(int id);

        Task<Film> InsertAsync(Film people);
        Task<bool> UpdateAsync(Film people);
        Task<bool> DeleteAsync(int id);
    }
}
