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
            button_eliminar_pro = new Button();
            button_editar_pro = new Button();
            button_lista_pro = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Horas_Trabajadas = new DataGridViewTextBoxColumn();
            Horas_Totales = new DataGridViewTextBoxColumn();
            Fecha_Creacion = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            button_guardar_pro = new Button();
            label_nombre_pro = new Label();
            label_horas_totales_pro = new Label();
            label_horas_trabajadas_pro = new Label();
            label_descripcion_pro = new Label();
            label_fecha_creacion_pro = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel4 = new Panel();
            listBox_empleado_asignado = new ListBox();
            listBox_proyecto_tarea = new ListBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            date_fecha_inicio_tarea = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            label_fecha_inicio_tarea = new Label();
            button1 = new Button();
            label_gestion_tareas = new Label();
            panel6 = new Panel();
            dataGridView2 = new DataGridView();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Estado_2 = new DataGridViewTextBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            Área = new DataGridViewTextBoxColumn();
            Proyecto = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button_editar_tarea = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button_eliminar_pro
            // 
            button_eliminar_pro.Location = new Point(103, 240);
            button_eliminar_pro.Margin = new Padding(3, 2, 3, 2);
            button_eliminar_pro.Name = "button_eliminar_pro";
            button_eliminar_pro.Size = new Size(82, 22);
            button_eliminar_pro.TabIndex = 2;
            button_eliminar_pro.Text = "Eliminar";
            button_eliminar_pro.UseVisualStyleBackColor = true;
            button_eliminar_pro.UseWaitCursor = true;
            // 
            // button_editar_pro
            // 
            button_editar_pro.Location = new Point(16, 240);
            button_editar_pro.Margin = new Padding(3, 2, 3, 2);
            button_editar_pro.Name = "button_editar_pro";
            button_editar_pro.Size = new Size(82, 22);
            button_editar_pro.TabIndex = 1;
            button_editar_pro.Text = "Editar";
            button_editar_pro.UseVisualStyleBackColor = true;
            button_editar_pro.UseWaitCursor = true;
            // 
            // button_lista_pro
            // 
            button_lista_pro.Location = new Point(528, 240);
            button_lista_pro.Margin = new Padding(3, 2, 3, 2);
            button_lista_pro.Name = "button_lista_pro";
            button_lista_pro.Size = new Size(82, 22);
            button_lista_pro.TabIndex = 4;
            button_lista_pro.Text = "Lista";
            button_lista_pro.UseVisualStyleBackColor = true;
            button_lista_pro.UseWaitCursor = true;
            button_lista_pro.Click += button_lista_pro_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_lista_pro);
            panel1.Controls.Add(button_editar_pro);
            panel1.Controls.Add(button_eliminar_pro);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(39, 34);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 282);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Estado, Horas_Trabajadas, Horas_Totales, Fecha_Creacion });
            dataGridView1.Location = new Point(16, 10);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(668, 225);
            dataGridView1.TabIndex = 5;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // textBox2
            // 
            textBox2.Location = new Point(158, 64);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 23);
            textBox2.TabIndex = 7;
            textBox2.UseWaitCursor = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 91);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 23);
            textBox4.TabIndex = 9;
            textBox4.UseWaitCursor = true;
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
            // textBox5
            // 
            textBox5.Location = new Point(158, 118);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 23);
            textBox5.TabIndex = 10;
            textBox5.UseWaitCursor = true;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 37);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 6;
            textBox1.UseWaitCursor = true;
            // 
            // button_guardar_pro
            // 
            button_guardar_pro.Location = new Point(326, 219);
            button_guardar_pro.Margin = new Padding(3, 2, 3, 2);
            button_guardar_pro.Name = "button_guardar_pro";
            button_guardar_pro.Size = new Size(125, 41);
            button_guardar_pro.TabIndex = 11;
            button_guardar_pro.Text = "Guardar";
            button_guardar_pro.UseVisualStyleBackColor = true;
            button_guardar_pro.UseWaitCursor = true;
            button_guardar_pro.Click += button4_Click;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label_fecha_creacion_pro);
            panel2.Controls.Add(label_descripcion_pro);
            panel2.Controls.Add(label_horas_trabajadas_pro);
            panel2.Controls.Add(label_horas_totales_pro);
            panel2.Controls.Add(label_nombre_pro);
            panel2.Controls.Add(button_guardar_pro);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
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
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(date_fecha_inicio_tarea);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_fecha_inicio_tarea);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label_gestion_tareas);
            panel4.Location = new Point(745, 334);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 332);
            panel4.TabIndex = 13;
            panel4.UseWaitCursor = true;
            panel4.Paint += panel2_Paint;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(158, 66);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(293, 23);
            numericUpDown1.TabIndex = 22;
            numericUpDown1.UseWaitCursor = true;
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
            // button1
            // 
            button1.Location = new Point(326, 277);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
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
            panel6.Controls.Add(dataGridView2);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button_editar_tarea);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(37, 332);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(702, 334);
            panel6.TabIndex = 12;
            panel6.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Fecha_Inicio, Estado_2, Horas, Área, Proyecto, Empleado });
            dataGridView2.Location = new Point(18, 10);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(668, 284);
            dataGridView2.TabIndex = 6;
            dataGridView2.UseWaitCursor = true;
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
            // button2
            // 
            button2.Location = new Point(530, 298);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 4;
            button2.Text = "Lista";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button_editar_tarea
            // 
            button_editar_tarea.Location = new Point(18, 298);
            button_editar_tarea.Margin = new Padding(3, 2, 3, 2);
            button_editar_tarea.Name = "button_editar_tarea";
            button_editar_tarea.Size = new Size(82, 22);
            button_editar_tarea.TabIndex = 1;
            button_editar_tarea.Text = "Editar";
            button_editar_tarea.UseVisualStyleBackColor = true;
            button_editar_tarea.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.Location = new Point(107, 298);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 2;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
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
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_eliminar_pro;
        private Button button_editar_pro;
        private Button button_lista_pro;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox1;
        private Button button_guardar_pro;
        private Label label_nombre_pro;
        private Label label_horas_totales_pro;
        private Label label_horas_trabajadas_pro;
        private Label label_descripcion_pro;
        private Label label_fecha_creacion_pro;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel4;
        private DateTimePicker date_fecha_inicio_tarea;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label5;
        private Label label_fecha_inicio_tarea;
        private Button button1;
        private Label label_gestion_tareas;
        private Panel panel6;
        private Button button2;
        private Button button_editar_tarea;
        private Button button4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox listBox_proyecto_tarea;
        private Label label3;
        private ListBox listBox_empleado_asignado;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Horas_Trabajadas;
        private DataGridViewTextBoxColumn Horas_Totales;
        private DataGridViewTextBoxColumn Fecha_Creacion;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Estado_2;
        private DataGridViewTextBoxColumn Horas;
        private DataGridViewTextBoxColumn Área;
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn Empleado;
    }
}
