using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Case.Controllers; //pega a namespace criado em UsuarioController

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
            // Arrange: Inicialização
            var controller = new UsuarioController();

            // Act: Ação e resultado
            var response = controller.ConsultarTodos();

            // Assert: Verificação
            response.Should().BeOfType<OkResult>();
        }
    }
}