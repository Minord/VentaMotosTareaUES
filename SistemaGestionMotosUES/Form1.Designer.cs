namespace SistemaGestionMotosUES
{
    partial class MainCatalogo
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
            this.iniciarSeccionButton = new System.Windows.Forms.Button();
            this.buttonConfUser = new System.Windows.Forms.Button();
            this.buttonNuevoProducto = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogo";
            // 
            // iniciarSeccionButton
            // 
            this.iniciarSeccionButton.BackColor = System.Drawing.Color.LightGreen;
            this.iniciarSeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarSeccionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSeccionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iniciarSeccionButton.Location = new System.Drawing.Point(491, 17);
            this.iniciarSeccionButton.Name = "iniciarSeccionButton";
            this.iniciarSeccionButton.Size = new System.Drawing.Size(116, 41);
            this.iniciarSeccionButton.TabIndex = 1;
            this.iniciarSeccionButton.Text = "Iniciar Seccion";
            this.iniciarSeccionButton.UseVisualStyleBackColor = false;
            this.iniciarSeccionButton.Click += new System.EventHandler(this.IniciarSeccionButton_Click);
            // 
            // buttonConfUser
            // 
            this.buttonConfUser.Location = new System.Drawing.Point(349, 17);
            this.buttonConfUser.Name = "buttonConfUser";
            this.buttonConfUser.Size = new System.Drawing.Size(116, 41);
            this.buttonConfUser.TabIndex = 2;
            this.buttonConfUser.Text = "Conf. de Usuario";
            this.buttonConfUser.UseVisualStyleBackColor = true;
            this.buttonConfUser.Click += new System.EventHandler(this.ButtonConfUser_Click);
            // 
            // buttonNuevoProducto
            // 
            this.buttonNuevoProducto.Location = new System.Drawing.Point(203, 17);
            this.buttonNuevoProducto.Name = "buttonNuevoProducto";
            this.buttonNuevoProducto.Size = new System.Drawing.Size(116, 41);
            this.buttonNuevoProducto.TabIndex = 3;
            this.buttonNuevoProducto.Text = "Nuevo Producto";
            this.buttonNuevoProducto.UseVisualStyleBackColor = true;
            this.buttonNuevoProducto.Click += new System.EventHandler(this.ButtonNuevoProducto_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.buttonBuscar);
            this.groupBoxFiltro.Controls.Add(this.label8);
            this.groupBoxFiltro.Controls.Add(this.label7);
            this.groupBoxFiltro.Controls.Add(this.textBoxMaxPrice);
            this.groupBoxFiltro.Controls.Add(this.textBoxMinPrice);
            this.groupBoxFiltro.Controls.Add(this.comboBoxTipo);
            this.groupBoxFiltro.Controls.Add(this.label6);
            this.groupBoxFiltro.Controls.Add(this.comboBoxColor);
            this.groupBoxFiltro.Controls.Add(this.label5);
            this.groupBoxFiltro.Controls.Add(this.label4);
            this.groupBoxFiltro.Controls.Add(this.comboBoxYear);
            this.groupBoxFiltro.Controls.Add(this.label3);
            this.groupBoxFiltro.Controls.Add(this.comboBoxMarca);
            this.groupBoxFiltro.Controls.Add(this.label2);
            this.groupBoxFiltro.Location = new System.Drawing.Point(16, 80);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(591, 126);
            this.groupBoxFiltro.TabIndex = 4;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro de Productos";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscar.Location = new System.Drawing.Point(469, 70);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(116, 41);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Bucar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "min";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(333, 74);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPrice.TabIndex = 12;
            this.textBoxMaxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMaxPrice_Validating);
            this.textBoxMaxPrice.Validated += new System.EventHandler(this.TextBoxMaxPrice_Validated);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(333, 44);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinPrice.TabIndex = 11;
            this.textBoxMinPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMinPrice_Validating);
            this.textBoxMinPrice.Validated += new System.EventHandler(this.TextBoxMinPrice_Validated);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(18, 90);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "tipo";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(145, 90);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "precio";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(145, 43);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "año";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(18, 43);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "marca";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(16, 219);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(591, 266);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonComprar.Location = new System.Drawing.Point(491, 491);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(116, 30);
            this.buttonComprar.TabIndex = 15;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = false;
            this.buttonComprar.Click += new System.EventHandler(this.ButtonComprar_Click);
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.ContainerControl = this;
            // 
            // MainCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 525);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.buttonNuevoProducto);
            this.Controls.Add(this.buttonConfUser);
            this.Controls.Add(this.iniciarSeccionButton);
            this.Controls.Add(this.label1);
            this.Name = "MainCatalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciarSeccionButton;
        private System.Windows.Forms.Button buttonConfUser;
        private System.Windows.Forms.Button buttonNuevoProducto;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
    }
}

