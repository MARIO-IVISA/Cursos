using AutoMapper;
using TechChallenge.Application.Commands;
using TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Mappings
{
    public class CommandToEntityMap : Profile
    {
        public CommandToEntityMap()
        {
            CreateMap<CursoCreateCommand, Curso>()
            .AfterMap((command, entity) =>
            {
                entity.Id = Guid.NewGuid();
                entity.CreateAt = DateTime.Now;
                entity.UpdateAt = DateTime.Now;
            });

            CreateMap<CursoUpdateCommand, Curso>()
                .AfterMap((command, entity) =>
                {
                    entity.UpdateAt = DateTime.Now;
                });
        }
    }
}
