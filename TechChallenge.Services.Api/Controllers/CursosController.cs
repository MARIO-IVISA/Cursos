using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechChallenge.Application.Commands;
using TechChallenge.Application.Interfaces;
using TechChallenge.Domain.Entities;
using Container = Microsoft.Azure.Cosmos.Container;

namespace TechChallenge.Services.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(AuthenticationSchemes = "Bearer")]
    public class CursosController : ControllerBase
    {
        private readonly ICursoAppService _cursosAppService;
        public CursosController(ICursoAppService cursoAppService)
        {
            _cursosAppService = cursoAppService;

        }

        [HttpPost]
        public async Task<IActionResult> Post(CursoCreateCommand command)
        {
            try
            {
                var curso = await _cursosAppService.Create(command);
                return StatusCode(201, curso);
            }
            catch (ValidationException ex)
            {
                return StatusCode(400, ex.Errors);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _cursosAppService.GetAll();

                return StatusCode(200, result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var curso = await _cursosAppService.GetById(id);
                if (curso == null)
                    return NoContent();

                return StatusCode(200, curso);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("Professor/{id}")]
        public async Task<IActionResult> GetByIdProfessor(Guid id)
        {
            try
            {
                var curso = await _cursosAppService.GetByIdProdessor(id);
                if (curso == null)
                    return NoContent();

                return StatusCode(200, curso);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }
    }
}