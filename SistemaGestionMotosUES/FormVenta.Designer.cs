namespace SistemaGestionMotosUES
{
    partial class FormVenta
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
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVendedor = new System.Windows.Forms.TextBox();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewRecibo = new System.Windows.Forms.DataGridView();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre cliente";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(130, 52);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(231, 20);
            this.textBoxNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre vendedor";
            // 
            // textBoxVendedor
            // 
            this.textBoxVendedor.Location = new System.Drawing.Point(130, 90);
            this.textBoxVendedor.Name = "textBoxVendedor";
            this.textBoxVendedor.Size = new System.Drawing.Size(231, 20);
            this.textBoxVendedor.TabIndex = 3;
            // 
            // textBoxPago
            // 
            this.textBoxPago.Location = new System.Drawing.Point(130, 126);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(231, 20);
            this.textBoxPago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "metodo pago";
            // 
            // textBoxNumTarjeta
            // 
            this.textBoxNumTarjeta.Location = new System.Drawing.Point(130, 165);
            this.textBoxNumTarjeta.Name = "textBoxNumTarjeta";
            this.textBoxNumTarjeta.Size = new System.Drawing.Size(231, 20);
            this.textBoxNumTarjeta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "num tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridViewRecibo
            // 
            this.dataGridViewRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecibo.Location = new System.Drawing.Point(24, 240);
            this.dataGridViewRecibo.Name = "dataGridViewRecibo";
            this.dataGridViewRecibo.Size = new System.Drawing.Size(346, 164);
            this.dataGridViewRecibo.TabIndex = 11;
            // 
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonComprar.Location = new System.Drawing.Point(343, 433);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 12;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(255, 433);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 468);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.dataGridViewRecibo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVendedor;
        private System.Windows.Forms.TextBox textBoxPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewRecibo;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}