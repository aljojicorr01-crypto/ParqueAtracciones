namespace ParqueAtracciones.Formulario
{
    partial class frmAtracciones
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 119);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo Atraccion";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(522, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 282);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1034, 165);
            button1.Name = "button1";
            button1.Size = new Size(142, 79);
            button1.TabIndex = 3;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1034, 268);
            button2.Name = "button2";
            button2.Size = new Size(142, 79);
            button2.TabIndex = 4;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1034, 377);
            button3.Name = "button3";
            button3.Size = new Size(142, 79);
            button3.TabIndex = 5;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(278, 496);
            button4.Name = "button4";
            button4.Size = new Size(142, 80);
            button4.TabIndex = 6;
            button4.Text = "DETECTAR FALLO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(446, 496);
            button5.Name = "button5";
            button5.Size = new Size(142, 80);
            button5.TabIndex = 7;
            button5.Text = "INICAR ATRACCION";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(617, 496);
            button6.Name = "button6";
            button6.Size = new Size(142, 80);
            button6.TabIndex = 8;
            button6.Text = "VER ESTADO";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(791, 496);
            button7.Name = "button7";
            button7.Size = new Size(142, 80);
            button7.TabIndex = 9;
            button7.Text = "SALIR";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(450, 23);
            label6.Name = "label6";
            label6.Size = new Size(269, 28);
            label6.TabIndex = 18;
            label6.Text = "GESTIÓN DE ATRACCIONES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(329, 51);
            label7.Name = "label7";
            label7.Size = new Size(549, 38);
            label7.TabIndex = 19;
            label7.Text = "CONTROL DE NORIA Y MONTAÑA RUSA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 327);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 14;
            label4.Text = "Averias Pendientes";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 377);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 16;
            label5.Text = "Estado";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 27);
            textBox4.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 231);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 10;
            label2.Text = "Personas dentro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 278);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 12;
            label3.Text = "Capacidad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 13;
            // 
            // frmAtracciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 619);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "frmAtracciones";
            Text = "frmAtracciones";
            Load += frmAtracciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label6;
        private Label label7;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}