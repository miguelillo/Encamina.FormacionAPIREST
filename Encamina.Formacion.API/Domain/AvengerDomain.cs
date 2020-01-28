namespace Encamina.Formacion.API.Domain
{
    using Encamina.Formacion.API.Model;
    using Encamina.Formacion.API.Repository;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AvengerDomain : IAvengerDomain
    {
        private readonly IAvengerRepository avengerRepository;
        private readonly IAvengerFilmRepository avengerFilmRepository;

        public AvengerDomain(IAvengerRepository avengerRepository, IAvengerFilmRepository avengerFilmRepository)
        {
            this.avengerRepository = avengerRepository;
            this.avengerFilmRepository = avengerFilmRepository;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            return await avengerRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Avenger>> GetAllAsync()
        {
            return await avengerRepository.GetAsync();
        }

        public async Task<IEnumerable<AvengerFilm>> GetAllFilmsByIdAsync(int avengerId)
        {
            return await avengerFilmRepository.GetAsync(x => x.AvengerId.Equals(avengerId));

        }

        public async Task<Avenger> GetByIdAsync(int id)
        {
            return await avengerRepository.GetByIdAsync(id);
        }

        public async Task<Avenger> InsertAsync(Avenger people)
        {
            return await avengerRepository.AddAsync(people);
        }

        public async Task<bool> UpdateAsync(Avenger people)
        {
            return await avengerRepository.UpdateAsync(people);
        }
    }
}
