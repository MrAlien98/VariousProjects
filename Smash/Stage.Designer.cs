namespace Smash
{
    partial class Stage
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
            this.imgPlayer1 = new System.Windows.Forms.PictureBox();
            this.imgPlayer2 = new System.Windows.Forms.PictureBox();
            this.coordinatesP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPlayer1
            // 
            this.imgPlayer1.Location = new System.Drawing.Point(1, 370);
            this.imgPlayer1.Name = "imgPlayer1";
            this.imgPlayer1.Size = new System.Drawing.Size(44, 88);
            this.imgPlayer1.TabIndex = 0;
            this.imgPlayer1.TabStop = false;
            // 
            // imgPlayer2
            // 
            this.imgPlayer2.Location = new System.Drawing.Point(646, 370);
            this.imgPlayer2.Name = "imgPlayer2";
            this.imgPlayer2.Size = new System.Drawing.Size(44, 88);
            this.imgPlayer2.TabIndex = 1;
            this.imgPlayer2.TabStop = false;
            // 
            // coordinatesP2
            // 
            this.coordinatesP2.AutoSize = true;
            this.coordinatesP2.Location = new System.Drawing.Point(568, 91);
            this.coordinatesP2.Name = "coordinatesP2";
            this.coordinatesP2.Size = new System.Drawing.Size(35, 13);
            this.coordinatesP2.TabIndex = 2;
            this.coordinatesP2.Text = "label1";
            this.coordinatesP2.Click += new System.EventHandler(this.CoordinatesP2_Click);
            // 
            // Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 458);
            this.Controls.Add(this.coordinatesP2);
            this.Controls.Add(this.imgPlayer2);
            this.Controls.Add(this.imgPlayer1);
            this.Name = "Stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smash Game";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer1;
        private System.Windows.Forms.PictureBox imgPlayer2;
        private System.Windows.Forms.Label coordinatesP2;
    }
}

