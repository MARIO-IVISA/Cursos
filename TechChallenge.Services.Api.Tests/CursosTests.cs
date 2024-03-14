using Bogus;
using FluentAssertions;
using TechChallenge.Application.Commands;
using TechChallenge.Application.Models;
using TechChallenge.Infra.Cache.MongoDb.Models;
using TechChallenge.Services.Api.Tests.Helpers;
using System.Net;
using Xunit;

namespace TechChallenge.Services.Api.Tests
{
    public class CursosTests
    {
        private readonly string _endpoint;
        public CursosTests()
        {
            _endpoint = "/api/cursos";
        }

        //[Fact]
        //public async Task<CursoDto> Contatos_Post_Returns_Ok()
        //{
        //    var faker = new Faker("pt_BR");

        //    var command = new CursoCreateCommand
        //    {
        //        Nome = faker.Person.FullName,
        //        Email = faker.Person.Email.ToLower(),
        //        Telefone = faker.Person.Phone
        //    };
        //    var client = TestsHelper.CreateClient();
        //    var result = await client.PostAsync(_endpoint, TestsHelper.CreateContent(command));

        //    result.StatusCode.Should().Be(HttpStatusCode.Created);

        //    return TestsHelper.CreateResponse<CursoDto>(result);
        //}

        //[Fact]
        //public async Task Contatos_Put_Returns_Ok()
        //{
        //    var contato = await Contatos_Post_Returns_Ok();
        //    var faker = new Faker("pt_BR");

        //    var command = new CursoUpdateCommand
        //    {
        //        Id = contato.Id,
        //        Nome = faker.Person.FullName,
        //        Email = faker.Person.Email.ToLower(),
        //        Telefone = faker.Person.Phone
        //    };
        //    var client = TestsHelper.CreateClient();
        //    var result = await client.PutAsync(_endpoint, TestsHelper.CreateContent(command));

        //    result.StatusCode.Should().Be(HttpStatusCode.OK);
        //}

        //[Fact]
        //public async Task Contatos_Delete_Returns_Ok()
        //{
        //    var contato = await Contatos_Post_Returns_Ok();
        //    var client = TestsHelper.CreateClient();
        //    var result = await client.DeleteAsync($"{ _endpoint}/{ contato.Id}");
        //    result.StatusCode.Should().Be(HttpStatusCode.OK);
        //}

        //[Fact]
        //public async void Contatos_GetAll_Returns_Ok()
        //{
        //    var client = TestsHelper.CreateClient();
        //    var result = await client.GetAsync($"{_endpoint}/0/10");

        //    result.StatusCode.Should().Be(HttpStatusCode.OK);

        //    var contatos = TestsHelper.CreateResponse<List<CursoModel>>(result);
        //    contatos.Should().NotBeNullOrEmpty();
        //}

        //[Fact]
        //public async Task Contatos_GetById_Returns_Ok()
        //{
        //    var contato = await Contatos_Post_Returns_Ok();
        //    var client = TestsHelper.CreateClient();
        //    var result = await client.GetAsync($"{_endpoint}/{contato.Id}");

        //    result.StatusCode.Should().Be(HttpStatusCode.OK);

        //    var response = TestsHelper.CreateResponse<CursoModel>(result);
        //    response.Should().NotBeNull();
        //}
    }
}