using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using WebAPIFaseA.Entities;

namespace WebAPIMongoDB.Entities
{
    public class Carrello
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? IdCarrello { get; set; }
        public int? IdCliente { get; set; }
        public List<Prodotto> Prodotti { get; set; }
    }
}
