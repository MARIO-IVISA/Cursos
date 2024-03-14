using MediatR;
using TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Notifications
{/// <summary>
/// Classe oara armazenar as notificações relacionadas a contato
/// </summary>
    public class CursoNotification : INotification
    {
        public ActionNotification Action { get; set; }
        public Curso? Contato { get; set; }
    }
}
