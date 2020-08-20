namespace ChoiceYourMusic
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMusic = new System.Windows.Forms.ListBox();
            this.cbMusic = new System.Windows.Forms.ComboBox();
            this.labelMusic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choice your music";
            // 
            // lbMusic
            // 
            this.lbMusic.FormattingEnabled = true;
            this.lbMusic.Location = new System.Drawing.Point(16, 136);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(120, 95);
            this.lbMusic.TabIndex = 1;
            this.lbMusic.SelectedIndexChanged += new System.EventHandler(this.lbMusic_SelectedIndexChanged);
            // 
            // cbMusic
            // 
            this.cbMusic.FormattingEnabled = true;
            this.cbMusic.Location = new System.Drawing.Point(12, 45);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(121, 21);
            this.cbMusic.TabIndex = 2;
            this.cbMusic.SelectedIndexChanged += new System.EventHandler(this.cbMusic_SelectedIndexChanged);
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Location = new System.Drawing.Point(16, 254);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(0, 13);
            this.labelMusic.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.cbMusic);
            this.Controls.Add(this.lbMusic);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMusic;
        private System.Windows.Forms.ComboBox cbMusic;
        private System.Windows.Forms.Label labelMusic;
    }
}

