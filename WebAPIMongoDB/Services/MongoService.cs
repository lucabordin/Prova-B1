using WebAPIMongoDB.Entities;
using WebAPIMongoDB.Repository;

namespace WebAPIMongoDB.Services
{
    public class MongoService : IMongoService
    {
        IMongoRepository _repository;
        public MongoService(IMongoRepository repository)
        => _repository = repository;
        public async Task AddCarrello(Carrello carrello)
        {
            await _repository.AggiungiCarrello(carrello);
        }

        public async Task<List<Carrello>> GetCarrello(int id)
        {
            return await _repository.RestituisciCarrello(id);
        }
    }
}
