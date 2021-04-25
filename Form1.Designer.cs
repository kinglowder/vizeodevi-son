
namespace deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsasd = new System.Windows.Forms.Label();
            this.label_durum = new System.Windows.Forms.Label();
            this.label_yer = new System.Windows.Forms.Label();
            this.picture_bulutlu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).BeginInit();
            this.SuspendLayout();
            // 
            // dsasd
            // 
            this.dsasd.AutoSize = true;
            this.dsasd.Location = new System.Drawing.Point(157, 254);
            this.dsasd.Name = "dsasd";
            this.dsasd.Size = new System.Drawing.Size(38, 15);
            this.dsasd.TabIndex = 0;
            this.dsasd.Text = "label1";
            // 
            // label_durum
            // 
            this.label_durum.AutoSize = true;
            this.label_durum.Location = new System.Drawing.Point(157, 302);
            this.label_durum.Name = "label_durum";
            this.label_durum.Size = new System.Drawing.Size(38, 15);
            this.label_durum.TabIndex = 1;
            this.label_durum.Text = "label2";
            // 
            // label_yer
            // 
            this.label_yer.AutoSize = true;
            this.label_yer.Location = new System.Drawing.Point(157, 354);
            this.label_yer.Name = "label_yer";
            this.label_yer.Size = new System.Drawing.Size(38, 15);
            this.label_yer.TabIndex = 2;
            this.label_yer.Text = "label3";
            // 
            // picture_bulutlu
            // 
            this.picture_bulutlu.Image = global::vizeodevi_son.Properties.Resources._700422_icon_1_cloud_512;
            this.picture_bulutlu.Location = new System.Drawing.Point(451, 24);
            this.picture_bulutlu.Name = "picture_bulutlu";
            this.picture_bulutlu.Size = new System.Drawing.Size(92, 86);
            this.picture_bulutlu.TabIndex = 3;
            this.picture_bulutlu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture_bulutlu);
            this.Controls.Add(this.label_yer);
            this.Controls.Add(this.label_durum);
            this.Controls.Add(this.dsasd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_derece;
        private System.Windows.Forms.Label label_durum;
        private System.Windows.Forms.Label label_yer;
        private System.Windows.Forms.Label dsasd;
        private System.Windows.Forms.PictureBox picture_bulutlu;
        private System.Windows.Forms.PictureBox picture_gunesli;
    }
}

