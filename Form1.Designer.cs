namespace Vuelos
{
    partial class ReservarVuelos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsientosDisponibles = new System.Windows.Forms.TextBox();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.btnReservarVuelo = new System.Windows.Forms.Button();
            this.txtCantidadReservas = new System.Windows.Forms.TextBox();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(135, 166);
            this.txtCodigoVuelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(274, 26);
            this.txtCodigoVuelo.TabIndex = 0;
            this.txtCodigoVuelo.Text = "Codigo de vuelo";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(135, 238);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(274, 26);
            this.txtOrigen.TabIndex = 1;
            this.txtOrigen.Text = "Origen";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(135, 323);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(274, 26);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.Text = "Destino";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(135, 437);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(384, 26);
            this.dtpFechaSalida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la fecha de salida";
            // 
            // txtAsientosDisponibles
            // 
            this.txtAsientosDisponibles.Location = new System.Drawing.Point(135, 525);
            this.txtAsientosDisponibles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsientosDisponibles.Name = "txtAsientosDisponibles";
            this.txtAsientosDisponibles.Size = new System.Drawing.Size(274, 26);
            this.txtAsientosDisponibles.TabIndex = 5;
            this.txtAsientosDisponibles.Text = "Numero de asientos";
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(136, 617);
            this.btnAgregarVuelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(222, 52);
            this.btnAgregarVuelo.TabIndex = 6;
            this.btnAgregarVuelo.Text = "Agregar vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.ItemHeight = 20;
            this.listBoxVuelos.Location = new System.Drawing.Point(565, 166);
            this.listBoxVuelos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(573, 464);
            this.listBoxVuelos.TabIndex = 7;
            // 
            // btnReservarVuelo
            // 
            this.btnReservarVuelo.Location = new System.Drawing.Point(1164, 512);
            this.btnReservarVuelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservarVuelo.Name = "btnReservarVuelo";
            this.btnReservarVuelo.Size = new System.Drawing.Size(222, 52);
            this.btnReservarVuelo.TabIndex = 9;
            this.btnReservarVuelo.Text = "Reservar Vuelo";
            this.btnReservarVuelo.UseVisualStyleBackColor = true;
            this.btnReservarVuelo.Click += new System.EventHandler(this.btnReservarVuelo_Click);
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(1162, 420);
            this.txtCantidadReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(274, 26);
            this.txtCantidadReservas.TabIndex = 8;
            this.txtCantidadReservas.Text = "Cantidad de asientos a reservar";
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(1162, 332);
            this.txtCodigoReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(274, 26);
            this.txtCodigoReserva.TabIndex = 10;
            this.txtCodigoReserva.Text = "Codigo Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sistema de reserva de vuelos";
            // 
            // ReservarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 875);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.btnReservarVuelo);
            this.Controls.Add(this.txtCantidadReservas);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.txtAsientosDisponibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservarVuelos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoVuelo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsientosDisponibles;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.Button btnReservarVuelo;
        private System.Windows.Forms.TextBox txtCantidadReservas;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Label label2;
    }
}

