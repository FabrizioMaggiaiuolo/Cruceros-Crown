﻿
namespace Cruceros_Crown
{
    partial class FrmAgregarViaje
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
            this.lstCruceros = new System.Windows.Forms.ListBox();
            this.cboPartida = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.txtCodigoDeViaje = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCruceros
            // 
            this.lstCruceros.FormattingEnabled = true;
            this.lstCruceros.ItemHeight = 15;
            this.lstCruceros.Location = new System.Drawing.Point(47, 12);
            this.lstCruceros.Name = "lstCruceros";
            this.lstCruceros.Size = new System.Drawing.Size(228, 154);
            this.lstCruceros.TabIndex = 0;
            // 
            // cboPartida
            // 
            this.cboPartida.FormattingEnabled = true;
            this.cboPartida.Location = new System.Drawing.Point(155, 188);
            this.cboPartida.Name = "cboPartida";
            this.cboPartida.Size = new System.Drawing.Size(121, 23);
            this.cboPartida.TabIndex = 1;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(155, 245);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 23);
            this.cboDestino.TabIndex = 2;
            // 
            // txtCodigoDeViaje
            // 
            this.txtCodigoDeViaje.Location = new System.Drawing.Point(155, 299);
            this.txtCodigoDeViaje.Name = "txtCodigoDeViaje";
            this.txtCodigoDeViaje.Size = new System.Drawing.Size(120, 23);
            this.txtCodigoDeViaje.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 352);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo de viaje";
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(115, 404);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarViaje.TabIndex = 8;
            this.btnAgregarViaje.Text = "Agregar";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // FrmAgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCodigoDeViaje);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboPartida);
            this.Controls.Add(this.lstCruceros);
            this.Name = "FrmAgregarViaje";
            this.Text = "Agregar un pasejero";
            this.Load += new System.EventHandler(this.FrmAgregarViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCruceros;
        private System.Windows.Forms.ComboBox cboPartida;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.TextBox txtCodigoDeViaje;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarViaje;
    }
}