using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities
{
  public class Product
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int Id { get; set; }


    [BsonElement("Name")]
    public string Name { get; set; }

    public string Category { get; set; }
    public string Summary { get; set; }

    public string Description { get; set; }

    public string ImageFilee { get; set; }

    public decimal Price { get; set; }
    public string ImageFile { get; internal set; }
  }
}
