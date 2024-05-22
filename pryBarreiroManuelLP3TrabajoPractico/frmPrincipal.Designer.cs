namespace pryBarreiroManuelLP3TrabajoPractico
{
    partial class frmPrincipal
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
            this.cmdReserva = new System.Windows.Forms.Button();
            this.rbtQuenaken = new System.Windows.Forms.RadioButton();
            this.rbtOnas = new System.Windows.Forms.RadioButton();
            this.rbtTobas = new System.Windows.Forms.RadioButton();
            this.gbxLocal = new System.Windows.Forms.GroupBox();
            this.gbxFila = new System.Windows.Forms.GroupBox();
            this.cmbFila = new System.Windows.Forms.ComboBox();
            this.gbxAsiento = new System.Windows.Forms.GroupBox();
            this.cmbAsiento = new System.Windows.Forms.ComboBox();
            this.gbxZonas = new System.Windows.Forms.GroupBox();
            this.rbtZonaVerde = new System.Windows.Forms.RadioButton();
            this.rbtZonaAzul = new System.Windows.Forms.RadioButton();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.gbxLocal.SuspendLayout();
            this.gbxFila.SuspendLayout();
            this.gbxAsiento.SuspendLayout();
            this.gbxZonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReserva
            // 
            this.cmdReserva.Location = new System.Drawing.Point(198, 146);
            this.cmdReserva.Name = "cmdReserva";
            this.cmdReserva.Size = new System.Drawing.Size(91, 30);
            this.cmdReserva.TabIndex = 0;
            this.cmdReserva.Text = "Reservar";
            this.cmdReserva.UseVisualStyleBackColor = true;
            this.cmdReserva.Click += new System.EventHandler(this.cmdReserva_Click);
            // 
            // rbtQuenaken
            // 
            this.rbtQuenaken.AutoSize = true;
            this.rbtQuenaken.Location = new System.Drawing.Point(6, 22);
            this.rbtQuenaken.Name = "rbtQuenaken";
            this.rbtQuenaken.Size = new System.Drawing.Size(79, 19);
            this.rbtQuenaken.TabIndex = 1;
            this.rbtQuenaken.Text = "Quenaken";
            this.rbtQuenaken.UseVisualStyleBackColor = true;
            this.rbtQuenaken.CheckedChanged += new System.EventHandler(this.rbtQuenaken_CheckedChanged);
            // 
            // rbtOnas
            // 
            this.rbtOnas.AutoSize = true;
            this.rbtOnas.Location = new System.Drawing.Point(6, 47);
            this.rbtOnas.Name = "rbtOnas";
            this.rbtOnas.Size = new System.Drawing.Size(52, 19);
            this.rbtOnas.TabIndex = 2;
            this.rbtOnas.Text = "Onas";
            this.rbtOnas.UseVisualStyleBackColor = true;
            this.rbtOnas.CheckedChanged += new System.EventHandler(this.rbtOnas_CheckedChanged);
            // 
            // rbtTobas
            // 
            this.rbtTobas.AutoSize = true;
            this.rbtTobas.Location = new System.Drawing.Point(6, 72);
            this.rbtTobas.Name = "rbtTobas";
            this.rbtTobas.Size = new System.Drawing.Size(55, 19);
            this.rbtTobas.TabIndex = 3;
            this.rbtTobas.Text = "Tobas";
            this.rbtTobas.UseVisualStyleBackColor = true;
            this.rbtTobas.CheckedChanged += new System.EventHandler(this.rbtTobas_CheckedChanged);
            // 
            // gbxLocal
            // 
            this.gbxLocal.Controls.Add(this.rbtQuenaken);
            this.gbxLocal.Controls.Add(this.rbtTobas);
            this.gbxLocal.Controls.Add(this.rbtOnas);
            this.gbxLocal.Location = new System.Drawing.Point(12, 12);
            this.gbxLocal.Name = "gbxLocal";
            this.gbxLocal.Size = new System.Drawing.Size(93, 110);
            this.gbxLocal.TabIndex = 4;
            this.gbxLocal.TabStop = false;
            this.gbxLocal.Text = "Local";
            // 
            // gbxFila
            // 
            this.gbxFila.Controls.Add(this.cmbFila);
            this.gbxFila.Location = new System.Drawing.Point(198, 12);
            this.gbxFila.Name = "gbxFila";
            this.gbxFila.Size = new System.Drawing.Size(91, 51);
            this.gbxFila.TabIndex = 5;
            this.gbxFila.TabStop = false;
            this.gbxFila.Text = "Fila";
            // 
            // cmbFila
            // 
            this.cmbFila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFila.FormattingEnabled = true;
            this.cmbFila.Location = new System.Drawing.Point(6, 22);
            this.cmbFila.Name = "cmbFila";
            this.cmbFila.Size = new System.Drawing.Size(74, 23);
            this.cmbFila.TabIndex = 0;
            this.cmbFila.SelectedIndexChanged += new System.EventHandler(this.cmbFila_SelectedIndexChanged);
            // 
            // gbxAsiento
            // 
            this.gbxAsiento.Controls.Add(this.cmbAsiento);
            this.gbxAsiento.Location = new System.Drawing.Point(198, 69);
            this.gbxAsiento.Name = "gbxAsiento";
            this.gbxAsiento.Size = new System.Drawing.Size(91, 53);
            this.gbxAsiento.TabIndex = 6;
            this.gbxAsiento.TabStop = false;
            this.gbxAsiento.Text = "Asiento";
            // 
            // cmbAsiento
            // 
            this.cmbAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsiento.FormattingEnabled = true;
            this.cmbAsiento.Location = new System.Drawing.Point(6, 22);
            this.cmbAsiento.Name = "cmbAsiento";
            this.cmbAsiento.Size = new System.Drawing.Size(74, 23);
            this.cmbAsiento.TabIndex = 1;
            // 
            // gbxZonas
            // 
            this.gbxZonas.Controls.Add(this.rbtZonaVerde);
            this.gbxZonas.Controls.Add(this.rbtZonaAzul);
            this.gbxZonas.Location = new System.Drawing.Point(111, 12);
            this.gbxZonas.Name = "gbxZonas";
            this.gbxZonas.Size = new System.Drawing.Size(81, 110);
            this.gbxZonas.TabIndex = 7;
            this.gbxZonas.TabStop = false;
            this.gbxZonas.Text = "Zona";
            // 
            // rbtZonaVerde
            // 
            this.rbtZonaVerde.AutoSize = true;
            this.rbtZonaVerde.Location = new System.Drawing.Point(18, 72);
            this.rbtZonaVerde.Name = "rbtZonaVerde";
            this.rbtZonaVerde.Size = new System.Drawing.Size(54, 19);
            this.rbtZonaVerde.TabIndex = 1;
            this.rbtZonaVerde.Text = "Verde";
            this.rbtZonaVerde.UseVisualStyleBackColor = true;
            this.rbtZonaVerde.CheckedChanged += new System.EventHandler(this.rbtZonaVerde_CheckedChanged);
            // 
            // rbtZonaAzul
            // 
            this.rbtZonaAzul.AutoSize = true;
            this.rbtZonaAzul.Location = new System.Drawing.Point(18, 26);
            this.rbtZonaAzul.Name = "rbtZonaAzul";
            this.rbtZonaAzul.Size = new System.Drawing.Size(48, 19);
            this.rbtZonaAzul.TabIndex = 0;
            this.rbtZonaAzul.Text = "Azul";
            this.rbtZonaAzul.UseVisualStyleBackColor = true;
            this.rbtZonaAzul.CheckedChanged += new System.EventHandler(this.rbtZonaAzul_CheckedChanged);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(101, 146);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 30);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 189);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.gbxZonas);
            this.Controls.Add(this.gbxAsiento);
            this.Controls.Add(this.gbxFila);
            this.Controls.Add(this.gbxLocal);
            this.Controls.Add(this.cmdReserva);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva Teatro";
            this.gbxLocal.ResumeLayout(false);
            this.gbxLocal.PerformLayout();
            this.gbxFila.ResumeLayout(false);
            this.gbxAsiento.ResumeLayout(false);
            this.gbxZonas.ResumeLayout(false);
            this.gbxZonas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdReserva;
        private RadioButton rbtQuenaken;
        private RadioButton rbtOnas;
        private RadioButton rbtTobas;
        private GroupBox gbxLocal;
        private GroupBox gbxFila;
        private ComboBox cmbFila;
        private GroupBox gbxAsiento;
        private ComboBox cmbAsiento;
        private GroupBox gbxZonas;
        private RadioButton rbtZonaVerde;
        private RadioButton rbtZonaAzul;
        private Button cmdCancelar;
    }
}