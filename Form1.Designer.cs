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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(764, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 309);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 527);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Coral;
            HelpButton = true;
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
