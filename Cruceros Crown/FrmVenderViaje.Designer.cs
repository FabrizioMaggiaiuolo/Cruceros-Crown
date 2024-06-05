
namespace Cruceros_Crown
{
    partial class FrmVenderViaje
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
            this.lstViajeVender = new System.Windows.Forms.ListBox();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.btnEliminarPasajero = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLugarSalida = new System.Windows.Forms.TextBox();
            this.txtLugarDestino = new System.Windows.Forms.TextBox();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstViajeVender
            // 
            this.lstViajeVender.FormattingEnabled = true;
            this.lstViajeVender.ItemHeight = 15;
            this.lstViajeVender.Location = new System.Drawing.Point(29, 42);
            this.lstViajeVender.Name = "lstViajeVender";
            this.lstViajeVender.Size = new System.Drawing.Size(194, 349);
            this.lstViajeVender.TabIndex = 0;
            this.lstViajeVender.SelectedIndexChanged += new System.EventHandler(this.lstViajeVender_SelectedIndexChanged);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 15;
            this.lstPasajeros.Location = new System.Drawing.Point(446, 42);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(259, 169);
            this.lstPasajeros.TabIndex = 1;
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Location = new System.Drawing.Point(446, 257);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPasajero.TabIndex = 2;
            this.btnAgregarPasajero.Text = "Agregar";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.Location = new System.Drawing.Point(630, 257);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPasajero.TabIndex = 3;
            this.btnEliminarPasajero.Text = "Eliminar";
            this.btnEliminarPasajero.UseVisualStyleBackColor = true;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(540, 257);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarLista.TabIndex = 4;
            this.btnActualizarLista.Text = "Actualizar";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(518, 324);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(108, 48);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de viajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista de pasajero de la venta";
            // 
            // txtLugarSalida
            // 
            this.txtLugarSalida.Location = new System.Drawing.Point(271, 118);
            this.txtLugarSalida.Name = "txtLugarSalida";
            this.txtLugarSalida.ReadOnly = true;
            this.txtLugarSalida.Size = new System.Drawing.Size(132, 23);
            this.txtLugarSalida.TabIndex = 8;
            // 
            // txtLugarDestino
            // 
            this.txtLugarDestino.Location = new System.Drawing.Point(271, 183);
            this.txtLugarDestino.Name = "txtLugarDestino";
            this.txtLugarDestino.ReadOnly = true;
            this.txtLugarDestino.Size = new System.Drawing.Size(132, 23);
            this.txtLugarDestino.TabIndex = 9;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(271, 252);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.ReadOnly = true;
            this.txtFechaSalida.Size = new System.Drawing.Size(132, 23);
            this.txtFechaSalida.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lugar de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lugar de destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de salida";
            // 
            // FrmVenderViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtLugarDestino);
            this.Controls.Add(this.txtLugarSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnActualizarLista);
            this.Controls.Add(this.btnEliminarPasajero);
            this.Controls.Add(this.btnAgregarPasajero);
            this.Controls.Add(this.lstPasajeros);
            this.Controls.Add(this.lstViajeVender);
            this.Name = "FrmVenderViaje";
            this.Text = "Vender viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstViajeVender;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Button btnAgregarPasajero;
        private System.Windows.Forms.Button btnEliminarPasajero;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLugarSalida;
        private System.Windows.Forms.TextBox txtLugarDestino;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}