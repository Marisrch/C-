﻿namespace SorveteriaZequinha
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pngSplash = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.pgbCarrgar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pngSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pngSplash
            // 
            this.pngSplash.Image = ((System.Drawing.Image)(resources.GetObject("pngSplash.Image")));
            this.pngSplash.Location = new System.Drawing.Point(257, 110);
            this.pngSplash.Name = "pngSplash";
            this.pngSplash.Size = new System.Drawing.Size(243, 232);
            this.pngSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pngSplash.TabIndex = 0;
            this.pngSplash.TabStop = false;
            this.pngSplash.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(357, 369);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(14, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "0";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(372, 369);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(19, 16);
            this.lblPorcentagem.TabIndex = 2;
            this.lblPorcentagem.Text = "%";
            // 
            // pgbCarrgar
            // 
            this.pgbCarrgar.Location = new System.Drawing.Point(257, 398);
            this.pgbCarrgar.Name = "pgbCarrgar";
            this.pgbCarrgar.Size = new System.Drawing.Size(243, 23);
            this.pgbCarrgar.TabIndex = 3;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pgbCarrgar);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.pngSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpresaABC - Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pngSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pngSplash;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.ProgressBar pgbCarrgar;
    }
}