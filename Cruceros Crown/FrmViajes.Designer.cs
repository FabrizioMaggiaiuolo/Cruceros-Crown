using System.Collections.Generic;

namespace Cruceros_Crown
{
    partial class FrmViajes
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
            this.lstViajes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtHoraDePartida = new System.Windows.Forms.TextBox();
            this.txtPrecioTurista = new System.Windows.Forms.TextBox();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioPremium = new System.Windows.Forms.TextBox();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecargarListaViajes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstViajes
            // 
            this.lstViajes.FormattingEnabled = true;
            this.lstViajes.ItemHeight = 15;
            this.lstViajes.Location = new System.Drawing.Point(12, 40);
            this.lstViajes.Name = "lstViajes";
            this.lstViajes.Size = new System.Drawing.Size(293, 259);
            this.lstViajes.TabIndex = 0;
            this.lstViajes.SelectedIndexChanged += new System.EventHandler(this.lstViajes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio turista:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(507, 62);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(192, 23);
            this.txtOrigen.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(507, 103);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(192, 23);
            this.txtDestino.TabIndex = 6;
            // 
            // txtHoraDePartida
            // 
            this.txtHoraDePartida.Location = new System.Drawing.Point(507, 148);
            this.txtHoraDePartida.Name = "txtHoraDePartida";
            this.txtHoraDePartida.ReadOnly = true;
            this.txtHoraDePartida.Size = new System.Drawing.Size(192, 23);
            this.txtHoraDePartida.TabIndex = 7;
            // 
            // txtPrecioTurista
            // 
            this.txtPrecioTurista.Location = new System.Drawing.Point(507, 192);
            this.txtPrecioTurista.Name = "txtPrecioTurista";
            this.txtPrecioTurista.ReadOnly = true;
            this.txtPrecioTurista.Size = new System.Drawing.Size(192, 23);
            this.txtPrecioTurista.TabIndex = 8;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(411, 356);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(110, 39);
            this.btnAgregarViaje.TabIndex = 9;
            this.btnAgregarViaje.Text = "Agregar viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio premium:";
            // 
            // txtPrecioPremium
            // 
            this.txtPrecioPremium.Location = new System.Drawing.Point(507, 239);
            this.txtPrecioPremium.Name = "txtPrecioPremium";
            this.txtPrecioPremium.ReadOnly = true;
            this.txtPrecioPremium.Size = new System.Drawing.Size(192, 23);
            this.txtPrecioPremium.TabIndex = 11;
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.Location = new System.Drawing.Point(589, 356);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(110, 39);
            this.btnVerPasajeros.TabIndex = 12;
            this.btnVerPasajeros.Text = "Ver pasajeros";
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.btnVerPasajeros_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo de viaje:";
            // 
            // btnRecargarListaViajes
            // 
            this.btnRecargarListaViajes.Location = new System.Drawing.Point(105, 356);
            this.btnRecargarListaViajes.Name = "btnRecargarListaViajes";
            this.btnRecargarListaViajes.Size = new System.Drawing.Size(110, 39);
            this.btnRecargarListaViajes.TabIndex = 14;
            this.btnRecargarListaViajes.Text = "Recargar lista";
            this.btnRecargarListaViajes.UseVisualStyleBackColor = true;
            this.btnRecargarListaViajes.Click += new System.EventHandler(this.btnRecargarListaViajes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(507, 281);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(192, 23);
            this.txtEstado.TabIndex = 16;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRecargarListaViajes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVerPasajeros);
            this.Controls.Add(this.txtPrecioPremium);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.txtPrecioTurista);
            this.Controls.Add(this.txtHoraDePartida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViajes);
            this.Name = "FrmViajes";
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtHoraDePartida;
        private System.Windows.Forms.TextBox txtPrecioTurista;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioPremium;
        private System.Windows.Forms.Button btnVerPasajeros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecargarListaViajes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
    }
}