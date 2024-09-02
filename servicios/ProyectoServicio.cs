using Proyecto_1.http;
using Proyecto_1.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto_1.services
{
    public class ProyectoServicio : ConexionAApi
    {
        private readonly string groupKey = "/x7Y8z9W0";

        // Método para obtener la lista de proyectos 
        public async Task<List<Proyecto>> Index()
        {
            //declarar una variable para almacenar la respuesta de la API
            //la variable debe ser del tipo de la respuesta esperada
            //en este caso, la respuesta es una lista de proyectos
            RespuestaListaDeProyectos respuestaApi;
            try
            {
                string path = $"/projects{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeProyectos          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

                /* Aquí podrías validar si hay algun error con la respuesta según su código*/
                if (respuestaApi.Code != 200)
                {
                    MessageBox.Show(respuestaApi.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un proyecto específico por ID (Read)
        public async Task<Proyecto> Show(int projectId)
        {
            try
            {
                string path = $"/projects/{projectId}{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                RespuestaProyecto respuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(response.Data.ToString());

                if (respuestaApi.Code != 200)
                {
                    MessageBox.Show(respuestaApi.Message);
                }

                return respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        // Método para crear un nuevo proyecto (Create)
        public async Task<string> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects{groupKey}";

            try
            {
                // Serializar el objeto anónimo a JSON, ya que la api debe recibir ese formato, no un obj de .net
                string proyectoJson = JsonSerializer.Serialize(nuevoProyecto);
                var response = await SendTransaction(path, proyectoJson, "POST");

                if (response.Code == 201)
                {
                    respuestaApi = response.Message;
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }

        // Método para actualizar un proyecto (Update)
        public async Task<string> Update(int projectId, object proyectoActualizado)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{groupKey}";

            try
            {
                string proyectoJson = JsonSerializer.Serialize(proyectoActualizado);
                var response = await SendTransaction(path, proyectoJson, "PUT");

                if (response.Code == 200)
                {
                    respuestaApi = response.Message;
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }

        // Método para eliminar un proyecto (Delete)
        public async Task<string> Delete(int projectId)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{groupKey}";

            try
            {
                var response = await SendTransaction(path, "", "DELETE");

                if (response.Code == 200)
                {
                    respuestaApi = response.Message;
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }
    }
}
