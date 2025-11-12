using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using RpgBlazor.Models;

namespace RpgBlazor.Services
{
    public class UsuarioService
    {
        private readonly HttpClient _http;

        public UsuarioService(HttpClient http)
        {
            _http = http;
        }

        // Método chamado pelo Login.razor
        public async Task<UsuarioViewModel> AutenticarUsuario(UsuarioViewModel usuario)
        {
            var resposta = await _http.PostAsJsonAsync("api/Usuarios/login", usuario);

            if (!resposta.IsSuccessStatusCode)
                throw new Exception("Falha ao autenticar usuário.");

            var usuarioRetorno = await resposta.Content.ReadFromJsonAsync<UsuarioViewModel>();

            if (usuarioRetorno == null)
                throw new Exception("Erro ao processar retorno da API.");

            return usuarioRetorno;
        }
        public async Task<UsuarioViewModel> RegistrarAsync(UsuarioViewModel usuario)
        {
            var content = new StringContent(JsonSerializer.Serialize(usuario));
            content.Headers.ContentType = new MediaTypeHeaderValue("aplicaton/json");

            var response = await _http.PostAsync("usuario/registrar", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                usuario.Id = Convert.ToInt32(responseContent);
                return usuario;
            }
            else
            {
                throw new Exception(responseContent);
            }
        }
    }
}
