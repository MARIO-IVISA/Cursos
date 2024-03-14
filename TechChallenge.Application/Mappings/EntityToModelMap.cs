using AutoMapper;
using TechChallenge.Application.Models;
using TechChallenge.Domain.Entities;
using TechChallenge.Infra.Cache.MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Curso, CursoDto>();
            CreateMap<Curso, CursoModel>();
        }
    }
}
