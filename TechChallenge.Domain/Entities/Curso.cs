using FluentValidation.Results;
using TechChallenge.Domain.Core.Interfaces;
using TechChallenge.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Entities
{
    public class Curso : IEntity
    {
        /// <summary>
        /// Entidade de domínio
        /// </summary>
        public Guid Id { get ; set; }
        public DateTime? CreateAt { get ; set ; }
        public DateTime? UpdateAt { get ; set ; }

        #region Atributos
        private string? _nome;
        private string? _descricao;
        private double? _media;
        private DateTime? _dataCurso;
        #endregion

        #region Propriedades
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Descricao { get => _descricao; set => _descricao = value; }
        public double? Media { get => _media; set => _media = value; }
        public DateTime? DataCurso { get => _dataCurso; set => _dataCurso = value; }

        public ValidationResult Validate => new CursoValidator().Validate(this);
        #endregion
    }
}
