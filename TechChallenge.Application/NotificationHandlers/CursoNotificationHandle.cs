using AutoMapper;
using MediatR;
using TechChallenge.Application.Notifications;
using TechChallenge.Infra.Cache.MongoDb.Interfaces;
using TechChallenge.Infra.Cache.MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.NotificationHandlers
{/// <summary>
/// classe para capturar notificações da entidade contato(CREATED, UPDETED e DELETED)
/// </summary>
    public class CursoNotificationHandle : INotificationHandler<CursoNotification>
    {
        private readonly ICursoPersistence _cursoPersistence;
        private readonly IMapper _mapper;

        public CursoNotificationHandle(ICursoPersistence cursoPersistence, IMapper mapper)
        {
            _cursoPersistence = cursoPersistence;
            _mapper = mapper;
        }

        public Task Handle(CursoNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var model = _mapper.Map<CursoModel>(notification.Contato);
                switch (notification.Action)
                {
                    case ActionNotification.Created:
                        _cursoPersistence.Create(model);
                        break;
                    case ActionNotification.Updated:
                        _cursoPersistence.Update(model);
                        break;
                    case ActionNotification.Deleted:
                        _cursoPersistence.Delete(model);
                        break;
                }
            });
        }
    }
}
