
namespace Cruceros_Crown
{
    partial class FrmHistorial
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
            this.txtDestinoMasVendido = new System.Windows.Forms.TextBox();
            this.cboCrucerosHorasTotales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorasTotalesCrucero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGananciaRegional = new System.Windows.Forms.TextBox();
            this.txtGananciaExtraRegional = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPasajerosFrecuentes = new System.Windows.Forms.ListBox();
            this.lstDestinoPorFacturacion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino mas vendido";
            // 
            // txtDestinoMasVendido
            // 
            this.txtDestinoMasVendido.Location = new System.Drawing.Point(55, 51);
            this.txtDestinoMasVendido.Name = "txtDestinoMasVendido";
            this.txtDestinoMasVendido.ReadOnly = true;
            this.txtDestinoMasVendido.Size = new System.Drawing.Size(118, 23);
            this.txtDestinoMasVendido.TabIndex = 1;
            // 
            // cboCrucerosHorasTotales
            // 
            this.cboCrucerosHorasTotales.FormattingEnabled = true;
            this.cboCrucerosHorasTotales.Location = new System.Drawing.Point(45, 115);
            this.cboCrucerosHorasTotales.Name = "cboCrucerosHorasTotales";
            this.cboCrucerosHorasTotales.Size = new System.Drawing.Size(143, 23);
            this.cboCrucerosHorasTotales.TabIndex = 2;
            this.cboCrucerosHorasTotales.SelectedIndexChanged += new System.EventHandler(this.cboCrucerosHorasTotales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas totales por crucero";
            // 
            // txtHorasTotalesCrucero
            // 
            this.txtHorasTotalesCrucero.Location = new System.Drawing.Point(45, 144);
            this.txtHorasTotalesCrucero.Name = "txtHorasTotalesCrucero";
            this.txtHorasTotalesCrucero.ReadOnly = true;
            this.txtHorasTotalesCrucero.Size = new System.Drawing.Size(143, 23);
            this.txtHorasTotalesCrucero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Regionales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ganancias";
            // 
            // txtGananciaRegional
            // 
            this.txtGananciaRegional.Location = new System.Drawing.Point(257, 121);
            this.txtGananciaRegional.Name = "txtGananciaRegional";
            this.txtGananciaRegional.ReadOnly = true;
            this.txtGananciaRegional.Size = new System.Drawing.Size(118, 23);
            this.txtGananciaRegional.TabIndex = 6;
            // 
            // txtGananciaExtraRegional
            // 
            this.txtGananciaExtraRegional.Location = new System.Drawing.Point(257, 77);
            this.txtGananciaExtraRegional.Name = "txtGananciaExtraRegional";
            this.txtGananciaExtraRegional.ReadOnly = true;
            this.txtGananciaExtraRegional.Size = new System.Drawing.Size(118, 23);
            this.txtGananciaExtraRegional.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Extra-Regionales";
            // 
            // lstPasajerosFrecuentes
            // 
            this.lstPasajerosFrecuentes.FormattingEnabled = true;
            this.lstPasajerosFrecuentes.ItemHeight = 15;
            this.lstPasajerosFrecuentes.Location = new System.Drawing.Point(244, 197);
            this.lstPasajerosFrecuentes.Name = "lstPasajerosFrecuentes";
            this.lstPasajerosFrecuentes.Size = new System.Drawing.Size(189, 244);
            this.lstPasajerosFrecuentes.TabIndex = 9;
            // 
            // lstDestinoPorFacturacion
            // 
            this.lstDestinoPorFacturacion.FormattingEnabled = true;
            this.lstDestinoPorFacturacion.ItemHeight = 15;
            this.lstDestinoPorFacturacion.Location = new System.Drawing.Point(12, 197);
            this.lstDestinoPorFacturacion.Name = "lstDestinoPorFacturacion";
            this.lstDestinoPorFacturacion.Size = new System.Drawing.Size(214, 244);
            this.lstDestinoPorFacturacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Destino por facturacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pasajeros frecuentes";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstDestinoPorFacturacion);
            this.Controls.Add(this.lstPasajerosFrecuentes);
            this.Controls.Add(this.txtGananciaExtraRegional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGananciaRegional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasTotalesCrucero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCrucerosHorasTotales);
            this.Controls.Add(this.txtDestinoMasVendido);
            this.Controls.Add(this.label1);
            this.Name = "FrmHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinoMasVendido;
        private System.Windows.Forms.ComboBox cboCrucerosHorasTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasTotalesCrucero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGananciaRegional;
        private System.Windows.Forms.TextBox txtGananciaExtraRegional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPasajerosFrecuentes;
        private System.Windows.Forms.ListBox lstDestinoPorFacturacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}