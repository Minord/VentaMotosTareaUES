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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxPrecioMoto = new System.Windows.Forms.TextBox();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombreMoto = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxNombreVendedor = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.textBoxNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNombreCliente_Validating);
            this.textBoxNombreCliente.Validated += new System.EventHandler(this.TextBoxNombreCliente_Validated);
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
            this.textBoxNumTarjeta.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumTarjeta_Validating);
            this.textBoxNumTarjeta.Validated += new System.EventHandler(this.TextBoxNumTarjeta_Validated);
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
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonComprar.Location = new System.Drawing.Point(331, 360);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 12;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = false;
            this.buttonComprar.Click += new System.EventHandler(this.ButtonComprar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(236, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // textBoxPrecioMoto
            // 
            this.textBoxPrecioMoto.Location = new System.Drawing.Point(240, 261);
            this.textBoxPrecioMoto.Name = "textBoxPrecioMoto";
            this.textBoxPrecioMoto.ReadOnly = true;
            this.textBoxPrecioMoto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioMoto.TabIndex = 14;
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Location = new System.Drawing.Point(240, 287);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.ReadOnly = true;
            this.textBoxIVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxIVA.TabIndex = 15;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(240, 313);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio Moto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nombre Moto";
            // 
            // textBoxNombreMoto
            // 
            this.textBoxNombreMoto.Location = new System.Drawing.Point(130, 235);
            this.textBoxNombreMoto.Name = "textBoxNombreMoto";
            this.textBoxNombreMoto.ReadOnly = true;
            this.textBoxNombreMoto.Size = new System.Drawing.Size(210, 20);
            this.textBoxNombreMoto.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.comboBox2.Location = new System.Drawing.Point(130, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // textBoxNombreVendedor
            // 
            this.textBoxNombreVendedor.Location = new System.Drawing.Point(130, 90);
            this.textBoxNombreVendedor.Name = "textBoxNombreVendedor";
            this.textBoxNombreVendedor.ReadOnly = true;
            this.textBoxNombreVendedor.Size = new System.Drawing.Size(231, 20);
            this.textBoxNombreVendedor.TabIndex = 24;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 395);
            this.Controls.Add(this.textBoxNombreVendedor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNombreMoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.textBoxPrecioMoto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxPrecioMoto;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombreMoto;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxNombreVendedor;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}