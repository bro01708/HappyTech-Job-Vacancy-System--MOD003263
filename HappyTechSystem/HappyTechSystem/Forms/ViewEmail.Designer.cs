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
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_emailID = new System.Windows.Forms.Label();
            this.tb_emailID = new System.Windows.Forms.TextBox();
            this.lbl_templateUsed = new System.Windows.Forms.Label();
            this.tb_template = new System.Windows.Forms.TextBox();
            this.lbl_emailAddress = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.p_editToolbox = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.p_editToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_emailPreview
            // 
            this.tb_emailPreview.Location = new System.Drawing.Point(246, 135);
            this.tb_emailPreview.Multiline = true;
            this.tb_emailPreview.Name = "tb_emailPreview";
            this.tb_emailPreview.ReadOnly = true;
            this.tb_emailPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_emailPreview.Size = new System.Drawing.Size(505, 252);
            this.tb_emailPreview.TabIndex = 0;
            // 
            // lb_email
            // 
            this.lb_email.FormattingEnabled = true;
            this.lb_email.HorizontalScrollbar = true;
            this.lb_email.Location = new System.Drawing.Point(6, 36);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(234, 316);
            this.lb_email.TabIndex = 1;
            this.lb_email.SelectedIndexChanged += new System.EventHandler(this.lb_email_SelectedIndexChanged);
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(11, 13);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(175, 13);
            this.lbl_help.TabIndex = 4;
            this.lbl_help.Text = "Choose an email from the list below:";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(6, 358);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(234, 29);
            this.btn_close.TabIndex = 57;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(449, 116);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(76, 13);
            this.lbl_email.TabIndex = 58;
            this.lbl_email.Text = "Email Preview:";
            // 
            // lbl_emailID
            // 
            this.lbl_emailID.AutoSize = true;
            this.lbl_emailID.Location = new System.Drawing.Point(246, 13);
            this.lbl_emailID.Name = "lbl_emailID";
            this.lbl_emailID.Size = new System.Drawing.Size(49, 13);
            this.lbl_emailID.TabIndex = 59;
            this.lbl_emailID.Text = "Email ID:";
            // 
            // tb_emailID
            // 
            this.tb_emailID.Location = new System.Drawing.Point(301, 10);
            this.tb_emailID.Name = "tb_emailID";
            this.tb_emailID.ReadOnly = true;
            this.tb_emailID.Size = new System.Drawing.Size(27, 20);
            this.tb_emailID.TabIndex = 60;
            // 
            // lbl_templateUsed
            // 
            this.lbl_templateUsed.AutoSize = true;
            this.lbl_templateUsed.Location = new System.Drawing.Point(347, 13);
            this.lbl_templateUsed.Name = "lbl_templateUsed";
            this.lbl_templateUsed.Size = new System.Drawing.Size(82, 13);
            this.lbl_templateUsed.TabIndex = 61;
            this.lbl_templateUsed.Text = "Template Used:";
            // 
            // tb_template
            // 
            this.tb_template.Location = new System.Drawing.Point(435, 10);
            this.tb_template.Name = "tb_template";
            this.tb_template.ReadOnly = true;
            this.tb_template.Size = new System.Drawing.Size(168, 20);
            this.tb_template.TabIndex = 62;
            // 
            // lbl_emailAddress
            // 
            this.lbl_emailAddress.AutoSize = true;
            this.lbl_emailAddress.Location = new System.Drawing.Point(246, 45);
            this.lbl_emailAddress.Name = "lbl_emailAddress";
            this.lbl_emailAddress.Size = new System.Drawing.Size(102, 13);
            this.lbl_emailAddress.TabIndex = 63;
            this.lbl_emailAddress.Text = "Sending to Address:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(354, 42);
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = true;
            this.tb_address.Size = new System.Drawing.Size(148, 20);
            this.tb_address.TabIndex = 64;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(246, 71);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 65;
            this.lbl_subject.Text = "Subject:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(354, 68);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.ReadOnly = true;
            this.tb_subject.Size = new System.Drawing.Size(148, 20);
            this.tb_subject.TabIndex = 66;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(534, 45);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(58, 13);
            this.lbl_date.TabIndex = 67;
            this.lbl_date.Text = "Date Sent:";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(598, 42);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(75, 20);
            this.tb_date.TabIndex = 68;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(691, 10);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 48);
            this.btn_edit.TabIndex = 69;
            this.btn_edit.Text = "Toggle Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // p_editToolbox
            // 
            this.p_editToolbox.Controls.Add(this.btn_delete);
            this.p_editToolbox.Controls.Add(this.btn_save);
            this.p_editToolbox.Location = new System.Drawing.Point(622, 79);
            this.p_editToolbox.Name = "p_editToolbox";
            this.p_editToolbox.Size = new System.Drawing.Size(132, 50);
            this.p_editToolbox.TabIndex = 70;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(66, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 48);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete Email";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Location = new System.Drawing.Point(0, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 48);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // ViewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 399);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.lbl_emailAddress);
            this.Controls.Add(this.tb_template);
            this.Controls.Add(this.lbl_templateUsed);
            this.Controls.Add(this.tb_emailID);
            this.Controls.Add(this.lbl_emailID);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_emailPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewEmail";
            this.Text = "Modify and View Emails";
            this.Load += new System.EventHandler(this.ViewEmail_Load);
            this.p_editToolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_emailPreview;
        private System.Windows.Forms.ListBox lb_email;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_emailID;
        private System.Windows.Forms.TextBox tb_emailID;
        private System.Windows.Forms.Label lbl_templateUsed;
        private System.Windows.Forms.TextBox tb_template;
        private System.Windows.Forms.Label lbl_emailAddress;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel p_editToolbox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}