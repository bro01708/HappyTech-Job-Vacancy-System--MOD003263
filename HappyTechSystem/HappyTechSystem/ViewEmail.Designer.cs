namespace HappyTechSystem
{
    partial class ViewEmail
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
            this.tb_emailPreview = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.ListBox();
            this.lbl_help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_emailPreview
            // 
            this.tb_emailPreview.Location = new System.Drawing.Point(198, 12);
            this.tb_emailPreview.Multiline = true;
            this.tb_emailPreview.Name = "tb_emailPreview";
            this.tb_emailPreview.Size = new System.Drawing.Size(371, 366);
            this.tb_emailPreview.TabIndex = 0;
            // 
            // lb_email
            // 
            this.lb_email.FormattingEnabled = true;
            this.lb_email.Location = new System.Drawing.Point(12, 49);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(180, 329);
            this.lb_email.TabIndex = 1;
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(13, 18);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(175, 13);
            this.lbl_help.TabIndex = 4;
            this.lbl_help.Text = "Choose an email from the list below:";
            // 
            // ViewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 406);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_emailPreview);
            this.Name = "ViewEmail";
            this.Text = "ViewEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_emailPreview;
        private System.Windows.Forms.ListBox lb_email;
        private System.Windows.Forms.Label lbl_help;
    }
}