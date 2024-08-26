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
            listBox1 = new ListBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            panel2 = new Panel();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(173, 363);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(45, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 312);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(707, 224);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(664, 363);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Lista";
            button3.UseVisualStyleBackColor = true;
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
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(17, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 27);
            textBox5.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(668, 36);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 280);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox3);
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
            panel4.Location = new Point(666, 334);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(539, 280);
            panel4.TabIndex = 13;
            panel4.UseWaitCursor = true;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(radioButton_progreso_tarea);
            panel5.Controls.Add(radioButton_finalizado_tarea);
            panel5.Controls.Add(radioButton_pendiente_tarea);
            panel5.Location = new Point(231, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 41);
            panel5.TabIndex = 19;
            panel5.UseWaitCursor = true;
            // 
            // radioButton_progreso_tarea
            // 
            radioButton_progreso_tarea.AutoSize = true;
            radioButton_progreso_tarea.Location = new Point(113, 11);
            radioButton_progreso_tarea.Name = "radioButton_progreso_tarea";
            radioButton_progreso_tarea.Size = new Size(88, 19);
            radioButton_progreso_tarea.TabIndex = 20;
            radioButton_progreso_tarea.TabStop = true;
            radioButton_progreso_tarea.Text = "En Progreso";
            radioButton_progreso_tarea.UseVisualStyleBackColor = true;
            radioButton_progreso_tarea.UseWaitCursor = true;
            // 
            // radioButton_finalizado_tarea
            // 
            radioButton_finalizado_tarea.AutoSize = true;
            radioButton_finalizado_tarea.Location = new Point(213, 11);
            radioButton_finalizado_tarea.Name = "radioButton_finalizado_tarea";
            radioButton_finalizado_tarea.Size = new Size(78, 19);
            radioButton_finalizado_tarea.TabIndex = 19;
            radioButton_finalizado_tarea.TabStop = true;
            radioButton_finalizado_tarea.Text = "Finalizado";
            radioButton_finalizado_tarea.UseVisualStyleBackColor = true;
            radioButton_finalizado_tarea.UseWaitCursor = true;
            // 
            // radioButton_pendiente_tarea
            // 
            radioButton_pendiente_tarea.AutoSize = true;
            radioButton_pendiente_tarea.Location = new Point(15, 11);
            radioButton_pendiente_tarea.Name = "radioButton_pendiente_tarea";
            radioButton_pendiente_tarea.Size = new Size(78, 19);
            radioButton_pendiente_tarea.TabIndex = 18;
            radioButton_pendiente_tarea.TabStop = true;
            radioButton_pendiente_tarea.Text = "Pendiente";
            radioButton_pendiente_tarea.UseVisualStyleBackColor = true;
            radioButton_pendiente_tarea.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 214);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 17;
            label2.Text = "Fecha Creacion";
            label2.UseWaitCursor = true;
            // 
            // label_estado_tarea
            // 
            label_estado_tarea.AutoSize = true;
            label_estado_tarea.Location = new Point(41, 83);
            label_estado_tarea.Name = "label_estado_tarea";
            label_estado_tarea.Size = new Size(42, 15);
            label_estado_tarea.TabIndex = 15;
            label_estado_tarea.Text = "Estado";
            label_estado_tarea.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 122);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "Horas";
            label5.UseWaitCursor = true;
            // 
            // label_area_tarea
            // 
            label_area_tarea.AutoSize = true;
            label_area_tarea.Location = new Point(43, 169);
            label_area_tarea.Name = "label_area_tarea";
            label_area_tarea.Size = new Size(31, 15);
            label_area_tarea.TabIndex = 13;
            label_area_tarea.Text = "Área";
            label_area_tarea.TextAlign = ContentAlignment.TopRight;
            label_area_tarea.UseWaitCursor = true;
            // 
            // label_fecha_inicio_tarea
            // 
            label_fecha_inicio_tarea.AutoSize = true;
            label_fecha_inicio_tarea.Location = new Point(41, 44);
            label_fecha_inicio_tarea.Name = "label_fecha_inicio_tarea";
            label_fecha_inicio_tarea.Size = new Size(70, 15);
            label_fecha_inicio_tarea.TabIndex = 12;
            label_fecha_inicio_tarea.Text = "Fecha Inicio";
            label_fecha_inicio_tarea.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(433, 238);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 22);
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
            panel6.Controls.Add(listBox2);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(37, 332);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(623, 282);
            panel6.TabIndex = 12;
            panel6.UseWaitCursor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 2);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(619, 169);
            listBox2.TabIndex = 4;
            listBox2.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(539, 184);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 4;
            button2.Text = "Lista";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Location = new Point(27, 184);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 1;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.Location = new Point(17, 242);
            button4.Name = "button4";
            button4.Size = new Size(322, 29);
            button4.TabIndex = 11;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            numericUpDown1.Location = new Point(233, 120);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(293, 23);
            numericUpDown1.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.Controls.Add(this.radioButton_redes);
            panel7.Controls.Add(radioButton_hardware);
            panel7.Location = new Point(233, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 41);
            panel7.TabIndex = 21;
            panel7.UseWaitCursor = true;
            // 
            // radioButton_redes
            // 
            this.radioButton_redes.AutoSize = true;
            this.radioButton_redes.Location = new Point(111, 11);
            this.radioButton_redes.Name = "radioButton_redes";
            this.radioButton_redes.Size = new Size(56, 19);
            this.radioButton_redes.TabIndex = 20;
            this.radioButton_redes.TabStop = true;
            this.radioButton_redes.Text = "Redes";
            this.radioButton_redes.UseVisualStyleBackColor = true;
            this.radioButton_redes.UseWaitCursor = true;
            // 
            // radioButton_hardware
            // 
            radioButton_hardware.AutoSize = true;
            radioButton_hardware.Location = new Point(15, 11);
            radioButton_hardware.Name = "radioButton_hardware";
            radioButton_hardware.Size = new Size(76, 19);
            radioButton_hardware.TabIndex = 18;
            radioButton_hardware.TabStop = true;
            radioButton_hardware.Text = "Hardware";
            radioButton_hardware.UseVisualStyleBackColor = true;
            radioButton_hardware.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 245);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 23;
            label3.Text = "Fecha Creacion";
            label3.UseWaitCursor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(233, 213);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(295, 19);
            listBox3.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 635);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel1;
        private ListBox listBox1;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel2;
        private Button button4;
    }
}
