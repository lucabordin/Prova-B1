using MongoDB.Driver;
using WebAPIFaseA.Entities;
using WebAPIMongoDB.Entities;

namespace WebAPIMongoDB.DataAccess
{
    public interface IContext
    {
        IMongoCollection<Carrello> OrdiniClienti { get; }
    }
}
