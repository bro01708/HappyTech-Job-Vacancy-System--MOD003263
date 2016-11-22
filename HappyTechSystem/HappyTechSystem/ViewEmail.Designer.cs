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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_emailPreview
            // 
            this.tb_emailPreview.Location = new System.Drawing.Point(192, 12);
            this.tb_emailPreview.Multiline = true;
            this.tb_emailPreview.Name = "tb_emailPreview";
            this.tb_emailPreview.ReadOnly = true;
            this.tb_emailPreview.Size = new System.Drawing.Size(371, 301);
            this.tb_emailPreview.TabIndex = 0;
            // 
            // lb_email
            // 
            this.lb_email.FormattingEnabled = true;
            this.lb_email.Location = new System.Drawing.Point(6, 36);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(180, 277);
            this.lb_email.TabIndex = 1;
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(12, 12);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(175, 13);
            this.lbl_help.TabIndex = 4;
            this.lbl_help.Text = "Choose an email from the list below:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(569, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(53, 39);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(569, 100);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(53, 39);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(569, 145);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(53, 39);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // ViewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 324);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_emailPreview);
            this.Name = "ViewEmail";
            this.Text = "Modify and View Emails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_emailPreview;
        private System.Windows.Forms.ListBox lb_email;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
    }
}