using MongoDB.Driver;
using TechChallenge.Infra.Cache.MongoDb.Cotexts;
using TechChallenge.Infra.Cache.MongoDb.Interfaces;
using TechChallenge.Infra.Cache.MongoDb.Models;
using Microsoft.Azure.Cosmos;
using Projeto01.Infra.Cache.MongoDb.Cotexts;
using Azure;
using System.Collections.Generic;


namespace TechChallenge.Infra.Cache.MongoDb.Persistence
{
    public class CursoPersistence : ICursoPersistence
    {

        private readonly MongoDBContext _mongoDBContext;
       
        public CursoPersistence(MongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
        }

        public async void Create(CursoModel model)
        {
            _mongoDBContext.Contatos.InsertOne(model);

        }
        public async void Delete(CursoModel model)
        {
            var filter = Builders<CursoModel>.Filter.Eq(x => x.Id, model.Id);
            _mongoDBContext.Contatos.DeleteOne(filter);
        }

        public async void Update(CursoModel model)
        {
            var filter = Builders<CursoModel>.Filter.Eq(x => x.Id, model.Id);
            _mongoDBContext.Contatos.ReplaceOne(filter, model);
        }

        public async Task<List<CursoModel>> GetAll()
        {

            var filter = Builders<CursoModel>.Filter.Where(x => true);
            return _mongoDBContext.Contatos.Find(filter).ToList();
        }

        public async Task<CursoModel> GetById(Guid idContato)
        {
            var filter = Builders<CursoModel>.Filter.Eq(x => x.Id, idContato);
            return _mongoDBContext.Contatos.Find(filter).FirstOrDefault();
        }

    }
}

