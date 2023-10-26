using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.Entities
{
    public class Prodotto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? IdProdotto { get; set; }
        public string? Nome { get; set; }
        public double? Prezzo { get; set; }
        public int? Quantita { get; set; }
    }
}
