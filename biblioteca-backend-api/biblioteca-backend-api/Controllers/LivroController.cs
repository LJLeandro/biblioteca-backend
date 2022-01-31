using biblioteca_backend_api.Models;
using biblioteca_backend_api.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace biblioteca_backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        [HttpGet("obter-todos-os-livros")]
        public MensagemResposta ObterTodosOsLivros()
        {
            MensagemResposta mensagem = new MensagemResposta()
            {
                Mensagem = "Livros retornados com sucesso.",
                StatusCode = System.Net.HttpStatusCode.OK,
                Valor = new List<Livro>()
                {
                    new Livro()
                    {
                        Id = 1,
                        Nome = "Senhor dos Aneis - O Retorno do Rei",
                        Foto = "",
                        Editora = new Editora()
                        {
                            Id = 1,
                            Nome = "Editora Jambo"
                        },
                        Autor = new Autor()
                        {
                            Id = 1,
                            Nome = "J.R.R. Tolkien"
                        }
                    }
                }
            };


            return mensagem;
        }
    }
}
