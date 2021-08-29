
namespace Tarea4
{
    partial class AñadirPregunta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxRespuetaCorrecta = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxRespuetaCorrecta);
            this.panel1.Controls.Add(this.comboBoxMateria);
            this.panel1.Controls.Add(this.txtRespuesta);
            this.panel1.Controls.Add(this.txtR3);
            this.panel1.Controls.Add(this.txtR2);
            this.panel1.Controls.Add(this.txtRespuesta1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 444);
            this.panel1.TabIndex = 0;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta1.ForeColor = System.Drawing.Color.Black;
            this.txtRespuesta1.Location = new System.Drawing.Point(56, 243);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(126, 13);
            this.txtRespuesta1.TabIndex = 3;
            // 
            // txtR2
            // 
            this.txtR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtR2.ForeColor = System.Drawing.Color.Black;
            this.txtR2.Location = new System.Drawing.Point(224, 243);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(126, 13);
            this.txtR2.TabIndex = 4;
            // 
            // txtR3
            // 
            this.txtR3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtR3.ForeColor = System.Drawing.Color.Black;
            this.txtR3.Location = new System.Drawing.Point(397, 243);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(126, 13);
            this.txtR3.TabIndex = 5;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.ForeColor = System.Drawing.Color.Black;
            this.txtRespuesta.Location = new System.Drawing.Point(152, 119);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(273, 13);
            this.txtRespuesta.TabIndex = 6;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Items.AddRange(new object[] {
            "Matematicas",
            "Informatica",
            "Historia"});
            this.comboBoxMateria.Location = new System.Drawing.Point(224, 169);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateria.TabIndex = 7;
            // 
            // comboBoxRespuetaCorrecta
            // 
            this.comboBoxRespuetaCorrecta.FormattingEnabled = true;
            this.comboBoxRespuetaCorrecta.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxRespuetaCorrecta.Location = new System.Drawing.Point(229, 306);
            this.comboBoxRespuetaCorrecta.Name = "comboBoxRespuetaCorrecta";
            this.comboBoxRespuetaCorrecta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRespuetaCorrecta.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea4.Properties.Resources.Grupo1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 345);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Tarea4.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(240, 385);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 50);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Tarea4.Properties.Resources.Agregar;
            this.btnAgregar.Location = new System.Drawing.Point(427, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TabStop = false;
            // 
            // AñadirPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AñadirPregunta";
            this.Text = "AñadirPregunta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.ComboBox comboBoxRespuetaCorrecta;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
    }
}