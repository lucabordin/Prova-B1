using MongoDB.Driver;
using System.Xml.Linq;
using WebAPIFaseA.Entities;
using WebAPIMongoDB.DataAccess;
using WebAPIMongoDB.Entities;

namespace WebAPIMongoDB.Repository
{
    public class MongoRepository : IMongoRepository
    {
        private readonly IContext _context;
        public MongoRepository(IContext context)
            => _context = context;
        public async Task AggiungiCarrello(Carrello carrello)
        {
            await _context.OrdiniClienti.InsertOneAsync(carrello);
        }

        public async Task<List<Carrello>> RestituisciCarrello(int id)
        {
            FilterDefinition<Carrello> filter = Builders<Carrello>.Filter.Eq(p => p.IdCliente, id);
            return await _context.OrdiniClienti.Find(filter).ToListAsync();
        }
    }
}
