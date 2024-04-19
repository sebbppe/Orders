using Orders.Backend.Repositories.Interfaces;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.implementations
{
    public class CountriesUnitOfWork(IGenericRepository<Country> repository, ICountriesRepository countriesRepository) : GenericUnitOfWork<Country>(repository), ICountriesUnitOfWork 
    {
        private readonly ICountriesRepository _countriesRepository = countriesRepository;

        public override async Task<ActionResponse<Country>> GetAsync(int id)=> await _countriesRepository.GetAsync(id);

        public override async Task<ActionResponse<IEnumerable<Country>>> GetAsync()=> await _countriesRepository.GetAsync();
    }
}
