using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("hours")]
        public int Hours { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("projectId")]
        public int ProjectId { get; set; }

        [JsonPropertyName("assignedEmployeeId")]
        public int AssignedEmployeeId { get; set; }
    }
}
