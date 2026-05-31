namespace ParqueAtracciones.Formulario
{
    partial class frmOperarios
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            label6 = new Label();
            button6 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 297);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(777, 161);
            button1.Name = "button1";
            button1.Size = new Size(160, 85);
            button1.TabIndex = 26;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 490);
            button2.Name = "button2";
            button2.Size = new Size(160, 85);
            button2.TabIndex = 27;
            button2.Text = "Liberar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(777, 373);
            button3.Name = "button3";
            button3.Size = new Size(160, 85);
            button3.TabIndex = 29;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(360, 490);
            button4.Name = "button4";
            button4.Size = new Size(160, 85);
            button4.TabIndex = 28;
            button4.Text = "Estado Operario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(573, 490);
            button5.Name = "button5";
            button5.Size = new Size(160, 85);
            button5.TabIndex = 30;
            button5.Text = "Regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(191, 43);
            label7.Name = "label7";
            label7.Size = new Size(470, 38);
            label7.TabIndex = 32;
            label7.Text = "CENTRAL RECEPTORA DE AVERÍAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(263, 15);
            label6.Name = "label6";
            label6.Size = new Size(308, 28);
            label6.TabIndex = 31;
            label6.Text = "GESTIÓN DE OPERARIOS Y CRA";
            // 
            // button6
            // 
            button6.Location = new Point(777, 267);
            button6.Name = "button6";
            button6.Size = new Size(160, 85);
            button6.TabIndex = 33;
            button6.Text = "Editar Operario";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(343, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 104);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 34;
            label1.Text = "Tipo";
            // 
            // frmOperarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 616);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "frmOperarios";
            Text = "frmOperarios";
            Load += frmOperarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private Label label6;
        private Button button6;
        private ComboBox comboBox1;
        private Label label1;
    }
}