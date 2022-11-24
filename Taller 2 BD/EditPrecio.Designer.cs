
namespace Taller_2_BD
{
    partial class EditPrecio
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputIDProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODIFICANDO PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID PRODUCTO";
            // 
            // inputIDProducto
            // 
            this.inputIDProducto.FormattingEnabled = true;
            this.inputIDProducto.Location = new System.Drawing.Point(342, 107);
            this.inputIDProducto.Name = "inputIDProducto";
            this.inputIDProducto.Size = new System.Drawing.Size(121, 23);
            this.inputIDProducto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(342, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(342, 189);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.ReadOnly = true;
            this.inputNombre.Size = new System.Drawing.Size(121, 23);
            this.inputNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(351, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRECIO";
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(342, 272);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(121, 23);
            this.inputPrecio.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(310, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputIDProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPrecio";
            this.Text = "EditPrecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputIDProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.Button button1;
    }
}