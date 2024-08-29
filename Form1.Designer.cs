namespace Proyecto_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_eliminarProyecto = new Button();
            button_editarProyecto = new Button();
            button_listaProyecto = new Button();
            panel1 = new Panel();
            dataGridView_proyectos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Horas_Trabajadas = new DataGridViewTextBoxColumn();
            Horas_Totales = new DataGridViewTextBoxColumn();
            Fecha_Creacion = new DataGridViewTextBoxColumn();
            textBox_descripcion = new TextBox();
            textBox3 = new TextBox();
            textBox_horasTrabajadas = new TextBox();
            label1 = new Label();
            textBox_horasTotales = new TextBox();
            textBox_nombreProyecto = new TextBox();
            button_guardarProyecto = new Button();
            label_nombre_pro = new Label();
            label_horas_totales_pro = new Label();
            label_horas_trabajadas_pro = new Label();
            label_descripcion_pro = new Label();
            label_fecha_creacion_pro = new Label();
            date_creacion_proyecto = new DateTimePicker();
            panel2 = new Panel();
            panel4 = new Panel();
            listBox_empleado_asignado = new ListBox();
            listBox_proyecto_tarea = new ListBox();
            label3 = new Label();
            numericUpDown_tareas = new NumericUpDown();
            date_fecha_inicio_tarea = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            label_fecha_inicio_tarea = new Label();
            button_guardarTarea = new Button();
            label_gestion_tareas = new Label();
            panel6 = new Panel();
            dataGridView_tareas = new DataGridView();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Estado_2 = new DataGridViewTextBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            Área = new DataGridViewTextBoxColumn();
            Proyecto = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            button_listaTarea = new Button();
            button_editarTarea = new Button();
            button_eliminarTarea = new Button();
            button_finEdicion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_proyectos).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tareas).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_tareas).BeginInit();
            SuspendLayout();
            // 
            // button_eliminarProyecto
            // 
            button_eliminarProyecto.Location = new Point(440, 240);
            button_eliminarProyecto.Margin = new Padding(3, 2, 3, 2);
            button_eliminarProyecto.Name = "button_eliminarProyecto";
            button_eliminarProyecto.Size = new Size(82, 22);
            button_eliminarProyecto.TabIndex = 2;
            button_eliminarProyecto.Text = "Eliminar";
            button_eliminarProyecto.UseVisualStyleBackColor = true;
            button_eliminarProyecto.UseWaitCursor = true;
            button_eliminarProyecto.Click += button_eliminarProyecto_Click;
            // 
            // button_editarProyecto
            // 
            button_editarProyecto.Location = new Point(16, 240);
            button_editarProyecto.Margin = new Padding(3, 2, 3, 2);
            button_editarProyecto.Name = "button_editarProyecto";
            button_editarProyecto.Size = new Size(82, 22);
            button_editarProyecto.TabIndex = 1;
            button_editarProyecto.Text = "Editar";
            button_editarProyecto.UseVisualStyleBackColor = true;
            button_editarProyecto.UseWaitCursor = true;
            button_editarProyecto.Click += button_editarProyecto_Click;
            // 
            // button_listaProyecto
            // 
            button_listaProyecto.Location = new Point(528, 240);
            button_listaProyecto.Margin = new Padding(3, 2, 3, 2);
            button_listaProyecto.Name = "button_listaProyecto";
            button_listaProyecto.Size = new Size(82, 22);
            button_listaProyecto.TabIndex = 4;
            button_listaProyecto.Text = "Lista";
            button_listaProyecto.UseVisualStyleBackColor = true;
            button_listaProyecto.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_finEdicion);
            panel1.Controls.Add(button_listaProyecto);
            panel1.Controls.Add(button_editarProyecto);
            panel1.Controls.Add(button_eliminarProyecto);
            panel1.Controls.Add(dataGridView_proyectos);
            panel1.Location = new Point(39, 34);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 282);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // dataGridView_proyectos
            // 
            dataGridView_proyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_proyectos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Estado, Horas_Trabajadas, Horas_Totales, Fecha_Creacion });
            dataGridView_proyectos.Location = new Point(16, 10);
            dataGridView_proyectos.Margin = new Padding(3, 2, 3, 2);
            dataGridView_proyectos.Name = "dataGridView_proyectos";
            dataGridView_proyectos.RowHeadersWidth = 51;
            dataGridView_proyectos.RowTemplate.Height = 29;
            dataGridView_proyectos.Size = new Size(668, 225);
            dataGridView_proyectos.TabIndex = 5;
            dataGridView_proyectos.UseWaitCursor = true;
            dataGridView_proyectos.CellContentClick += dataGridView_proyectos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre ";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Horas_Trabajadas
            // 
            Horas_Trabajadas.HeaderText = "Horas_Trabajadas";
            Horas_Trabajadas.MinimumWidth = 6;
            Horas_Trabajadas.Name = "Horas_Trabajadas";
            Horas_Trabajadas.Width = 125;
            // 
            // Horas_Totales
            // 
            Horas_Totales.HeaderText = "Horas_Totales";
            Horas_Totales.MinimumWidth = 6;
            Horas_Totales.Name = "Horas_Totales";
            Horas_Totales.Width = 125;
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.HeaderText = "Fecha_Creacion";
            Fecha_Creacion.MinimumWidth = 6;
            Fecha_Creacion.Name = "Fecha_Creacion";
            Fecha_Creacion.Width = 125;
            // 
            // textBox_descripcion
            // 
            textBox_descripcion.Location = new Point(158, 64);
            textBox_descripcion.Margin = new Padding(3, 2, 3, 2);
            textBox_descripcion.Name = "textBox_descripcion";
            textBox_descripcion.Size = new Size(295, 23);
            textBox_descripcion.TabIndex = 7;
            textBox_descripcion.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox_horasTrabajadas
            // 
            textBox_horasTrabajadas.Location = new Point(158, 91);
            textBox_horasTrabajadas.Margin = new Padding(3, 2, 3, 2);
            textBox_horasTrabajadas.Name = "textBox_horasTrabajadas";
            textBox_horasTrabajadas.Size = new Size(295, 23);
            textBox_horasTrabajadas.TabIndex = 9;
            textBox_horasTrabajadas.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 5;
            label1.Text = "Gestion de proyectos";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // textBox_horasTotales
            // 
            textBox_horasTotales.Location = new Point(158, 118);
            textBox_horasTotales.Margin = new Padding(3, 2, 3, 2);
            textBox_horasTotales.Name = "textBox_horasTotales";
            textBox_horasTotales.Size = new Size(295, 23);
            textBox_horasTotales.TabIndex = 10;
            textBox_horasTotales.UseWaitCursor = true;
            // 
            // textBox_nombreProyecto
            // 
            textBox_nombreProyecto.Location = new Point(158, 37);
            textBox_nombreProyecto.Margin = new Padding(3, 2, 3, 2);
            textBox_nombreProyecto.Name = "textBox_nombreProyecto";
            textBox_nombreProyecto.Size = new Size(295, 23);
            textBox_nombreProyecto.TabIndex = 6;
            textBox_nombreProyecto.UseWaitCursor = true;
            // 
            // button_guardarProyecto
            // 
            button_guardarProyecto.Location = new Point(326, 219);
            button_guardarProyecto.Margin = new Padding(3, 2, 3, 2);
            button_guardarProyecto.Name = "button_guardarProyecto";
            button_guardarProyecto.Size = new Size(125, 41);
            button_guardarProyecto.TabIndex = 11;
            button_guardarProyecto.Text = "Guardar";
            button_guardarProyecto.UseVisualStyleBackColor = true;
            button_guardarProyecto.UseWaitCursor = true;
            button_guardarProyecto.Click += button_guardarProyecto_Click;
            // 
            // label_nombre_pro
            // 
            label_nombre_pro.AutoSize = true;
            label_nombre_pro.Location = new Point(48, 45);
            label_nombre_pro.Name = "label_nombre_pro";
            label_nombre_pro.Size = new Size(51, 15);
            label_nombre_pro.TabIndex = 12;
            label_nombre_pro.Text = "Nombre";
            label_nombre_pro.UseWaitCursor = true;
            // 
            // label_horas_totales_pro
            // 
            label_horas_totales_pro.AutoSize = true;
            label_horas_totales_pro.Location = new Point(48, 123);
            label_horas_totales_pro.Name = "label_horas_totales_pro";
            label_horas_totales_pro.Size = new Size(77, 15);
            label_horas_totales_pro.TabIndex = 13;
            label_horas_totales_pro.Text = "Horas Totales";
            label_horas_totales_pro.TextAlign = ContentAlignment.TopRight;
            label_horas_totales_pro.UseWaitCursor = true;
            // 
            // label_horas_trabajadas_pro
            // 
            label_horas_trabajadas_pro.AutoSize = true;
            label_horas_trabajadas_pro.Location = new Point(48, 96);
            label_horas_trabajadas_pro.Name = "label_horas_trabajadas_pro";
            label_horas_trabajadas_pro.Size = new Size(96, 15);
            label_horas_trabajadas_pro.TabIndex = 14;
            label_horas_trabajadas_pro.Text = "Horas Trabajadas";
            label_horas_trabajadas_pro.UseWaitCursor = true;
            // 
            // label_descripcion_pro
            // 
            label_descripcion_pro.AutoSize = true;
            label_descripcion_pro.Location = new Point(48, 69);
            label_descripcion_pro.Name = "label_descripcion_pro";
            label_descripcion_pro.Size = new Size(69, 15);
            label_descripcion_pro.TabIndex = 16;
            label_descripcion_pro.Text = "Descripcion";
            label_descripcion_pro.UseWaitCursor = true;
            // 
            // label_fecha_creacion_pro
            // 
            label_fecha_creacion_pro.AutoSize = true;
            label_fecha_creacion_pro.Location = new Point(48, 151);
            label_fecha_creacion_pro.Name = "label_fecha_creacion_pro";
            label_fecha_creacion_pro.Size = new Size(88, 15);
            label_fecha_creacion_pro.TabIndex = 17;
            label_fecha_creacion_pro.Text = "Fecha Creacion";
            label_fecha_creacion_pro.UseWaitCursor = true;
            // 
            // date_creacion_proyecto
            // 
            date_creacion_proyecto.Location = new Point(158, 146);
            date_creacion_proyecto.Name = "date_creacion_proyecto";
            date_creacion_proyecto.Size = new Size(295, 23);
            date_creacion_proyecto.TabIndex = 20;
            date_creacion_proyecto.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(date_creacion_proyecto);
            panel2.Controls.Add(label_fecha_creacion_pro);
            panel2.Controls.Add(label_descripcion_pro);
            panel2.Controls.Add(label_horas_trabajadas_pro);
            panel2.Controls.Add(label_horas_totales_pro);
            panel2.Controls.Add(label_nombre_pro);
            panel2.Controls.Add(button_guardarProyecto);
            panel2.Controls.Add(textBox_nombreProyecto);
            panel2.Controls.Add(textBox_horasTotales);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_horasTrabajadas);
            panel2.Controls.Add(textBox_descripcion);
            panel2.Location = new Point(745, 36);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 280);
            panel2.TabIndex = 11;
            panel2.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox_empleado_asignado);
            panel4.Controls.Add(listBox_proyecto_tarea);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numericUpDown_tareas);
            panel4.Controls.Add(date_fecha_inicio_tarea);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_fecha_inicio_tarea);
            panel4.Controls.Add(button_guardarTarea);
            panel4.Controls.Add(label_gestion_tareas);
            panel4.Location = new Point(745, 334);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 332);
            panel4.TabIndex = 13;
            panel4.UseWaitCursor = true;
            // 
            // listBox_empleado_asignado
            // 
            listBox_empleado_asignado.FormattingEnabled = true;
            listBox_empleado_asignado.ItemHeight = 15;
            listBox_empleado_asignado.Location = new Point(158, 134);
            listBox_empleado_asignado.Name = "listBox_empleado_asignado";
            listBox_empleado_asignado.Size = new Size(295, 19);
            listBox_empleado_asignado.TabIndex = 25;
            listBox_empleado_asignado.UseWaitCursor = true;
            // 
            // listBox_proyecto_tarea
            // 
            listBox_proyecto_tarea.FormattingEnabled = true;
            listBox_proyecto_tarea.ItemHeight = 15;
            listBox_proyecto_tarea.Location = new Point(158, 103);
            listBox_proyecto_tarea.Name = "listBox_proyecto_tarea";
            listBox_proyecto_tarea.Size = new Size(295, 19);
            listBox_proyecto_tarea.TabIndex = 24;
            listBox_proyecto_tarea.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 136);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 23;
            label3.Text = "Empleado Asignado";
            label3.UseWaitCursor = true;
            // 
            // numericUpDown_tareas
            // 
            numericUpDown_tareas.Location = new Point(158, 66);
            numericUpDown_tareas.Name = "numericUpDown_tareas";
            numericUpDown_tareas.Size = new Size(293, 23);
            numericUpDown_tareas.TabIndex = 22;
            numericUpDown_tareas.UseWaitCursor = true;
            // 
            // date_fecha_inicio_tarea
            // 
            date_fecha_inicio_tarea.Location = new Point(158, 37);
            date_fecha_inicio_tarea.Name = "date_fecha_inicio_tarea";
            date_fecha_inicio_tarea.Size = new Size(295, 23);
            date_fecha_inicio_tarea.TabIndex = 21;
            date_fecha_inicio_tarea.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 17;
            label2.Text = "Proyecto";
            label2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 72);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "Horas";
            label5.UseWaitCursor = true;
            // 
            // label_fecha_inicio_tarea
            // 
            label_fecha_inicio_tarea.AutoSize = true;
            label_fecha_inicio_tarea.Location = new Point(29, 43);
            label_fecha_inicio_tarea.Name = "label_fecha_inicio_tarea";
            label_fecha_inicio_tarea.Size = new Size(70, 15);
            label_fecha_inicio_tarea.TabIndex = 12;
            label_fecha_inicio_tarea.Text = "Fecha Inicio";
            label_fecha_inicio_tarea.UseWaitCursor = true;
            // 
            // button_guardarTarea
            // 
            button_guardarTarea.Location = new Point(326, 277);
            button_guardarTarea.Margin = new Padding(3, 2, 3, 2);
            button_guardarTarea.Name = "button_guardarTarea";
            button_guardarTarea.Size = new Size(127, 41);
            button_guardarTarea.TabIndex = 11;
            button_guardarTarea.Text = "Guardar";
            button_guardarTarea.UseVisualStyleBackColor = true;
            button_guardarTarea.UseWaitCursor = true;
            // 
            // label_gestion_tareas
            // 
            label_gestion_tareas.AutoSize = true;
            label_gestion_tareas.ForeColor = Color.CornflowerBlue;
            label_gestion_tareas.Location = new Point(15, 8);
            label_gestion_tareas.Name = "label_gestion_tareas";
            label_gestion_tareas.Size = new Size(98, 15);
            label_gestion_tareas.TabIndex = 5;
            label_gestion_tareas.Text = "Gestion de Tareas";
            label_gestion_tareas.UseWaitCursor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView_tareas);
            panel6.Controls.Add(button_listaTarea);
            panel6.Controls.Add(button_editarTarea);
            panel6.Controls.Add(button_eliminarTarea);
            panel6.Location = new Point(37, 332);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(702, 334);
            panel6.TabIndex = 12;
            panel6.UseWaitCursor = true;
            // 
            // dataGridView_tareas
            // 
            dataGridView_tareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_tareas.Columns.AddRange(new DataGridViewColumn[] { Fecha_Inicio, Estado_2, Horas, Área, Proyecto, Empleado });
            dataGridView_tareas.Location = new Point(18, 10);
            dataGridView_tareas.Margin = new Padding(3, 2, 3, 2);
            dataGridView_tareas.Name = "dataGridView_tareas";
            dataGridView_tareas.RowHeadersWidth = 51;
            dataGridView_tareas.RowTemplate.Height = 29;
            dataGridView_tareas.Size = new Size(668, 284);
            dataGridView_tareas.TabIndex = 6;
            dataGridView_tareas.UseWaitCursor = true;
            // 
            // Fecha_Inicio
            // 
            Fecha_Inicio.HeaderText = "Fecha_Inicio";
            Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // Estado_2
            // 
            Estado_2.HeaderText = "Estado";
            Estado_2.Name = "Estado_2";
            // 
            // Horas
            // 
            Horas.HeaderText = "Horas";
            Horas.Name = "Horas";
            // 
            // Área
            // 
            Área.HeaderText = "Área";
            Área.Name = "Área";
            // 
            // Proyecto
            // 
            Proyecto.HeaderText = "Proyecto";
            Proyecto.Name = "Proyecto";
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.Name = "Empleado";
            // 
            // button_listaTarea
            // 
            button_listaTarea.Location = new Point(530, 298);
            button_listaTarea.Margin = new Padding(3, 2, 3, 2);
            button_listaTarea.Name = "button_listaTarea";
            button_listaTarea.Size = new Size(82, 22);
            button_listaTarea.TabIndex = 4;
            button_listaTarea.Text = "Lista";
            button_listaTarea.UseVisualStyleBackColor = true;
            button_listaTarea.UseWaitCursor = true;
            // 
            // button_editarTarea
            // 
            button_editarTarea.Location = new Point(18, 298);
            button_editarTarea.Margin = new Padding(3, 2, 3, 2);
            button_editarTarea.Name = "button_editarTarea";
            button_editarTarea.Size = new Size(82, 22);
            button_editarTarea.TabIndex = 1;
            button_editarTarea.Text = "Editar";
            button_editarTarea.UseVisualStyleBackColor = true;
            button_editarTarea.UseWaitCursor = true;
            // 
            // button_eliminarTarea
            // 
            button_eliminarTarea.Location = new Point(107, 298);
            button_eliminarTarea.Margin = new Padding(3, 2, 3, 2);
            button_eliminarTarea.Name = "button_eliminarTarea";
            button_eliminarTarea.Size = new Size(82, 22);
            button_eliminarTarea.TabIndex = 2;
            button_eliminarTarea.Text = "Eliminar";
            button_eliminarTarea.UseVisualStyleBackColor = true;
            button_eliminarTarea.UseWaitCursor = true;
            // 
            // button_finEdicion
            // 
            button_finEdicion.Location = new Point(105, 240);
            button_finEdicion.Margin = new Padding(3, 2, 3, 2);
            button_finEdicion.Name = "button_finEdicion";
            button_finEdicion.Size = new Size(82, 22);
            button_finEdicion.TabIndex = 6;
            button_finEdicion.Text = "Confirmar";
            button_finEdicion.UseVisualStyleBackColor = true;
            button_finEdicion.UseWaitCursor = true;
            button_finEdicion.Click += button_finEdicion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 697);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            UseWaitCursor = true;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_proyectos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tareas).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_tareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_eliminarProyecto;
        private Button button_editarProyecto;
        private Button button_listaProyecto;
        private Panel panel1;
        private TextBox textBox_descripcion;
        private TextBox textBox3;
        private TextBox textBox_horasTrabajadas;
        private Label label1;
        private TextBox textBox_horasTotales;
        private TextBox textBox_nombreProyecto;
        private Button button_guardarProyecto;
        private Label label_nombre_pro;
        private Label label_horas_totales_pro;
        private Label label_horas_trabajadas_pro;
        private Label label_descripcion_pro;
        private Label label_fecha_creacion_pro;
        private DateTimePicker date_creacion_proyecto;
        private Panel panel2;
        private Panel panel4;
        private DateTimePicker date_fecha_inicio_tarea;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label5;
        private Label label_fecha_inicio_tarea;
        private Button button_guardarTarea;
        private Label label_gestion_tareas;
        private Panel panel6;
        private Button button_listaTarea;
        private Button button_editarTarea;
        private Button button_eliminarTarea;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox listBox_proyecto_tarea;
        private Label label3;
        private ListBox listBox_empleado_asignado;
        private DataGridView dataGridView_proyectos;
        private DataGridView dataGridView_tareas;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Horas_Trabajadas;
        private DataGridViewTextBoxColumn Horas_Totales;
        private DataGridViewTextBoxColumn Fecha_Creacion;
        private NumericUpDown numericUpDown_tareas;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Estado_2;
        private DataGridViewTextBoxColumn Horas;
        private DataGridViewTextBoxColumn Área;
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn Empleado;
        private Button button_finEdicion;
    }
}
