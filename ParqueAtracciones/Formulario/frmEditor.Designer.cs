namespace ParqueAtracciones.Formulario
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            label10 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 121);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(288, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 328);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 27);
            textBox4.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 335);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 32;
            label5.Text = "Capacidad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 30;
            label4.Text = "Codigo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 236);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 28;
            label3.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 285);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 26;
            label2.Text = "Zona";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 387);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 36;
            label7.Text = "Personas Dentro";
            // 
            // button1
            // 
            button1.Location = new Point(489, 166);
            button1.Name = "button1";
            button1.Size = new Size(169, 92);
            button1.TabIndex = 42;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(489, 319);
            button2.Name = "button2";
            button2.Size = new Size(169, 92);
            button2.TabIndex = 43;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(253, 19);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(238, 39);
            label10.Name = "label10";
            label10.Size = new Size(237, 28);
            label10.TabIndex = 45;
            label10.Text = "EDITOR DE ATRACCIONES";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(222, 67);
            label12.Name = "label12";
            label12.Size = new Size(260, 28);
            label12.TabIndex = 46;
            label12.Text = "NORIA / MONTAÑA RUSA";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 380);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 27);
            textBox5.TabIndex = 47;
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 456);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "frmEditor";
            Text = "frmEditor";
            Load += frmEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public ComboBox comboBox1;
        public TextBox textBox4;
        public Label label5;
        public TextBox textBox3;
        public Label label4;
        public TextBox textBox2;
        public Label label3;
        public TextBox textBox1;
        public Label label2;
        public Label label7;
        public Button button1;
        public Button button2;
        public Label label11;
        public Label label10;
        public Label label12;
        public TextBox textBox5;
    }
}