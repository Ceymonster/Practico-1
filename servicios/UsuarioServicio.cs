using Proyecto_1.http;
using Proyecto_1.modelos;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto_1.servicios
{
    public class UsuarioServicio : ConexionAApi
    {
        private readonly string groupKey = "/x7Y8z9W0";

        // Método para obtener la lista de usuarios
        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            RespuestaListaDeUsuarios respuestaApi;
            try
            {
                string path = $"/usuarios{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeUsuarios>(jsonRespuestaApi);

                if (respuestaApi == null || respuestaApi.Code != 200)
                {
                    MessageBox.Show("Error al obtener la lista de usuarios: " + respuestaApi?.Message);
                    return new List<Usuario>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un usuario específico
        public async Task<Usuario> ObtenerUsuario(int usuarioId)
        {
            Usuario usuario = null;
            string path = $"/usuarios/{usuarioId}{groupKey}";
            string body = "";
            try
            {
                var response = await SendTransaction(path, body, "GET");

                if (response != null && !string.IsNullOrEmpty(response.Data.ToString()))
                {
                    string jsonData = response.Data.ToString();
                    var respuestaApi = JsonSerializer.Deserialize<RespuestaUsuario>(jsonData);

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        usuario = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return usuario;
        }
    }
}
