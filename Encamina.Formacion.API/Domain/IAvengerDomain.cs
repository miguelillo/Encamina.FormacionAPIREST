using Encamina.Formacion.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Encamina.Formacion.API.Domain
{
    public interface IAvengerDomain
    {
        Task<IEnumerable<Avenger>> GetAllAsync();
        Task<IEnumerable<AvengerFilm>> GetAllFilmsByIdAsync(int avengerId);
        Task<Avenger> GetByIdAsync(int id);

        Task<Avenger> InsertAsync(Avenger people);
        Task<bool> UpdateAsync(Avenger people);
        Task<bool> DeleteAsync(int id);
    }
}
