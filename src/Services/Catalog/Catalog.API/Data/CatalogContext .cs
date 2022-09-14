using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
  public class CatalogContext : ICatalogContext
  {

    public CatalogContext(IConfiguration configuration)
    {
      var client = new MongoClient(configuration.GetValue<string>("DatabaseSetting: Connectionstring "));
      var database = client . GetDatabase(configuration.GetValue<string>("DatabaseSetting: DatabaseName"));





      Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSetting: CollctionName"));
      CatalogContextSeed.SeedData(Products);
    }

    public IMongoCollection<Product> Products { get; }
  }
}
