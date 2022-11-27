
namespace Taller_2_BD
{
    partial class CantidadVenta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPrecioUnitario = new System.Windows.Forms.TextBox();
            this.inputRUTProveedor = new System.Windows.Forms.ComboBox();
            this.inputIDProducto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputCantSuministrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESANDO CANTIDAD SUMINISTRADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(294, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUT PROVEEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(285, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID DEL PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(279, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO UNITARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(224, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "CANTIDAD SUMINISTRADA";
            // 
            // inputPrecioUnitario
            // 
            this.inputPrecioUnitario.Location = new System.Drawing.Point(341, 241);
            this.inputPrecioUnitario.Name = "inputPrecioUnitario";
            this.inputPrecioUnitario.Size = new System.Drawing.Size(121, 23);
            this.inputPrecioUnitario.TabIndex = 5;
            // 
            // inputRUTProveedor
            // 
            this.inputRUTProveedor.FormattingEnabled = true;
            this.inputRUTProveedor.Location = new System.Drawing.Point(341, 80);
            this.inputRUTProveedor.Name = "inputRUTProveedor";
            this.inputRUTProveedor.Size = new System.Drawing.Size(121, 23);
            this.inputRUTProveedor.TabIndex = 6;
            // 
            // inputIDProducto
            // 
            this.inputIDProducto.FormattingEnabled = true;
            this.inputIDProducto.Location = new System.Drawing.Point(341, 162);
            this.inputIDProducto.Name = "inputIDProducto";
            this.inputIDProducto.Size = new System.Drawing.Size(121, 23);
            this.inputIDProducto.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(324, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputCantSuministrada
            // 
            this.inputCantSuministrada.Location = new System.Drawing.Point(341, 321);
            this.inputCantSuministrada.Name = "inputCantSuministrada";
            this.inputCantSuministrada.Size = new System.Drawing.Size(121, 23);
            this.inputCantSuministrada.TabIndex = 10;
            // 
            // CantidadVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputCantSuministrada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputIDProducto);
            this.Controls.Add(this.inputRUTProveedor);
            this.Controls.Add(this.inputPrecioUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CantidadVenta";
            this.Text = "CantidadVenta";
            this.Load += new System.EventHandler(this.CantidadVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPrecioUnitario;
        private System.Windows.Forms.ComboBox inputRUTProveedor;
        private System.Windows.Forms.ComboBox inputIDProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputCantSuministrada;
    }
}