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
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // metodo para limpiar los campos ...o~~
        private void LimpiarCamposProyecto()
        {
            textBox_nombreProyecto.Clear();
            textBox_descripcion.Clear();
            textBox_horasTrabajadas.Clear();
            textBox_horasTotales.Clear();
            date_creacion_proyecto.Value = DateTime.Now;
        }
        private void button_guardarProyecto_Click(object sender, EventArgs e)
        {

            // recoger los valores de los campos de texto :D

            string nombreProyecto = textBox_nombreProyecto.Text;
            string descripcion = textBox_descripcion.Text;
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

            // añadir los datos a la vista 
            dataGridView_proyectos.Rows.Add(nombreProyecto, descripcion, horasTrabajadas, horasTotales, fechaCreacion.ToShortDateString());

            LimpiarCamposProyecto();
        }


        private void button_eliminarProyecto_Click(object sender, EventArgs e)
        {
            // verifica si hay una fila seleccionada
            if (dataGridView_proyectos.SelectedRows.Count > 0)
            {
                // pide confirmación para eliminar
                DialogResult confirmacion = MessageBox.Show(
                    "¿Seguro que quieres eliminar este proyecto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // se elimina la fila seleccionada
                if (confirmacion == DialogResult.Yes)
                {
                    dataGridView_proyectos.Rows.RemoveAt(dataGridView_proyectos.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_editarProyecto_Click(object sender, EventArgs e)
        {
            // habilita la edicion de celdas si hay una fila seleccionada
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
        }

        private void dataGridView_proyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // bloquea la edición si no se ha activado el modo de edición
            if (!isEditing)
            {
                MessageBox.Show("Para editar, presione el botón 'Editar'.", "Edición no permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_finEdicion_Click(object sender, EventArgs e)
        {
            // finaliza el modo de edición
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
        }

    }
}
