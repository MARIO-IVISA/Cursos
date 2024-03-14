using AutoMapper;
using FluentValidation;
using MediatR;
using TechChallenge.Application.Commands;
using TechChallenge.Application.Models;
using TechChallenge.Application.Notifications;
using TechChallenge.Domain.Entities;
using TechChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.RequestHandlers
{
    public class CursoRequestHandler : IDisposable,
        IRequestHandler<CursoCreateCommand, CursoDto>,
        IRequestHandler<CursoUpdateCommand, CursoDto>,
        IRequestHandler<CursoDeleteCommand, CursoDto>
    {
        #region Injeção de dependência

        private readonly ICursoDomainService _cursoDomainService;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CursoRequestHandler(ICursoDomainService cursoDomainService, IMediator mediator, IMapper mapper)
        {
            _cursoDomainService = cursoDomainService;
            _mediator = mediator;
            _mapper = mapper;
        }

        #endregion
        public async Task<CursoDto> Handle(CursoCreateCommand request, CancellationToken cancellationToken)
        {
            // Capturar os dados do contato
            var contato = _mapper.Map<Curso>(request);

            // Executando a validação da entidade
            if (!contato.Validate.IsValid)
                throw new ValidationException(contato.Validate.Errors);

            await _cursoDomainService.CreateAsync(contato);

            //Gerando uma notificação (NOTIFICATION HANDLER)
            var notification = new CursoNotification
            {
                Action = ActionNotification.Created,
                Contato = contato
            };

            await _mediator.Publish(notification);

            return _mapper.Map<CursoDto>(contato);
        }

        public async Task<CursoDto> Handle(CursoUpdateCommand request, CancellationToken cancellationToken)
        {
            // Capturar os dados do contato
            var contato = _mapper.Map<Curso>(request);

            // Executando a validação da entidade
            if (!contato.Validate.IsValid)
                throw new ValidationException(contato.Validate.Errors);

            await _cursoDomainService.UpdateAsync(contato);

            var notification = new CursoNotification
            {
                Action = ActionNotification.Updated,
                Contato = contato
            };

            await _mediator.Publish(notification);

            return _mapper.Map<CursoDto>(contato);
        }

        public async Task<CursoDto> Handle(CursoDeleteCommand request, CancellationToken cancellationToken)
        {
            // Capturar os dados do contato
            var contato = await _cursoDomainService.GetByIdAsync(request.Id);
            await _cursoDomainService.DeleteAsync(contato);

            var notification = new CursoNotification
            {
                Action = ActionNotification.Deleted,
                Contato = contato
            };

            await _mediator.Publish(notification);

            return _mapper.Map<CursoDto>(contato);
        }
        public void Dispose()
        {
            _cursoDomainService.Dispose();
        }
    }
}
