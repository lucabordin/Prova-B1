using WebAPIMongoDB.Entities;

namespace WebAPIMongoDB.Services
{
    public interface IMongoService
    {
        Task<List<Carrello>> GetCarrello(int id);
        Task AddCarrello(Carrello carrello);
    }
}
