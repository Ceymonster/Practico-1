using Proyecto_1.http;
using Proyecto_1.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto_1.servicios
{
    public class TareaServicio : ConexionAApi
    {
        private readonly string groupKey = "/x7Y8z9W0";

        // Método para obtener la lista de tareas
        public async Task<List<Tarea>> Index()
        {
            RespuestaListaDeTareas respuestaApi;
            try
            {
                string path = $"/tasks{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonRespuestaApi);

                if (respuestaApi == null || respuestaApi.Code != 200)
                {
                    MessageBox.Show("Error al obtener la lista de tareas: " + respuestaApi?.Message);
                    return new List<Tarea>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener tareas filtradas por proyecto
        public async Task<List<Tarea>> GetTareasPorProyecto(int projectId)
        {
            var tareas = new List<Tarea>();
            string path = $"/tasks{groupKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    string jsonData = jsonRespuestaApi.Data.ToString();
                    var respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonData);

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        tareas = respuestaApi.Data.Where(t => t.ProjectId == projectId).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return tareas;
        }

        public async Task<Tarea> Show(int tareaId)
        {
            Tarea tarea = null;
            string path = $"/tasks/{tareaId}{groupKey}";
            string body = "";
            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    string jsonData = jsonRespuestaApi.Data.ToString();
                    MessageBox.Show($"JSON devuelto por la API: {jsonData}");

                    var respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(jsonData);
                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        tarea = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return tarea;
        }

        // Método para crear una nueva tarea (Create)
        public async Task<string> Create(Tarea nuevaTarea)
        {
            string respuestaApi = null;
            string path = $"/tasks{groupKey}";

            try
            {
                string tareaJson = JsonSerializer.Serialize(nuevaTarea);
                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "POST");
                if (jsonRespuestaApi.Code == 201)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    MessageBox.Show($"Error al crear la tarea: {jsonRespuestaApi.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
                throw;
            }

            return respuestaApi;
        }

        // Método para actualizar una tarea existente (Update)
        public async Task<string> Update(int tareaId, Tarea tareaActualizada)
        {
            string respuestaApi = null;
            string path = $"/tasks/{tareaId}{groupKey}";

            try
            {
                string tareaJson = JsonSerializer.Serialize(tareaActualizada);
                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "PUT");

                if (jsonRespuestaApi.Code == 200)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    MessageBox.Show("Error al actualizar la tarea: " + jsonRespuestaApi.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar una tarea existente (Delete)
        public async Task<string> Delete(int tareaId)
        {
            string respuestaApi = null;
            string path = $"/tasks/{tareaId}{groupKey}";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, "", "DELETE");

                if (jsonRespuestaApi.Code == 200)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    MessageBox.Show("Error al eliminar la tarea: " + jsonRespuestaApi.Message);
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
