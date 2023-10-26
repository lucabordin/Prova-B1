using WebAPIMongoDB.Entities;

namespace WebAPIMongoDB.Repository
{
    public interface IMongoRepository
    {
        Task AggiungiCarrello(Carrello carrello);
        Task<List<Carrello>> RestituisciCarrello(int id);
    }
}
