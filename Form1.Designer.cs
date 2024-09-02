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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button_eliminarProyecto = new Button();
            button_editarProyecto = new Button();
            button_listaProyecto = new Button();
            panel1 = new Panel();
            button_finEdicion = new Button();
            dataGridView_proyectos = new DataGridView();
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
            comboBox_estado = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            comboBox_area = new ComboBox();
            label7 = new Label();
            comboBox_empleadoAsignado = new ComboBox();
            comboBox_proyectoTarea = new ComboBox();
            label3 = new Label();
            numericUpDown_horasTarea = new NumericUpDown();
            date_fecha_inicio_tarea = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            label_fecha_inicio_tarea = new Label();
            button_guardarTarea = new Button();
            label_gestion_tareas = new Label();
            panel6 = new Panel();
            dataGridView_tareas = new DataGridView();
            Proyecto_Asignado = new DataGridViewTextBoxColumn();
            Personal_asignado = new DataGridViewTextBoxColumn();
            Fecha_asignada = new DataGridViewTextBoxColumn();
            Horas_asignadas = new DataGridViewTextBoxColumn();
            button_listaTarea = new Button();
            button_editarTarea = new Button();
            button_eliminarTarea = new Button();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Horas_Trabajadas = new DataGridViewTextBoxColumn();
            Horas_Totales = new DataGridViewTextBoxColumn();
            Fecha_Creacion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_proyectos).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_horasTarea).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_tareas).BeginInit();
            SuspendLayout();
            // 
            // button_eliminarProyecto
            // 
            button_eliminarProyecto.Location = new Point(514, 239);
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
            button_listaProyecto.Location = new Point(602, 239);
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
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(39, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 296);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
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
            // dataGridView_proyectos
            // 
            dataGridView_proyectos.BackgroundColor = SystemColors.Window;
            dataGridView_proyectos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_proyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_proyectos.ColumnHeadersHeight = 30;
            dataGridView_proyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_proyectos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Estado, Horas_Trabajadas, Horas_Totales, Fecha_Creacion });
            dataGridView_proyectos.EnableHeadersVisualStyles = false;
            dataGridView_proyectos.GridColor = Color.Blue;
            dataGridView_proyectos.Location = new Point(16, 10);
            dataGridView_proyectos.Margin = new Padding(3, 2, 3, 2);
            dataGridView_proyectos.Name = "dataGridView_proyectos";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_proyectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_proyectos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridView_proyectos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_proyectos.RowTemplate.Height = 29;
            dataGridView_proyectos.Size = new Size(668, 225);
            dataGridView_proyectos.TabIndex = 5;
            dataGridView_proyectos.UseWaitCursor = true;
            dataGridView_proyectos.CellContentClick += dataGridView_proyectos_CellContentClick;
            // 
            // textBox_descripcion
            // 
            textBox_descripcion.Location = new Point(156, 66);
            textBox_descripcion.Margin = new Padding(3, 2, 3, 2);
            textBox_descripcion.Multiline = true;
            textBox_descripcion.Name = "textBox_descripcion";
            textBox_descripcion.Size = new Size(295, 54);
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
            textBox_horasTrabajadas.Location = new Point(156, 153);
            textBox_horasTrabajadas.Margin = new Padding(3, 2, 3, 2);
            textBox_horasTrabajadas.Name = "textBox_horasTrabajadas";
            textBox_horasTrabajadas.Size = new Size(295, 23);
            textBox_horasTrabajadas.TabIndex = 9;
            textBox_horasTrabajadas.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 5;
            label1.Text = "Gestion de proyectos";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // textBox_horasTotales
            // 
            textBox_horasTotales.Location = new Point(156, 180);
            textBox_horasTotales.Margin = new Padding(3, 2, 3, 2);
            textBox_horasTotales.Name = "textBox_horasTotales";
            textBox_horasTotales.Size = new Size(295, 23);
            textBox_horasTotales.TabIndex = 10;
            textBox_horasTotales.UseWaitCursor = true;
            // 
            // textBox_nombreProyecto
            // 
            textBox_nombreProyecto.Location = new Point(156, 39);
            textBox_nombreProyecto.Margin = new Padding(3, 2, 3, 2);
            textBox_nombreProyecto.Name = "textBox_nombreProyecto";
            textBox_nombreProyecto.Size = new Size(295, 23);
            textBox_nombreProyecto.TabIndex = 6;
            textBox_nombreProyecto.UseWaitCursor = true;
            // 
            // button_guardarProyecto
            // 
            button_guardarProyecto.BackColor = SystemColors.Highlight;
            button_guardarProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_guardarProyecto.ForeColor = Color.Transparent;
            button_guardarProyecto.Location = new Point(323, 245);
            button_guardarProyecto.Margin = new Padding(3, 2, 3, 2);
            button_guardarProyecto.Name = "button_guardarProyecto";
            button_guardarProyecto.Size = new Size(128, 43);
            button_guardarProyecto.TabIndex = 11;
            button_guardarProyecto.Text = "Guardar";
            button_guardarProyecto.UseVisualStyleBackColor = false;
            button_guardarProyecto.UseWaitCursor = true;
            button_guardarProyecto.Click += button_guardarProyecto_Click;
            // 
            // label_nombre_pro
            // 
            label_nombre_pro.AutoSize = true;
            label_nombre_pro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_nombre_pro.Location = new Point(14, 40);
            label_nombre_pro.Name = "label_nombre_pro";
            label_nombre_pro.Size = new Size(139, 17);
            label_nombre_pro.TabIndex = 12;
            label_nombre_pro.Text = "Nombre del proyecto";
            label_nombre_pro.UseWaitCursor = true;
            // 
            // label_horas_totales_pro
            // 
            label_horas_totales_pro.AutoSize = true;
            label_horas_totales_pro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_horas_totales_pro.Location = new Point(14, 181);
            label_horas_totales_pro.Name = "label_horas_totales_pro";
            label_horas_totales_pro.Size = new Size(92, 17);
            label_horas_totales_pro.TabIndex = 13;
            label_horas_totales_pro.Text = "Horas Totales";
            label_horas_totales_pro.TextAlign = ContentAlignment.TopRight;
            label_horas_totales_pro.UseWaitCursor = true;
            // 
            // label_horas_trabajadas_pro
            // 
            label_horas_trabajadas_pro.AutoSize = true;
            label_horas_trabajadas_pro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_horas_trabajadas_pro.Location = new Point(14, 154);
            label_horas_trabajadas_pro.Name = "label_horas_trabajadas_pro";
            label_horas_trabajadas_pro.Size = new Size(114, 17);
            label_horas_trabajadas_pro.TabIndex = 14;
            label_horas_trabajadas_pro.Text = "Horas Trabajadas";
            label_horas_trabajadas_pro.UseWaitCursor = true;
            // 
            // label_descripcion_pro
            // 
            label_descripcion_pro.AutoSize = true;
            label_descripcion_pro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_descripcion_pro.Location = new Point(14, 67);
            label_descripcion_pro.Name = "label_descripcion_pro";
            label_descripcion_pro.Size = new Size(80, 17);
            label_descripcion_pro.TabIndex = 16;
            label_descripcion_pro.Text = "Descripcion";
            label_descripcion_pro.UseWaitCursor = true;
            // 
            // label_fecha_creacion_pro
            // 
            label_fecha_creacion_pro.AutoSize = true;
            label_fecha_creacion_pro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_fecha_creacion_pro.Location = new Point(15, 212);
            label_fecha_creacion_pro.Name = "label_fecha_creacion_pro";
            label_fecha_creacion_pro.Size = new Size(100, 17);
            label_fecha_creacion_pro.TabIndex = 17;
            label_fecha_creacion_pro.Text = "Fecha Creacion";
            label_fecha_creacion_pro.UseWaitCursor = true;
            // 
            // date_creacion_proyecto
            // 
            date_creacion_proyecto.Location = new Point(156, 208);
            date_creacion_proyecto.Name = "date_creacion_proyecto";
            date_creacion_proyecto.Size = new Size(295, 23);
            date_creacion_proyecto.TabIndex = 20;
            date_creacion_proyecto.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_estado);
            panel2.Controls.Add(label4);
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
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(745, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 294);
            panel2.TabIndex = 11;
            panel2.UseWaitCursor = true;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox_estado
            // 
            comboBox_estado.FormattingEnabled = true;
            comboBox_estado.Location = new Point(156, 125);
            comboBox_estado.Name = "comboBox_estado";
            comboBox_estado.Size = new Size(295, 23);
            comboBox_estado.TabIndex = 22;
            comboBox_estado.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 125);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 21;
            label4.Text = "Estado";
            label4.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox_area);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(comboBox_empleadoAsignado);
            panel4.Controls.Add(comboBox_proyectoTarea);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numericUpDown_horasTarea);
            panel4.Controls.Add(date_fecha_inicio_tarea);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_fecha_inicio_tarea);
            panel4.Controls.Add(button_guardarTarea);
            panel4.Controls.Add(label_gestion_tareas);
            panel4.Location = new Point(745, 332);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 334);
            panel4.TabIndex = 13;
            panel4.UseWaitCursor = true;
            // 
            // comboBox_area
            // 
            comboBox_area.FormattingEnabled = true;
            comboBox_area.Location = new Point(158, 95);
            comboBox_area.Name = "comboBox_area";
            comboBox_area.Size = new Size(293, 23);
            comboBox_area.TabIndex = 29;
            comboBox_area.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 104);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 28;
            label7.Text = "Area";
            label7.UseWaitCursor = true;
            // 
            // comboBox_empleadoAsignado
            // 
            comboBox_empleadoAsignado.FormattingEnabled = true;
            comboBox_empleadoAsignado.Location = new Point(158, 158);
            comboBox_empleadoAsignado.Name = "comboBox_empleadoAsignado";
            comboBox_empleadoAsignado.Size = new Size(293, 23);
            comboBox_empleadoAsignado.TabIndex = 27;
            comboBox_empleadoAsignado.UseWaitCursor = true;
            comboBox_empleadoAsignado.SelectedIndexChanged += comboBox_empleadoAsignado_SelectedIndexChanged;
            // 
            // comboBox_proyectoTarea
            // 
            comboBox_proyectoTarea.FormattingEnabled = true;
            comboBox_proyectoTarea.Location = new Point(158, 127);
            comboBox_proyectoTarea.Name = "comboBox_proyectoTarea";
            comboBox_proyectoTarea.Size = new Size(293, 23);
            comboBox_proyectoTarea.TabIndex = 26;
            comboBox_proyectoTarea.UseWaitCursor = true;
            comboBox_proyectoTarea.SelectedIndexChanged += comboBox_proyectoTarea_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 161);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 23;
            label3.Text = "Empleado Asignado";
            label3.UseWaitCursor = true;
            // 
            // numericUpDown_horasTarea
            // 
            numericUpDown_horasTarea.Location = new Point(158, 66);
            numericUpDown_horasTarea.Name = "numericUpDown_horasTarea";
            numericUpDown_horasTarea.Size = new Size(293, 23);
            numericUpDown_horasTarea.TabIndex = 22;
            numericUpDown_horasTarea.UseWaitCursor = true;
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
            label2.Location = new Point(29, 130);
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
            button_guardarTarea.Location = new Point(323, 277);
            button_guardarTarea.Margin = new Padding(3, 2, 3, 2);
            button_guardarTarea.Name = "button_guardarTarea";
            button_guardarTarea.Size = new Size(127, 41);
            button_guardarTarea.TabIndex = 11;
            button_guardarTarea.Text = "Guardar";
            button_guardarTarea.UseVisualStyleBackColor = true;
            button_guardarTarea.UseWaitCursor = true;
            button_guardarTarea.Click += button_guardarTarea_Click;
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
            dataGridView_tareas.Columns.AddRange(new DataGridViewColumn[] { Proyecto_Asignado, Personal_asignado, Fecha_asignada, Horas_asignadas });
            dataGridView_tareas.GridColor = Color.Blue;
            dataGridView_tareas.Location = new Point(18, 10);
            dataGridView_tareas.Margin = new Padding(3, 2, 3, 2);
            dataGridView_tareas.Name = "dataGridView_tareas";
            dataGridView_tareas.RowHeadersWidth = 51;
            dataGridView_tareas.RowTemplate.Height = 29;
            dataGridView_tareas.Size = new Size(668, 284);
            dataGridView_tareas.TabIndex = 6;
            dataGridView_tareas.UseWaitCursor = true;
            dataGridView_tareas.CellContentClick += dataGridView_tareas_CellContentClick;
            // 
            // Proyecto_Asignado
            // 
            Proyecto_Asignado.HeaderText = "Poyecto Asignado";
            Proyecto_Asignado.Name = "Proyecto_Asignado";
            // 
            // Personal_asignado
            // 
            Personal_asignado.HeaderText = "Personal Asignado";
            Personal_asignado.Name = "Personal_asignado";
            // 
            // Fecha_asignada
            // 
            Fecha_asignada.HeaderText = "Fecha Asignada";
            Fecha_asignada.Name = "Fecha_asignada";
            // 
            // Horas_asignadas
            // 
            Horas_asignadas.HeaderText = "Horas Asignadas";
            Horas_asignadas.Name = "Horas_asignadas";
            // 
            // button_listaTarea
            // 
            button_listaTarea.Location = new Point(604, 298);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown_horasTarea).EndInit();
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
        private Label label3;
        private ListBox listBox_empleado_asignado;
        private DataGridView dataGridView_proyectos;
        private DataGridView dataGridView_tareas;
        private NumericUpDown numericUpDown_horasTarea;
        private Button button_finEdicion;
        private ComboBox comboBox_proyectoTarea;
        private ComboBox comboBox_empleadoAsignado;
        private ComboBox comboBox_estado;
        private Label label4;
        private DataGridViewTextBoxColumn Proyecto_Asignado;
        private DataGridViewTextBoxColumn Personal_asignado;
        private DataGridViewTextBoxColumn Fecha_asignada;
        private DataGridViewTextBoxColumn Horas_asignadas;
        private ComboBox comboBox_area;
        private Label label7;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Horas_Trabajadas;
        private DataGridViewTextBoxColumn Horas_Totales;
        private DataGridViewTextBoxColumn Fecha_Creacion;
    }
}
