using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Case.Controllers;

using Xunit;

namespace TestWebAPI_Case
{
    public class UnitTest1
    {
        //TODO PLUS - Adicionar validação para testar a consulta de todos usuarios cadastrados

        [Trait("Controller", "Usuario")]
        [Fact]
        public void Get_UsuariosOk_ConsultarTodos()
        {
            // Arrange
            var controller = new UsuarioController();

            // Act
            var response = controller.ConsultarTodos();

            // Assert
            response.Should().BeOfType<OkResult>();
        }
    }
}