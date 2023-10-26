using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebAPIFaseA.Entities;
using WebAPIMongoDB.Entities;
using WebAPIMongoDB.Model;

namespace WebAPIMongoDB.DataAccess
{
    public class Context: IContext
    {
        DatabaseSettings _settings;
        public Context(IOptions<DatabaseSettings> DatabaseSettings)
        {
            var client = new MongoClient(DatabaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(DatabaseSettings.Value.DatabaseName);
            OrdiniClienti = database.GetCollection<Carrello>(DatabaseSettings.Value.CollectionName);
        }
        public IMongoCollection<Carrello> OrdiniClienti { get; }
    }
}
