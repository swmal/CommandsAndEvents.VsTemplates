using CommandsAndEvents.MongoDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.MongoDb.Repository
{
    public class MyAggregateRootRepository
    {
        public MyAggregateRootRepository(string mongoUrl, string databaseName)
        {
            _mongoRepository = new MongoDbRepository<MyAggregateRoot>(mongoUrl, databaseName);
        }

        private readonly MongoDbRepository<MyAggregateRoot> _mongoRepository;
        public void Save(MyAggregateRoot item)
        {
            _mongoRepository.Save(item);
        }

        public MyAggregateRoot Get(Guid id)
        {
            return _mongoRepository.Get(id);
        }
    }
}
