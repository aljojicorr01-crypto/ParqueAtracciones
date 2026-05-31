namespace ParqueAtracciones.Formulario
{
    partial class frmEditOperarios
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
            label12 = new Label();
            label10 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(170, 60);
            label12.Name = "label12";
            label12.Size = new Size(345, 28);
            label12.TabIndex = 63;
            label12.Text = "EDITOR DE VEHÍCULOS Y VAGONES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(233, 32);
            label10.Name = "label10";
            label10.Size = new Size(215, 28);
            label10.TabIndex = 62;
            label10.Text = "EDITOR DE OPERARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 303);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 50;
            label2.Text = "Averías Atendidas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 254);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 52;
            label3.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 207);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 54;
            label4.Text = "Codigo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 353);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 56;
            label5.Text = "Disponible";
            // 
            // button1
            // 
            button1.Location = new Point(472, 184);
            button1.Name = "button1";
            button1.Size = new Size(169, 92);
            button1.TabIndex = 59;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(472, 296);
            button2.Name = "button2";
            button2.Size = new Size(169, 92);
            button2.TabIndex = 60;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(245, 349);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(43, 24);
            checkBox1.TabIndex = 64;
            checkBox1.Text = "SI";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(297, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 66;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 126);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 65;
            label1.Text = "Tipo";
            // 
            // frmEditOperarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 444);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "frmEditOperarios";
            Text = "frmEditOperarios";
            Load += frmEditOperarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label12;
        public Label label10;
        public Label label2;
        public TextBox textBox1;
        public Label label3;
        public TextBox textBox2;
        public Label label4;
        public TextBox textBox3;
        public Label label5;
        public Button button1;
        public Button button2;
        private CheckBox checkBox1;
        public ComboBox comboBox1;
        public Label label1;
    }
}