﻿namespace Proyecto_1
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
            listBox1 = new ListBox();
            panel1 = new Panel();
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
            label_estado_pro = new Label();
            label_descripcion_pro = new Label();
            label_fecha_creacion_pro = new Label();
            panel3 = new Panel();
            radioButton_progreso = new RadioButton();
            radioButton_finalizado = new RadioButton();
            radioButton_pendiente = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel4 = new Panel();
            listBox_empleado_asignado = new ListBox();
            listBox_proyecto_tarea = new ListBox();
            label3 = new Label();
            panel7 = new Panel();
            radioButton_redes = new RadioButton();
            radioButton_hardware = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            date_fecha_inicio_tarea = new DateTimePicker();
            panel5 = new Panel();
            radioButton_progreso_tarea = new RadioButton();
            radioButton_finalizado_tarea = new RadioButton();
            radioButton_pendiente_tarea = new RadioButton();
            label2 = new Label();
            label_estado_tarea = new Label();
            label5 = new Label();
            label_area_tarea = new Label();
            label_fecha_inicio_tarea = new Label();
            button1 = new Button();
            label_gestion_tareas = new Label();
            panel6 = new Panel();
            listBox2 = new ListBox();
            button2 = new Button();
            button_editar_tarea = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // button_eliminar_pro
            // 
            button_eliminar_pro.Location = new Point(131, 245);
            button_eliminar_pro.Name = "button_eliminar_pro";
            button_eliminar_pro.Size = new Size(94, 29);
            button_eliminar_pro.TabIndex = 2;
            button_eliminar_pro.Text = "Eliminar";
            button_eliminar_pro.UseVisualStyleBackColor = true;
            button_eliminar_pro.UseWaitCursor = true;
            // 
            // button_editar_pro
            // 
            button_editar_pro.Location = new Point(31, 245);
            button_editar_pro.Name = "button_editar_pro";
            button_editar_pro.Size = new Size(94, 29);
            button_editar_pro.TabIndex = 1;
            button_editar_pro.Text = "Editar";
            button_editar_pro.UseVisualStyleBackColor = true;
            button_editar_pro.UseWaitCursor = true;
            // 
            // button_lista_pro
            // 
            button_lista_pro.Location = new Point(616, 245);
            button_lista_pro.Name = "button_lista_pro";
            button_lista_pro.Size = new Size(94, 29);
            button_lista_pro.TabIndex = 4;
            button_lista_pro.Text = "Lista";
            button_lista_pro.UseVisualStyleBackColor = true;
            button_lista_pro.UseWaitCursor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(707, 224);
            listBox1.TabIndex = 4;
            listBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button_lista_pro);
            panel1.Controls.Add(button_editar_pro);
            panel1.Controls.Add(button_eliminar_pro);
            panel1.Location = new Point(45, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 376);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 27);
            textBox2.TabIndex = 7;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(337, 27);
            textBox4.TabIndex = 9;
            textBox4.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 5;
            label1.Text = "Gestion de proyectos";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(337, 27);
            textBox5.TabIndex = 10;
            textBox5.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 27);
            textBox1.TabIndex = 6;
            textBox1.UseWaitCursor = true;
            // 
            // button_guardar_pro
            // 
            button_guardar_pro.Location = new Point(495, 317);
            button_guardar_pro.Name = "button_guardar_pro";
            button_guardar_pro.Size = new Size(99, 29);
            button_guardar_pro.TabIndex = 11;
            button_guardar_pro.Text = "Guardar";
            button_guardar_pro.UseVisualStyleBackColor = true;
            button_guardar_pro.UseWaitCursor = true;
            button_guardar_pro.Click += button4_Click;
            // 
            // label_nombre_pro
            // 
            label_nombre_pro.AutoSize = true;
            label_nombre_pro.Location = new Point(47, 59);
            label_nombre_pro.Name = "label_nombre_pro";
            label_nombre_pro.Size = new Size(64, 20);
            label_nombre_pro.TabIndex = 12;
            label_nombre_pro.Text = "Nombre";
            label_nombre_pro.UseWaitCursor = true;
            // 
            // label_horas_totales_pro
            // 
            label_horas_totales_pro.AutoSize = true;
            label_horas_totales_pro.Location = new Point(47, 223);
            label_horas_totales_pro.Name = "label_horas_totales_pro";
            label_horas_totales_pro.Size = new Size(99, 20);
            label_horas_totales_pro.TabIndex = 13;
            label_horas_totales_pro.Text = "Horas Totales";
            label_horas_totales_pro.TextAlign = ContentAlignment.TopRight;
            label_horas_totales_pro.UseWaitCursor = true;
            // 
            // label_horas_trabajadas_pro
            // 
            label_horas_trabajadas_pro.AutoSize = true;
            label_horas_trabajadas_pro.Location = new Point(47, 187);
            label_horas_trabajadas_pro.Name = "label_horas_trabajadas_pro";
            label_horas_trabajadas_pro.Size = new Size(124, 20);
            label_horas_trabajadas_pro.TabIndex = 14;
            label_horas_trabajadas_pro.Text = "Horas Trabajadas";
            label_horas_trabajadas_pro.UseWaitCursor = true;
            // 
            // label_estado_pro
            // 
            label_estado_pro.AutoSize = true;
            label_estado_pro.Location = new Point(47, 132);
            label_estado_pro.Name = "label_estado_pro";
            label_estado_pro.Size = new Size(54, 20);
            label_estado_pro.TabIndex = 15;
            label_estado_pro.Text = "Estado";
            label_estado_pro.UseWaitCursor = true;
            // 
            // label_descripcion_pro
            // 
            label_descripcion_pro.AutoSize = true;
            label_descripcion_pro.Location = new Point(47, 91);
            label_descripcion_pro.Name = "label_descripcion_pro";
            label_descripcion_pro.Size = new Size(87, 20);
            label_descripcion_pro.TabIndex = 16;
            label_descripcion_pro.Text = "Descripcion";
            label_descripcion_pro.UseWaitCursor = true;
            // 
            // label_fecha_creacion_pro
            // 
            label_fecha_creacion_pro.AutoSize = true;
            label_fecha_creacion_pro.Location = new Point(47, 260);
            label_fecha_creacion_pro.Name = "label_fecha_creacion_pro";
            label_fecha_creacion_pro.Size = new Size(109, 20);
            label_fecha_creacion_pro.TabIndex = 17;
            label_fecha_creacion_pro.Text = "Fecha Creacion";
            label_fecha_creacion_pro.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton_progreso);
            panel3.Controls.Add(radioButton_finalizado);
            panel3.Controls.Add(radioButton_pendiente);
            panel3.Location = new Point(262, 117);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 55);
            panel3.TabIndex = 19;
            panel3.UseWaitCursor = true;
            // 
            // radioButton_progreso
            // 
            radioButton_progreso.AutoSize = true;
            radioButton_progreso.Location = new Point(129, 15);
            radioButton_progreso.Margin = new Padding(3, 4, 3, 4);
            radioButton_progreso.Name = "radioButton_progreso";
            radioButton_progreso.Size = new Size(109, 24);
            radioButton_progreso.TabIndex = 20;
            radioButton_progreso.TabStop = true;
            radioButton_progreso.Text = "En Progreso";
            radioButton_progreso.UseVisualStyleBackColor = true;
            radioButton_progreso.UseWaitCursor = true;
            // 
            // radioButton_finalizado
            // 
            radioButton_finalizado.AutoSize = true;
            radioButton_finalizado.Location = new Point(243, 15);
            radioButton_finalizado.Margin = new Padding(3, 4, 3, 4);
            radioButton_finalizado.Name = "radioButton_finalizado";
            radioButton_finalizado.Size = new Size(98, 24);
            radioButton_finalizado.TabIndex = 19;
            radioButton_finalizado.TabStop = true;
            radioButton_finalizado.Text = "Finalizado";
            radioButton_finalizado.UseVisualStyleBackColor = true;
            radioButton_finalizado.UseWaitCursor = true;
            // 
            // radioButton_pendiente
            // 
            radioButton_pendiente.AutoSize = true;
            radioButton_pendiente.Location = new Point(17, 15);
            radioButton_pendiente.Margin = new Padding(3, 4, 3, 4);
            radioButton_pendiente.Name = "radioButton_pendiente";
            radioButton_pendiente.Size = new Size(95, 24);
            radioButton_pendiente.TabIndex = 18;
            radioButton_pendiente.TabStop = true;
            radioButton_pendiente.Text = "Pendiente";
            radioButton_pendiente.UseVisualStyleBackColor = true;
            radioButton_pendiente.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 249);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 27);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label_fecha_creacion_pro);
            panel2.Controls.Add(label_descripcion_pro);
            panel2.Controls.Add(label_estado_pro);
            panel2.Controls.Add(label_horas_trabajadas_pro);
            panel2.Controls.Add(label_horas_totales_pro);
            panel2.Controls.Add(label_nombre_pro);
            panel2.Controls.Add(button_guardar_pro);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(763, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 373);
            panel2.TabIndex = 11;
            panel2.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox_empleado_asignado);
            panel4.Controls.Add(listBox_proyecto_tarea);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(date_fecha_inicio_tarea);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label_estado_tarea);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_area_tarea);
            panel4.Controls.Add(label_fecha_inicio_tarea);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label_gestion_tareas);
            panel4.Location = new Point(761, 445);
            panel4.Name = "panel4";
            panel4.Size = new Size(616, 443);
            panel4.TabIndex = 13;
            panel4.UseWaitCursor = true;
            panel4.Paint += panel2_Paint;
            // 
            // listBox_empleado_asignado
            // 
            listBox_empleado_asignado.FormattingEnabled = true;
            listBox_empleado_asignado.ItemHeight = 20;
            listBox_empleado_asignado.Location = new Point(266, 327);
            listBox_empleado_asignado.Margin = new Padding(3, 4, 3, 4);
            listBox_empleado_asignado.Name = "listBox_empleado_asignado";
            listBox_empleado_asignado.Size = new Size(337, 24);
            listBox_empleado_asignado.TabIndex = 25;
            listBox_empleado_asignado.UseWaitCursor = true;
            // 
            // listBox_proyecto_tarea
            // 
            listBox_proyecto_tarea.FormattingEnabled = true;
            listBox_proyecto_tarea.ItemHeight = 20;
            listBox_proyecto_tarea.Location = new Point(266, 284);
            listBox_proyecto_tarea.Margin = new Padding(3, 4, 3, 4);
            listBox_proyecto_tarea.Name = "listBox_proyecto_tarea";
            listBox_proyecto_tarea.Size = new Size(337, 24);
            listBox_proyecto_tarea.TabIndex = 24;
            listBox_proyecto_tarea.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 327);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 23;
            label3.Text = "Empleado Asignado";
            label3.UseWaitCursor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(radioButton_redes);
            panel7.Controls.Add(radioButton_hardware);
            panel7.Location = new Point(266, 205);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 55);
            panel7.TabIndex = 21;
            panel7.UseWaitCursor = true;
            // 
            // radioButton_redes
            // 
            radioButton_redes.AutoSize = true;
            radioButton_redes.Location = new Point(127, 15);
            radioButton_redes.Margin = new Padding(3, 4, 3, 4);
            radioButton_redes.Name = "radioButton_redes";
            radioButton_redes.Size = new Size(70, 24);
            radioButton_redes.TabIndex = 20;
            radioButton_redes.TabStop = true;
            radioButton_redes.Text = "Redes";
            radioButton_redes.UseVisualStyleBackColor = true;
            radioButton_redes.UseWaitCursor = true;
            // 
            // radioButton_hardware
            // 
            radioButton_hardware.AutoSize = true;
            radioButton_hardware.Location = new Point(17, 15);
            radioButton_hardware.Margin = new Padding(3, 4, 3, 4);
            radioButton_hardware.Name = "radioButton_hardware";
            radioButton_hardware.Size = new Size(95, 24);
            radioButton_hardware.TabIndex = 18;
            radioButton_hardware.TabStop = true;
            radioButton_hardware.Text = "Hardware";
            radioButton_hardware.UseVisualStyleBackColor = true;
            radioButton_hardware.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(266, 160);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(335, 27);
            numericUpDown1.TabIndex = 22;
            numericUpDown1.UseWaitCursor = true;
            // 
            // date_fecha_inicio_tarea
            // 
            date_fecha_inicio_tarea.Location = new Point(264, 51);
            date_fecha_inicio_tarea.Margin = new Padding(3, 4, 3, 4);
            date_fecha_inicio_tarea.Name = "date_fecha_inicio_tarea";
            date_fecha_inicio_tarea.Size = new Size(337, 27);
            date_fecha_inicio_tarea.TabIndex = 21;
            date_fecha_inicio_tarea.UseWaitCursor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(radioButton_progreso_tarea);
            panel5.Controls.Add(radioButton_finalizado_tarea);
            panel5.Controls.Add(radioButton_pendiente_tarea);
            panel5.Location = new Point(264, 91);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 55);
            panel5.TabIndex = 19;
            panel5.UseWaitCursor = true;
            // 
            // radioButton_progreso_tarea
            // 
            radioButton_progreso_tarea.AutoSize = true;
            radioButton_progreso_tarea.Location = new Point(129, 15);
            radioButton_progreso_tarea.Margin = new Padding(3, 4, 3, 4);
            radioButton_progreso_tarea.Name = "radioButton_progreso_tarea";
            radioButton_progreso_tarea.Size = new Size(109, 24);
            radioButton_progreso_tarea.TabIndex = 20;
            radioButton_progreso_tarea.TabStop = true;
            radioButton_progreso_tarea.Text = "En Progreso";
            radioButton_progreso_tarea.UseVisualStyleBackColor = true;
            radioButton_progreso_tarea.UseWaitCursor = true;
            // 
            // radioButton_finalizado_tarea
            // 
            radioButton_finalizado_tarea.AutoSize = true;
            radioButton_finalizado_tarea.Location = new Point(243, 15);
            radioButton_finalizado_tarea.Margin = new Padding(3, 4, 3, 4);
            radioButton_finalizado_tarea.Name = "radioButton_finalizado_tarea";
            radioButton_finalizado_tarea.Size = new Size(98, 24);
            radioButton_finalizado_tarea.TabIndex = 19;
            radioButton_finalizado_tarea.TabStop = true;
            radioButton_finalizado_tarea.Text = "Finalizado";
            radioButton_finalizado_tarea.UseVisualStyleBackColor = true;
            radioButton_finalizado_tarea.UseWaitCursor = true;
            // 
            // radioButton_pendiente_tarea
            // 
            radioButton_pendiente_tarea.AutoSize = true;
            radioButton_pendiente_tarea.Location = new Point(17, 15);
            radioButton_pendiente_tarea.Margin = new Padding(3, 4, 3, 4);
            radioButton_pendiente_tarea.Name = "radioButton_pendiente_tarea";
            radioButton_pendiente_tarea.Size = new Size(95, 24);
            radioButton_pendiente_tarea.TabIndex = 18;
            radioButton_pendiente_tarea.TabStop = true;
            radioButton_pendiente_tarea.Text = "Pendiente";
            radioButton_pendiente_tarea.UseVisualStyleBackColor = true;
            radioButton_pendiente_tarea.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 285);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 17;
            label2.Text = "Proyecto";
            label2.UseWaitCursor = true;
            // 
            // label_estado_tarea
            // 
            label_estado_tarea.AutoSize = true;
            label_estado_tarea.Location = new Point(47, 111);
            label_estado_tarea.Name = "label_estado_tarea";
            label_estado_tarea.Size = new Size(54, 20);
            label_estado_tarea.TabIndex = 15;
            label_estado_tarea.Text = "Estado";
            label_estado_tarea.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 163);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 14;
            label5.Text = "Horas";
            label5.UseWaitCursor = true;
            // 
            // label_area_tarea
            // 
            label_area_tarea.AutoSize = true;
            label_area_tarea.Location = new Point(49, 225);
            label_area_tarea.Name = "label_area_tarea";
            label_area_tarea.Size = new Size(40, 20);
            label_area_tarea.TabIndex = 13;
            label_area_tarea.Text = "Área";
            label_area_tarea.TextAlign = ContentAlignment.TopRight;
            label_area_tarea.UseWaitCursor = true;
            // 
            // label_fecha_inicio_tarea
            // 
            label_fecha_inicio_tarea.AutoSize = true;
            label_fecha_inicio_tarea.Location = new Point(47, 59);
            label_fecha_inicio_tarea.Name = "label_fecha_inicio_tarea";
            label_fecha_inicio_tarea.Size = new Size(87, 20);
            label_fecha_inicio_tarea.TabIndex = 12;
            label_fecha_inicio_tarea.Text = "Fecha Inicio";
            label_fecha_inicio_tarea.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(497, 395);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // label_gestion_tareas
            // 
            label_gestion_tareas.AutoSize = true;
            label_gestion_tareas.ForeColor = Color.CornflowerBlue;
            label_gestion_tareas.Location = new Point(17, 11);
            label_gestion_tareas.Name = "label_gestion_tareas";
            label_gestion_tareas.Size = new Size(125, 20);
            label_gestion_tareas.TabIndex = 5;
            label_gestion_tareas.Text = "Gestion de Tareas";
            label_gestion_tareas.UseWaitCursor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(listBox2);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button_editar_tarea);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(42, 443);
            panel6.Name = "panel6";
            panel6.Size = new Size(712, 445);
            panel6.TabIndex = 12;
            panel6.UseWaitCursor = true;
            panel6.Paint += panel6_Paint;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(3, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(707, 304);
            listBox2.TabIndex = 4;
            listBox2.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(618, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Lista";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button_editar_tarea
            // 
            button_editar_tarea.Location = new Point(33, 351);
            button_editar_tarea.Name = "button_editar_tarea";
            button_editar_tarea.Size = new Size(94, 29);
            button_editar_tarea.TabIndex = 1;
            button_editar_tarea.Text = "Editar";
            button_editar_tarea.UseVisualStyleBackColor = true;
            button_editar_tarea.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.Location = new Point(134, 351);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 929);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            HelpButton = true;
            Name = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_eliminar_pro;
        private Button button_editar_pro;
        private Button button_lista_pro;
        private ListBox listBox1;
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
        private Label label_estado_pro;
        private Label label_descripcion_pro;
        private Label label_fecha_creacion_pro;
        private Panel panel3;
        private RadioButton radioButton_progreso;
        private RadioButton radioButton_finalizado;
        private RadioButton radioButton_pendiente;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel4;
        private DateTimePicker date_fecha_inicio_tarea;
        private DateTimePicker dateTimePicker2;
        private Panel panel5;
        private RadioButton radioButton_progreso_tarea;
        private RadioButton radioButton_finalizado_tarea;
        private RadioButton radioButton_pendiente_tarea;
        private Label label2;
        private Label label_estado_tarea;
        private Label label5;
        private Label label_area_tarea;
        private Label label_fecha_inicio_tarea;
        private Button button1;
        private Label label_gestion_tareas;
        private Panel panel6;
        private ListBox listBox2;
        private Button button2;
        private Button button_editar_tarea;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Panel panel7;
        private RadioButton radioButton_redes;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton_hardware;
        private ListBox listBox_proyecto_tarea;
        private Label label3;
        private ListBox listBox_empleado_asignado;
    }
}
