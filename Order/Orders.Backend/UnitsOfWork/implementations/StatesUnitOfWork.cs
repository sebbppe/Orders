using Orders.Backend.Repositories.Interfaces;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.implementations
{
    public class StatesUnitOfWork(IGenericRepository<State> repository, IStatesRepository statesRepository) : GenericUnitOfWork<State>(repository), IStatesUnitOfWork 
    {
        private readonly IStatesRepository _statesRepository = statesRepository;

        public override async Task<ActionResponse<State>> GetAsync(int id)=> await _statesRepository.GetAsync(id);

        public override async Task<ActionResponse<IEnumerable<State>>> GetAsync()=> await _statesRepository.GetAsync();
    }
}
