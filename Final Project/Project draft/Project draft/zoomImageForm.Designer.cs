namespace MobileStore
{
    partial class zoomImageForm
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
            this.zoomPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomPictureBox
            // 
            this.zoomPictureBox.Location = new System.Drawing.Point(13, 22);
            this.zoomPictureBox.Name = "zoomPictureBox";
            this.zoomPictureBox.Size = new System.Drawing.Size(259, 228);
            this.zoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoomPictureBox.TabIndex = 0;
            this.zoomPictureBox.TabStop = false;
            // 
            // zoomImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.zoomPictureBox);
            this.Name = "zoomImageForm";
            this.Text = "zoomImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.zoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox zoomPictureBox;
    }
}