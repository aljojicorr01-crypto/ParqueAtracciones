namespace ParqueAtracciones.Formulario
{
    partial class frmPrincipal
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(569, 253);
            button3.Name = "button3";
            button3.Size = new Size(187, 98);
            button3.TabIndex = 7;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 253);
            button2.Name = "button2";
            button2.Size = new Size(187, 98);
            button2.TabIndex = 6;
            button2.Text = "GESTIONAR OPERACIORIOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 253);
            button1.Name = "button1";
            button1.Size = new Size(187, 98);
            button1.TabIndex = 5;
            button1.Text = "GESTION DE ATRACCIONES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 77);
            label1.Name = "label1";
            label1.Size = new Size(426, 31);
            label1.TabIndex = 4;
            label1.Text = "SISTEMA DE PARQUES DE ATRACCIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 108);
            label2.Name = "label2";
            label2.Size = new Size(798, 46);
            label2.TabIndex = 8;
            label2.Text = "PARQUE DE ATRACCIONES - DIVERTIMENTO S.A.";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}