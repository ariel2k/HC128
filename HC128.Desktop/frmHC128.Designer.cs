namespace HC128.Desktop
{
    partial class FrmHC128
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
            this.picboxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxImagen
            // 
            this.picboxImagen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picboxImagen.Location = new System.Drawing.Point(12, 12);
            this.picboxImagen.Name = "picboxImagen";
            this.picboxImagen.Size = new System.Drawing.Size(260, 157);
            this.picboxImagen.TabIndex = 0;
            this.picboxImagen.TabStop = false;
            // 
            // FrmHC128
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picboxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHC128";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HC-128 Demo";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxImagen;
    }
}