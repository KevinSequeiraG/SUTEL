
namespace SUTEL
{
    partial class Form1
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
            this.grbProveedor = new System.Windows.Forms.GroupBox();
            this.rdbMovistar = new System.Windows.Forms.RadioButton();
            this.rdbClaro = new System.Windows.Forms.RadioButton();
            this.rdbKolbi = new System.Windows.Forms.RadioButton();
            this.grbDatosTelefono = new System.Windows.Forms.GroupBox();
            this.nudMins = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.grbTelefonos = new System.Windows.Forms.GroupBox();
            this.dgrTelefonos = new System.Windows.Forms.DataGridView();
            this.clmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProveedor.SuspendLayout();
            this.grbDatosTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).BeginInit();
            this.grbTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProveedor
            // 
            this.grbProveedor.Controls.Add(this.rdbMovistar);
            this.grbProveedor.Controls.Add(this.rdbClaro);
            this.grbProveedor.Controls.Add(this.rdbKolbi);
            this.grbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProveedor.Location = new System.Drawing.Point(20, 22);
            this.grbProveedor.Name = "grbProveedor";
            this.grbProveedor.Size = new System.Drawing.Size(487, 75);
            this.grbProveedor.TabIndex = 0;
            this.grbProveedor.TabStop = false;
            this.grbProveedor.Text = "Proveedor";
            // 
            // rdbMovistar
            // 
            this.rdbMovistar.AutoSize = true;
            this.rdbMovistar.Location = new System.Drawing.Point(381, 32);
            this.rdbMovistar.Name = "rdbMovistar";
            this.rdbMovistar.Size = new System.Drawing.Size(85, 20);
            this.rdbMovistar.TabIndex = 2;
            this.rdbMovistar.TabStop = true;
            this.rdbMovistar.Text = "Movistar";
            this.rdbMovistar.UseVisualStyleBackColor = true;
            // 
            // rdbClaro
            // 
            this.rdbClaro.AutoSize = true;
            this.rdbClaro.Location = new System.Drawing.Point(221, 32);
            this.rdbClaro.Name = "rdbClaro";
            this.rdbClaro.Size = new System.Drawing.Size(63, 20);
            this.rdbClaro.TabIndex = 1;
            this.rdbClaro.TabStop = true;
            this.rdbClaro.Text = "Claro";
            this.rdbClaro.UseVisualStyleBackColor = true;
            // 
            // rdbKolbi
            // 
            this.rdbKolbi.AutoSize = true;
            this.rdbKolbi.Location = new System.Drawing.Point(20, 32);
            this.rdbKolbi.Name = "rdbKolbi";
            this.rdbKolbi.Size = new System.Drawing.Size(61, 20);
            this.rdbKolbi.TabIndex = 0;
            this.rdbKolbi.TabStop = true;
            this.rdbKolbi.Text = "Kolbi";
            this.rdbKolbi.UseVisualStyleBackColor = true;
            // 
            // grbDatosTelefono
            // 
            this.grbDatosTelefono.Controls.Add(this.nudMins);
            this.grbDatosTelefono.Controls.Add(this.btnAgregar);
            this.grbDatosTelefono.Controls.Add(this.btnNuevo);
            this.grbDatosTelefono.Controls.Add(this.lblMins);
            this.grbDatosTelefono.Controls.Add(this.lblNumero);
            this.grbDatosTelefono.Controls.Add(this.txtNumero);
            this.grbDatosTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosTelefono.Location = new System.Drawing.Point(20, 122);
            this.grbDatosTelefono.Name = "grbDatosTelefono";
            this.grbDatosTelefono.Size = new System.Drawing.Size(487, 148);
            this.grbDatosTelefono.TabIndex = 1;
            this.grbDatosTelefono.TabStop = false;
            this.grbDatosTelefono.Text = "Datos del teléfono";
            // 
            // nudMins
            // 
            this.nudMins.Location = new System.Drawing.Point(367, 41);
            this.nudMins.Name = "nudMins";
            this.nudMins.Size = new System.Drawing.Size(88, 22);
            this.nudMins.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(278, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(153, 84);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 36);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(299, 43);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(61, 16);
            this.lblMins.TabIndex = 2;
            this.lblMins.Text = "Minutos";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(49, 44);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(117, 41);
            this.txtNumero.Mask = "0000-0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(77, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // grbTelefonos
            // 
            this.grbTelefonos.Controls.Add(this.dgrTelefonos);
            this.grbTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTelefonos.Location = new System.Drawing.Point(20, 292);
            this.grbTelefonos.Name = "grbTelefonos";
            this.grbTelefonos.Size = new System.Drawing.Size(487, 186);
            this.grbTelefonos.TabIndex = 2;
            this.grbTelefonos.TabStop = false;
            this.grbTelefonos.Text = "Teléfonos";
            // 
            // dgrTelefonos
            // 
            this.dgrTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProveedor,
            this.clmNumero,
            this.clmMinutos,
            this.clmTotal});
            this.dgrTelefonos.Location = new System.Drawing.Point(21, 26);
            this.dgrTelefonos.Name = "dgrTelefonos";
            this.dgrTelefonos.Size = new System.Drawing.Size(445, 140);
            this.dgrTelefonos.TabIndex = 0;
            // 
            // clmProveedor
            // 
            this.clmProveedor.HeaderText = "Proveedor";
            this.clmProveedor.Name = "clmProveedor";
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.Name = "clmNumero";
            // 
            // clmMinutos
            // 
            this.clmMinutos.HeaderText = "Minutos";
            this.clmMinutos.Name = "clmMinutos";
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 503);
            this.Controls.Add(this.grbTelefonos);
            this.Controls.Add(this.grbDatosTelefono);
            this.Controls.Add(this.grbProveedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbProveedor.ResumeLayout(false);
            this.grbProveedor.PerformLayout();
            this.grbDatosTelefono.ResumeLayout(false);
            this.grbDatosTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).EndInit();
            this.grbTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTelefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProveedor;
        private System.Windows.Forms.RadioButton rdbMovistar;
        private System.Windows.Forms.RadioButton rdbClaro;
        private System.Windows.Forms.RadioButton rdbKolbi;
        private System.Windows.Forms.GroupBox grbDatosTelefono;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbTelefonos;
        private System.Windows.Forms.DataGridView dgrTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMinutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.NumericUpDown nudMins;
    }
}

