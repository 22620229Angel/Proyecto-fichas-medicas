namespace Practica2
{
    partial class Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Regresar1 = new System.Windows.Forms.Button();
            this.Ginecologia = new System.Windows.Forms.Button();
            this.TrabajoSocial = new System.Windows.Forms.Button();
            this.Consulta = new System.Windows.Forms.Button();
            this.Ultrasonido = new System.Windows.Forms.Button();
            this.Dental = new System.Windows.Forms.Button();
            this.Laboratorio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 110);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica2.Properties.Resources.descargar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione El Area";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.Regresar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 637);
            this.panel2.TabIndex = 1;
            // 
            // Regresar1
            // 
            this.Regresar1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar1.Location = new System.Drawing.Point(1, 570);
            this.Regresar1.Name = "Regresar1";
            this.Regresar1.Size = new System.Drawing.Size(187, 66);
            this.Regresar1.TabIndex = 0;
            this.Regresar1.Text = "Regresar";
            this.Regresar1.UseVisualStyleBackColor = true;
            this.Regresar1.Click += new System.EventHandler(this.Regresar1_Click);
            // 
            // Ginecologia
            // 
            this.Ginecologia.Location = new System.Drawing.Point(307, 245);
            this.Ginecologia.Name = "Ginecologia";
            this.Ginecologia.Size = new System.Drawing.Size(157, 75);
            this.Ginecologia.TabIndex = 2;
            this.Ginecologia.Text = "GINECOLOGIA";
            this.Ginecologia.UseVisualStyleBackColor = true;
            this.Ginecologia.Click += new System.EventHandler(this.Ginecologia_Click);
            // 
            // TrabajoSocial
            // 
            this.TrabajoSocial.Location = new System.Drawing.Point(513, 238);
            this.TrabajoSocial.Name = "TrabajoSocial";
            this.TrabajoSocial.Size = new System.Drawing.Size(153, 82);
            this.TrabajoSocial.TabIndex = 3;
            this.TrabajoSocial.Text = "TRABAJO SOCIAL";
            this.TrabajoSocial.UseVisualStyleBackColor = true;
            this.TrabajoSocial.Click += new System.EventHandler(this.TrabajoSocial_Click);
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(513, 375);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(153, 89);
            this.Consulta.TabIndex = 4;
            this.Consulta.Text = "CONSULTA GENERAL";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // Ultrasonido
            // 
            this.Ultrasonido.Location = new System.Drawing.Point(307, 375);
            this.Ultrasonido.Name = "Ultrasonido";
            this.Ultrasonido.Size = new System.Drawing.Size(157, 89);
            this.Ultrasonido.TabIndex = 5;
            this.Ultrasonido.Text = "ULTRASONIDO";
            this.Ultrasonido.UseVisualStyleBackColor = true;
            this.Ultrasonido.Click += new System.EventHandler(this.Ultrasonido_Click);
            // 
            // Dental
            // 
            this.Dental.Location = new System.Drawing.Point(721, 241);
            this.Dental.Name = "Dental";
            this.Dental.Size = new System.Drawing.Size(156, 79);
            this.Dental.TabIndex = 6;
            this.Dental.Text = "DENTAL";
            this.Dental.UseVisualStyleBackColor = true;
            this.Dental.Click += new System.EventHandler(this.Dental_Click);
            // 
            // Laboratorio
            // 
            this.Laboratorio.Location = new System.Drawing.Point(712, 375);
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Size = new System.Drawing.Size(165, 89);
            this.Laboratorio.TabIndex = 7;
            this.Laboratorio.Text = "LABORATORIO";
            this.Laboratorio.UseVisualStyleBackColor = true;
            this.Laboratorio.Click += new System.EventHandler(this.Laboratorio_Click);
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 637);
            this.Controls.Add(this.Laboratorio);
            this.Controls.Add(this.Dental);
            this.Controls.Add(this.Ultrasonido);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.TrabajoSocial);
            this.Controls.Add(this.Ginecologia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Area";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Regresar1;
        private System.Windows.Forms.Button Ginecologia;
        private System.Windows.Forms.Button TrabajoSocial;
        private System.Windows.Forms.Button Consulta;
        private System.Windows.Forms.Button Ultrasonido;
        private System.Windows.Forms.Button Dental;
        private System.Windows.Forms.Button Laboratorio;
    }
}