
namespace Taller_2_BD
{
    partial class AddVendedor
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
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGANDO VENDEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(341, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(350, 111);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 23);
            this.inputNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(337, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALARIO";
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(350, 196);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(100, 23);
            this.inputSalario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(251, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "FECHA CONTRATACIÓN";
            // 
            // inputFecha
            // 
            this.inputFecha.Location = new System.Drawing.Point(300, 282);
            this.inputFecha.Name = "inputFecha";
            this.inputFecha.Size = new System.Drawing.Size(200, 23);
            this.inputFecha.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(324, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddVendedor";
            this.Text = "AddVendedor";
            this.Load += new System.EventHandler(this.AddVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker inputFecha;
        private System.Windows.Forms.Button button1;
    }
}