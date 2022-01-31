using System.Net;

namespace biblioteca_backend_api.Utils
{
    public class MensagemResposta
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Mensagem { get; set; }
        public object Valor { get; set; }
    }
}
