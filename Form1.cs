using Proyecto_1.http;
using Newtonsoft.Json;
using Proyecto_1.modelos;
using Proyecto_1.services;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        private bool isEditing = false;
        public Form1()
        {
            InitializeComponent();

            dataGridView_proyectos.ReadOnly = true;
            dataGridView_proyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargarProyectosEnComboBox();

            comboBox_estado.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Finalizado" });
            comboBox_estado.SelectedIndex = 0;

            CargarEmpleadosEnComboBox();


            CargarProyectosDesdeApi();


            CargarAreasEnComboBox();

            //configurar la columna de estado como ComboBox en el DataGridView
            DataGridViewComboBoxColumn estadoColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Estado",
                Name = "Estado",
                DataSource = new string[] { "Pendiente", "En Progreso", "Finalizado" },
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            };



        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // metodos para limpiar los campos ...o~~
        private void LimpiarCamposProyecto()
        {
            textBox_nombreProyecto.Clear();
            textBox_descripcion.Clear();
            comboBox_estado.SelectedIndex = 0;
            comboBox_estado.Items.Clear();
            textBox_horasTrabajadas.Clear();
            textBox_horasTotales.Clear();
            date_creacion_proyecto.Value = DateTime.Now;

        }
        private void LimpiarCamposTarea()
        {
            date_fecha_inicio_tarea.Value = DateTime.Now;
            numericUpDown_horasTarea.Value = 0;
            comboBox_proyectoTarea.SelectedIndex = -1;
            comboBox_empleadoAsignado.SelectedIndex = -1;
            comboBox_empleadoAsignado.SelectedIndex = -1;  // <-- Agregar esta línea
        }


        private async void button_guardarProyecto_Click(object sender, EventArgs e)
        {

            // recoger los valores de los campos de texto :D

            string nombreProyecto = textBox_nombreProyecto.Text;
            string descripcion = textBox_descripcion.Text;
            string estadoProyecto = comboBox_estado.SelectedItem.ToString();
            int horasTrabajadas;
            int horasTotales;
            DateTime fechaCreacion = date_creacion_proyecto.Value;


            // validar los campos numéricos o.o


            if (!int.TryParse(textBox_horasTrabajadas.Text, out horasTrabajadas) ||
            !int.TryParse(textBox_horasTotales.Text, out horasTotales))
            {
                MessageBox.Show("Por favor, ingrese números válidos para las horas trabajadas y totales.");
                return;
            }

            //VARIABLE DE API 
            var proyecto = new
            {
                nombreProyecto,
                descripcion,
                estadoProyecto,
                horasTrabajadas,
                horasTotales,
                fechaCreacion = fechaCreacion.ToString("yyyy-MM-dd"),
            };
            // DEJAR PARA INGRESAR SOLO NOMBRE, DESCRIPCIO Y HORAS TOTALES
            // Serializar el objeto a JSON
            string jsonProyecto = JsonConvert.SerializeObject(proyecto);

            // Enviar el JSON a la API
            ConexionAApi api = new ConexionAApi();
            RespuestaApi respuesta = await api.SendTransaction("/ruta-del-endpoint-proyectos", jsonProyecto, "POST");

            // Verificar la respuesta de la API
            if (respuesta.Code == 200)
            {
                // Añadir los datos a la vista
                dataGridView_proyectos.Rows.Add(nombreProyecto, descripcion, estadoProyecto, horasTrabajadas, horasTotales, fechaCreacion.ToShortDateString());

                // Limpiar campos
                LimpiarCamposProyecto();
                CargarProyectosEnComboBox();
            }
            else
            {
                MessageBox.Show($"Error al guardar el proyecto: {respuesta.Message}");
            }



            // añadir los datos a la vista 
            dataGridView_proyectos.Rows.Add(nombreProyecto, descripcion, estadoProyecto, horasTrabajadas, horasTotales, fechaCreacion.ToShortDateString());


            LimpiarCamposProyecto();
            CargarProyectosEnComboBox();
        }


        private void button_eliminarProyecto_Click(object sender, EventArgs e)
        {
            // verifica si hay una fila seleccionada
            if (dataGridView_proyectos.SelectedRows.Count > 0)  // pide confirmación para eliminar
            {

                DialogResult confirmacion = MessageBox.Show(
                    "¿Seguro que quieres eliminar este proyecto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );



                if (confirmacion == DialogResult.Yes) // se elimina la fila seleccionada
                {
                    dataGridView_proyectos.Rows.RemoveAt(dataGridView_proyectos.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_editarProyecto_Click(object sender, EventArgs e) // edicion de celdas si hay una fila seleccionada
        {

            if (dataGridView_proyectos.SelectedRows.Count > 0)
            {
                isEditing = true;
                dataGridView_proyectos.ReadOnly = false;
                dataGridView_proyectos.DefaultCellStyle.BackColor = Color.LightYellow;
                MessageBox.Show("Entraste en modo de edición.");
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarProyectosEnComboBox();
        }

        private void dataGridView_proyectos_CellContentClick(object sender, DataGridViewCellEventArgs e) //Error de tarea boton editar
        {

            if (!isEditing)
            {
                MessageBox.Show("Para editar, presione el botón 'Editar'.", "Edición no permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_finEdicion_Click(object sender, EventArgs e) //edicion de tareas boton editar 
        {

            if (isEditing)
            {
                isEditing = false;
                dataGridView_proyectos.ReadOnly = true;
                dataGridView_proyectos.DefaultCellStyle.BackColor = Color.White;
                MessageBox.Show("Cambios guardados, fin de edición.");
            }
            else
            {
                MessageBox.Show("No hay nada que confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            CargarProyectosEnComboBox();
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //FUNCIONES DE TAREAS 



        private void button_guardarTarea_Click(object sender, EventArgs e)
        {

            
            string proyectoSeleccionado = comboBox_proyectoTarea.SelectedItem?.ToString();
            string empleadoAsignado = comboBox_empleadoAsignado.SelectedItem?.ToString();
            DateTime fechaInicio = date_fecha_inicio_tarea.Value;
            int horasTarea = (int)numericUpDown_horasTarea.Value;


            if (string.IsNullOrEmpty(proyectoSeleccionado))  // Validar que los campos necesarios no estén vacíos
            {
                MessageBox.Show("Seleccione un proyecto para la tarea.", "Proyecto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(empleadoAsignado)) //valida empleado asignado 
            {
                MessageBox.Show("Seleccione un empleado asignado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (string.IsNullOrEmpty(empleadoAsignado))
            {
                MessageBox.Show("Seleccione un empleado asignado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar la nueva tarea en el dataGridView_tareas
            dataGridView_tareas.Rows.Add(proyectoSeleccionado, empleadoAsignado, fechaInicio.ToShortDateString(), horasTarea);

           
            LimpiarCamposTarea();
        }


        // metodo para cargar proyectos en comboBox_proyectoTarea desde dataGridView_proyectos
        // Evento para mostrar las tareas asociadas al proyecto seleccionado en dataGridView_proyectos
        private void dataGridView_proyectos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_proyectos.SelectedRows.Count > 0)
            {
                string proyectoSeleccionado = dataGridView_proyectos.SelectedRows[0].Cells[0].Value.ToString(); 
                MostrarTareasAsociadas(proyectoSeleccionado);
            }
        }



        private void comboBox_proyectoTarea_SelectedIndexChanged(object sender, EventArgs e) // obtener el proyecto seleccionado en el ComboBox
        {

            string proyectoSeleccionado = comboBox_proyectoTarea.SelectedItem?.ToString();


            if (!string.IsNullOrEmpty(proyectoSeleccionado)) // verificar que se haya seleccionado un proyecto
            {

                MostrarTareasAsociadas(proyectoSeleccionado);
            }
        }
        private void CargarAreasEnComboBox()
        {
            // definir las áreas
            List<string> areas = new List<string>
    {
        "Hardware",
        "Redes",
    };

            // limpiar el comboBox antes de agregar nuevos items
            comboBox_area.Items.Clear();

            // añadir las areas al comboBox
            foreach (string area in areas)
            {
                comboBox_area.Items.Add(area);
            }

            //  seleccionar el primer elemento por defecto
            if (comboBox_area.Items.Count > 0)
            {
                comboBox_area.SelectedIndex = 0;
            }
        }

        private async void CargarProyectosDesdeApi()
        {
            try
            {
                ProyectoServicio proyectoServicio = new ProyectoServicio();
                List<Proyecto> proyectos = await proyectoServicio.Index();

                dataGridView_proyectos.Rows.Clear();

                foreach (var proyecto in proyectos)
                {
                    dataGridView_proyectos.Rows.Add(
                        proyecto.Name,
                        proyecto.Description,
                        proyecto.Status,
                        proyecto.WorkerHours,
                        proyecto.TotalHours,
                        proyecto.CreatedAt.ToShortDateString());
                }

                CargarProyectosEnComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
            }
        }


        private void CargarProyectosEnComboBox()
        {
            comboBox_proyectoTarea.Items.Clear();

            foreach (DataGridViewRow row in dataGridView_proyectos.Rows)
            {

                if (row.Cells[0].Value != null)
                {

                    comboBox_proyectoTarea.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }
        private void MostrarTareasAsociadas(string proyecto)
        {
            dataGridView_tareas.Rows.Clear();



            foreach (DataGridViewRow row in dataGridView_tareas.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == proyecto)
                {
                    dataGridView_tareas.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
            }
        }

        private void CargarEmpleadosEnComboBox()
        {
            // Supongamos que tienes una lista de empleados (puede venir de una base de datos, un archivo, etc.)
            List<string> empleados = new List<string>
    {
        "Juan Pérez",
        "María García",
        "Carlos López",
        "Ana Rodríguez"
    };

        

                // Limpiar el comboBox antes de agregar nuevos items
                comboBox_empleadoAsignado.Items.Clear();

            // Añadir los empleados al comboBox
            foreach (string empleado in empleados)
            {
                comboBox_empleadoAsignado.Items.Add(empleado);
            }

            //  seleccionar el primer elemento por defecto
            if (comboBox_empleadoAsignado.Items.Count > 0)
            {
                comboBox_empleadoAsignado.SelectedIndex = 0;
            }
        }


        private void comboBox_empleadoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_tareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
