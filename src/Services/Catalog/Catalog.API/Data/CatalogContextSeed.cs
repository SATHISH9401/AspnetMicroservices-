using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
  public class CatalogContextSeed
  {
    public static void SeedData(IMongoCollection<Product> productCollection)
    {
      bool existProduct = productCollection.Find(p => true).Any();
      if (!existProduct)
      {
        productCollection.InsertManyAsync(GetPreconfiguredProducts());
      }
    }

    private static IEnumerable<Product> GetPreconfiguredProducts()
    {

      return new List<Product>()
      {

        new Product()
        {
         // Id = "602d2149e773f2a3990b47f5",
          Name = "IPhone X",
          Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFile = "product-1.png",
          Price = 950.00M,
          Category = "Smart Phone"
        }
      };
    }


  }
}
