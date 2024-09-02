using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyecto_1.http
{
    // Respuesta base genérica para manejar respuestas API
    public class RespuestaBase<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }

    // Respuesta para operaciones generales con objeto
    public class RespuestaApi : RespuestaBase<object>
    {
    }

    // Respuesta para la lista de proyectos
    public class RespuestaListaDeProyectos : RespuestaBase<List<Proyecto>>
    {
    }

    // Respuesta para un proyecto específico
    public class RespuestaProyecto : RespuestaBase<Proyecto>
    {
    }

    // Respuesta para la creación de un proyecto
    public class RespuestaCreacionProyecto : RespuestaBase<Proyecto>
    {
    }

    // Respuesta para la lista de tareas
    public class RespuestaListaDeTareas : RespuestaBase<List<Tarea>>
    {
    }

    // Respuesta para una tarea específica
    public class RespuestaTarea : RespuestaBase<Tarea>
    {
    }

    // Respuesta para la lista de usuarios
    public class RespuestaListaDeUsuarios : RespuestaBase<List<Usuario>>
    {
    }

    // Respuesta para un usuario específico
    public class RespuestaUsuario : RespuestaBase<Usuario>
    {
    }
}
