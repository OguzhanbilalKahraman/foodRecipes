
namespace yemekTarifi
{
    partial class Form1
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
            this.listFbox = new System.Windows.Forms.ListBox();
            this.btnAsamaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFbox
            // 
            this.listFbox.FormattingEnabled = true;
            this.listFbox.Location = new System.Drawing.Point(51, 49);
            this.listFbox.Name = "listFbox";
            this.listFbox.Size = new System.Drawing.Size(500, 329);
            this.listFbox.TabIndex = 0;
            // 
            // btnAsamaEkle
            // 
            this.btnAsamaEkle.Location = new System.Drawing.Point(592, 197);
            this.btnAsamaEkle.Name = "btnAsamaEkle";
            this.btnAsamaEkle.Size = new System.Drawing.Size(136, 36);
            this.btnAsamaEkle.TabIndex = 1;
            this.btnAsamaEkle.Text = "Sıradaki Aşamayı Gör";
            this.btnAsamaEkle.UseVisualStyleBackColor = true;
            this.btnAsamaEkle.Click += new System.EventHandler(this.btnAsamaEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsamaEkle);
            this.Controls.Add(this.listFbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFbox;
        private System.Windows.Forms.Button btnAsamaEkle;
    }
}

