using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Case.Controllers; //pega a namespace criado em UsuarioController

using Xunit;

namespace TestWebAPI_Case
{
    public class UnitTest1
    {
        //TODO PLUS - Adicionar valida��o para testar a consulta de todos usuarios cadastrados

        [Trait("Controller", "Usuario")]
        [Fact]
        public void Get_UsuariosOk_ConsultarTodos()
        {
            // Arrange: Inicializa��o
            var controller = new UsuarioController();

            // Act: A��o e resultado
            var response = controller.ConsultarTodos();

            // Assert: Verifica��o
            response.Should().BeOfType<OkResult>();
        }
    }
}