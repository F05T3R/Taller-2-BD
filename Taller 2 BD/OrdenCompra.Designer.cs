
namespace Taller_2_BD
{
    partial class OrdenCompra
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
            this.inputFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputMontoFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputRUTCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputRUTVendedor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREANDO ORDEN DE COMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(281, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA DE COMPRA";
            // 
            // inputFechaCompra
            // 
            this.inputFechaCompra.Location = new System.Drawing.Point(300, 84);
            this.inputFechaCompra.Name = "inputFechaCompra";
            this.inputFechaCompra.Size = new System.Drawing.Size(200, 23);
            this.inputFechaCompra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(317, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCUENTO";
            // 
            // inputDescuento
            // 
            this.inputDescuento.Location = new System.Drawing.Point(349, 156);
            this.inputDescuento.Name = "inputDescuento";
            this.inputDescuento.Size = new System.Drawing.Size(100, 23);
            this.inputDescuento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(300, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "MONTO FINAL";
            // 
            // inputMontoFinal
            // 
            this.inputMontoFinal.Location = new System.Drawing.Point(346, 231);
            this.inputMontoFinal.Name = "inputMontoFinal";
            this.inputMontoFinal.ReadOnly = true;
            this.inputMontoFinal.Size = new System.Drawing.Size(100, 23);
            this.inputMontoFinal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(303, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "RUT CLIENTE";
            // 
            // inputRUTCliente
            // 
            this.inputRUTCliente.FormattingEnabled = true;
            this.inputRUTCliente.Location = new System.Drawing.Point(346, 307);
            this.inputRUTCliente.Name = "inputRUTCliente";
            this.inputRUTCliente.Size = new System.Drawing.Size(100, 23);
            this.inputRUTCliente.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(300, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "RUT VENDEDOR";
            // 
            // inputRUTVendedor
            // 
            this.inputRUTVendedor.FormattingEnabled = true;
            this.inputRUTVendedor.Location = new System.Drawing.Point(348, 379);
            this.inputRUTVendedor.Name = "inputRUTVendedor";
            this.inputRUTVendedor.Size = new System.Drawing.Size(100, 23);
            this.inputRUTVendedor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(623, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputRUTVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputRUTCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputMontoFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputFechaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdenCompra";
            this.Text = "OrdenCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputFechaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputMontoFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputRUTCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputRUTVendedor;
        private System.Windows.Forms.Button button1;
    }
}