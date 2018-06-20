namespace HC128.Desktop
{
    partial class FrmDecrypt
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
            this.lblFiles = new System.Windows.Forms.Label();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.lblStreamKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.White;
            this.lblFiles.Location = new System.Drawing.Point(9, 12);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(130, 16);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Lista de archivos:";
            // 
            // listFiles
            // 
            this.listFiles.AllowDrop = true;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 31);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(159, 147);
            this.listFiles.Sorted = true;
            this.listFiles.TabIndex = 3;
            // 
            // lblStreamKey
            // 
            this.lblStreamKey.AutoSize = true;
            this.lblStreamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreamKey.ForeColor = System.Drawing.Color.White;
            this.lblStreamKey.Location = new System.Drawing.Point(12, 232);
            this.lblStreamKey.Name = "lblStreamKey";
            this.lblStreamKey.Size = new System.Drawing.Size(91, 16);
            this.lblStreamKey.TabIndex = 5;
            this.lblStreamKey.Text = "Stream Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.BackColor = System.Drawing.Color.White;
            this.btnDownloadImage.Image = global::HC128.Desktop.Properties.Resources.download;
            this.btnDownloadImage.Location = new System.Drawing.Point(12, 277);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(159, 43);
            this.btnDownloadImage.TabIndex = 7;
            this.btnDownloadImage.Text = "Descargar Imagen";
            this.btnDownloadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadImage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 537);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::HC128.Desktop.Properties.Resources.load;
            this.btnUpdate.Location = new System.Drawing.Point(12, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDownloadImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStreamKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HC-128 Demo";
            this.Load += new System.EventHandler(this.FrmDecrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStreamKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDownloadImage;
    }
}