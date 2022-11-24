
namespace Taller_2_BD
{
    partial class EditEstado
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputRUT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "INHABILITANDO CLIENTE";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(340, 199);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.ReadOnly = true;
            this.inputNombre.Size = new System.Drawing.Size(121, 23);
            this.inputNombre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(340, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "NOMBRE";
            // 
            // inputRUT
            // 
            this.inputRUT.FormattingEnabled = true;
            this.inputRUT.Location = new System.Drawing.Point(340, 110);
            this.inputRUT.Name = "inputRUT";
            this.inputRUT.Size = new System.Drawing.Size(121, 23);
            this.inputRUT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(312, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "RUT CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(342, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "ESTADO";
            // 
            // inputEstado
            // 
            this.inputEstado.FormattingEnabled = true;
            this.inputEstado.Location = new System.Drawing.Point(340, 286);
            this.inputEstado.Name = "inputEstado";
            this.inputEstado.Size = new System.Drawing.Size(121, 23);
            this.inputEstado.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(310, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputRUT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditEstado";
            this.Text = "EditEstado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputRUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputEstado;
        private System.Windows.Forms.Button button1;
    }
}