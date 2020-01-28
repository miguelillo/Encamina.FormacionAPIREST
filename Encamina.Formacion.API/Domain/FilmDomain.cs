namespace Encamina.Formacion.API.Domain
{
    using Encamina.Formacion.API.Model;
    using Encamina.Formacion.API.Repository;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FilmDomain : IFilmDomain
    {
        private readonly IFilmRepository filmRepository;

        public FilmDomain(IFilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            return await filmRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Film>> GetAllAsync()
        {
            return await filmRepository.ListAllAsync(x => x.Include(x => x.AvengerFilm));
        }

        public async Task<Film> GetByIdAsync(int id)
        {
            return await filmRepository.GetByIdAsync(id);
        }

        public async Task<Film> InsertAsync(Film film)
        {
            return await filmRepository.AddAsync(film);
        }

        public async Task<bool> UpdateAsync(Film film)
        {
            return await filmRepository.UpdateAsync(film);
        }
    }
}
