namespace HappyTechSystem
{
    partial class ViewTemplates
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
            this.lbl_select = new System.Windows.Forms.Label();
            this.lb_templates = new System.Windows.Forms.ListBox();
            this.lbl_templateName = new System.Windows.Forms.Label();
            this.tb_templateName = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.g_modifyViewTemplates = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.tb_templateID = new System.Windows.Forms.TextBox();
            this.lbl_templateID = new System.Windows.Forms.Label();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.lbl_body = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.p_editToolbox = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_tags = new System.Windows.Forms.GroupBox();
            this.lbl_intervieweeName = new System.Windows.Forms.Label();
            this.btn_INadd = new System.Windows.Forms.Button();
            this.lbl_INFound = new System.Windows.Forms.Label();
            this.lbl_JRFound = new System.Windows.Forms.Label();
            this.btn_JRadd = new System.Windows.Forms.Button();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_FAFound = new System.Windows.Forms.Label();
            this.btn_FAadd = new System.Windows.Forms.Button();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.lbl_SNFound = new System.Windows.Forms.Label();
            this.btn_SNadd = new System.Windows.Forms.Button();
            this.lbl_senderName = new System.Windows.Forms.Label();
            this.g_modifyViewTemplates.SuspendLayout();
            this.p_editToolbox.SuspendLayout();
            this.gb_tags.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(12, 12);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(130, 13);
            this.lbl_select.TabIndex = 0;
            this.lbl_select.Text = "Select an Email Template:";
            // 
            // lb_templates
            // 
            this.lb_templates.FormattingEnabled = true;
            this.lb_templates.HorizontalScrollbar = true;
            this.lb_templates.Location = new System.Drawing.Point(12, 35);
            this.lb_templates.Name = "lb_templates";
            this.lb_templates.Size = new System.Drawing.Size(130, 264);
            this.lb_templates.TabIndex = 1;
            this.lb_templates.SelectedIndexChanged += new System.EventHandler(this.lb_templates_SelectedIndexChanged);
            // 
            // lbl_templateName
            // 
            this.lbl_templateName.AutoSize = true;
            this.lbl_templateName.Location = new System.Drawing.Point(227, 49);
            this.lbl_templateName.Name = "lbl_templateName";
            this.lbl_templateName.Size = new System.Drawing.Size(97, 13);
            this.lbl_templateName.TabIndex = 2;
            this.lbl_templateName.Text = "Name of Template:";
            // 
            // tb_templateName
            // 
            this.tb_templateName.Location = new System.Drawing.Point(330, 46);
            this.tb_templateName.Name = "tb_templateName";
            this.tb_templateName.ReadOnly = true;
            this.tb_templateName.Size = new System.Drawing.Size(116, 20);
            this.tb_templateName.TabIndex = 3;
            this.tb_templateName.TextChanged += new System.EventHandler(this.SaveUnlocker);
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(92, 46);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.ReadOnly = true;
            this.tb_subject.Size = new System.Drawing.Size(116, 20);
            this.tb_subject.TabIndex = 9;
            this.tb_subject.TextChanged += new System.EventHandler(this.SaveUnlocker);
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(18, 49);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 8;
            this.lbl_subject.Text = "Subject:";
            // 
            // g_modifyViewTemplates
            // 
            this.g_modifyViewTemplates.Controls.Add(this.gb_tags);
            this.g_modifyViewTemplates.Controls.Add(this.cb_type);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_type);
            this.g_modifyViewTemplates.Controls.Add(this.tb_templateID);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_templateID);
            this.g_modifyViewTemplates.Controls.Add(this.tb_body);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_body);
            this.g_modifyViewTemplates.Controls.Add(this.tb_subject);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_templateName);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_subject);
            this.g_modifyViewTemplates.Controls.Add(this.tb_templateName);
            this.g_modifyViewTemplates.Location = new System.Drawing.Point(148, 12);
            this.g_modifyViewTemplates.Name = "g_modifyViewTemplates";
            this.g_modifyViewTemplates.Size = new System.Drawing.Size(468, 347);
            this.g_modifyViewTemplates.TabIndex = 10;
            this.g_modifyViewTemplates.TabStop = false;
            this.g_modifyViewTemplates.Text = "Modify and View Template";
            // 
            // cb_type
            // 
            this.cb_type.Enabled = false;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Accept",
            "Reject",
            "Consideration"});
            this.cb_type.Location = new System.Drawing.Point(330, 19);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(116, 21);
            this.cb_type.TabIndex = 16;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.SaveUnlocker);
            this.cb_type.TextChanged += new System.EventHandler(this.SaveUnlocker);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(227, 23);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(81, 13);
            this.lbl_type.TabIndex = 14;
            this.lbl_type.Text = "Template Type:";
            // 
            // tb_templateID
            // 
            this.tb_templateID.Location = new System.Drawing.Point(92, 19);
            this.tb_templateID.Name = "tb_templateID";
            this.tb_templateID.ReadOnly = true;
            this.tb_templateID.Size = new System.Drawing.Size(27, 20);
            this.tb_templateID.TabIndex = 13;
            // 
            // lbl_templateID
            // 
            this.lbl_templateID.AutoSize = true;
            this.lbl_templateID.Location = new System.Drawing.Point(18, 23);
            this.lbl_templateID.Name = "lbl_templateID";
            this.lbl_templateID.Size = new System.Drawing.Size(68, 13);
            this.lbl_templateID.TabIndex = 12;
            this.lbl_templateID.Text = "Template ID:";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(158, 105);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.ReadOnly = true;
            this.tb_body.Size = new System.Drawing.Size(288, 236);
            this.tb_body.TabIndex = 11;
            this.tb_body.TextChanged += new System.EventHandler(this.SaveUnlocker);
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(290, 89);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(34, 13);
            this.lbl_body.TabIndex = 10;
            this.lbl_body.Text = "Body:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(622, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 48);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "Toggle Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // p_editToolbox
            // 
            this.p_editToolbox.Controls.Add(this.btn_delete);
            this.p_editToolbox.Controls.Add(this.btn_save);
            this.p_editToolbox.Location = new System.Drawing.Point(622, 66);
            this.p_editToolbox.Name = "p_editToolbox";
            this.p_editToolbox.Size = new System.Drawing.Size(63, 100);
            this.p_editToolbox.TabIndex = 56;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(0, 51);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 48);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete Template";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(0, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 48);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 313);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(130, 40);
            this.btn_close.TabIndex = 57;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gb_tags
            // 
            this.gb_tags.Controls.Add(this.lbl_SNFound);
            this.gb_tags.Controls.Add(this.btn_SNadd);
            this.gb_tags.Controls.Add(this.lbl_senderName);
            this.gb_tags.Controls.Add(this.lbl_FAFound);
            this.gb_tags.Controls.Add(this.btn_FAadd);
            this.gb_tags.Controls.Add(this.lbl_feedback);
            this.gb_tags.Controls.Add(this.lbl_JRFound);
            this.gb_tags.Controls.Add(this.btn_JRadd);
            this.gb_tags.Controls.Add(this.lbl_role);
            this.gb_tags.Controls.Add(this.lbl_INFound);
            this.gb_tags.Controls.Add(this.btn_INadd);
            this.gb_tags.Controls.Add(this.lbl_intervieweeName);
            this.gb_tags.Location = new System.Drawing.Point(7, 105);
            this.gb_tags.Name = "gb_tags";
            this.gb_tags.Size = new System.Drawing.Size(145, 236);
            this.gb_tags.TabIndex = 17;
            this.gb_tags.TabStop = false;
            this.gb_tags.Text = "Template Tags";
            // 
            // lbl_intervieweeName
            // 
            this.lbl_intervieweeName.AutoSize = true;
            this.lbl_intervieweeName.Location = new System.Drawing.Point(28, 18);
            this.lbl_intervieweeName.Name = "lbl_intervieweeName";
            this.lbl_intervieweeName.Size = new System.Drawing.Size(93, 13);
            this.lbl_intervieweeName.TabIndex = 0;
            this.lbl_intervieweeName.Text = "Interviewee Name";
            // 
            // btn_INadd
            // 
            this.btn_INadd.Location = new System.Drawing.Point(6, 34);
            this.btn_INadd.Name = "btn_INadd";
            this.btn_INadd.Size = new System.Drawing.Size(60, 23);
            this.btn_INadd.TabIndex = 1;
            this.btn_INadd.Text = "Add";
            this.btn_INadd.UseVisualStyleBackColor = true;
            this.btn_INadd.Click += new System.EventHandler(this.btn_INadd_Click);
            // 
            // lbl_INFound
            // 
            this.lbl_INFound.AutoSize = true;
            this.lbl_INFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_INFound.Location = new System.Drawing.Point(72, 39);
            this.lbl_INFound.Name = "lbl_INFound";
            this.lbl_INFound.Size = new System.Drawing.Size(60, 13);
            this.lbl_INFound.TabIndex = 2;
            this.lbl_INFound.Text = "Not Found!";
            // 
            // lbl_JRFound
            // 
            this.lbl_JRFound.AutoSize = true;
            this.lbl_JRFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_JRFound.Location = new System.Drawing.Point(72, 85);
            this.lbl_JRFound.Name = "lbl_JRFound";
            this.lbl_JRFound.Size = new System.Drawing.Size(60, 13);
            this.lbl_JRFound.TabIndex = 5;
            this.lbl_JRFound.Text = "Not Found!";
            // 
            // btn_JRadd
            // 
            this.btn_JRadd.Location = new System.Drawing.Point(6, 80);
            this.btn_JRadd.Name = "btn_JRadd";
            this.btn_JRadd.Size = new System.Drawing.Size(60, 23);
            this.btn_JRadd.TabIndex = 4;
            this.btn_JRadd.Text = "Add";
            this.btn_JRadd.UseVisualStyleBackColor = true;
            this.btn_JRadd.Click += new System.EventHandler(this.btn_JRadd_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(48, 64);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(49, 13);
            this.lbl_role.TabIndex = 3;
            this.lbl_role.Text = "Job Role";
            // 
            // lbl_FAFound
            // 
            this.lbl_FAFound.AutoSize = true;
            this.lbl_FAFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_FAFound.Location = new System.Drawing.Point(72, 133);
            this.lbl_FAFound.Name = "lbl_FAFound";
            this.lbl_FAFound.Size = new System.Drawing.Size(60, 13);
            this.lbl_FAFound.TabIndex = 8;
            this.lbl_FAFound.Text = "Not Found!";
            // 
            // btn_FAadd
            // 
            this.btn_FAadd.Location = new System.Drawing.Point(6, 128);
            this.btn_FAadd.Name = "btn_FAadd";
            this.btn_FAadd.Size = new System.Drawing.Size(60, 23);
            this.btn_FAadd.TabIndex = 7;
            this.btn_FAadd.Text = "Add";
            this.btn_FAadd.UseVisualStyleBackColor = true;
            this.btn_FAadd.Click += new System.EventHandler(this.btn_FAadd_Click);
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Location = new System.Drawing.Point(32, 112);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(80, 13);
            this.lbl_feedback.TabIndex = 6;
            this.lbl_feedback.Text = "Feedback Area";
            // 
            // lbl_SNFound
            // 
            this.lbl_SNFound.AutoSize = true;
            this.lbl_SNFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_SNFound.Location = new System.Drawing.Point(72, 182);
            this.lbl_SNFound.Name = "lbl_SNFound";
            this.lbl_SNFound.Size = new System.Drawing.Size(60, 13);
            this.lbl_SNFound.TabIndex = 11;
            this.lbl_SNFound.Text = "Not Found!";
            // 
            // btn_SNadd
            // 
            this.btn_SNadd.Location = new System.Drawing.Point(6, 177);
            this.btn_SNadd.Name = "btn_SNadd";
            this.btn_SNadd.Size = new System.Drawing.Size(60, 23);
            this.btn_SNadd.TabIndex = 10;
            this.btn_SNadd.Text = "Add";
            this.btn_SNadd.UseVisualStyleBackColor = true;
            this.btn_SNadd.Click += new System.EventHandler(this.btn_SNadd_Click);
            // 
            // lbl_senderName
            // 
            this.lbl_senderName.AutoSize = true;
            this.lbl_senderName.Location = new System.Drawing.Point(28, 161);
            this.lbl_senderName.Name = "lbl_senderName";
            this.lbl_senderName.Size = new System.Drawing.Size(79, 13);
            this.lbl_senderName.TabIndex = 9;
            this.lbl_senderName.Text = "Sender\'s Name";
            // 
            // ViewTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 371);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.g_modifyViewTemplates);
            this.Controls.Add(this.lb_templates);
            this.Controls.Add(this.lbl_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewTemplates";
            this.Text = "Modify and View Templates";
            this.Load += new System.EventHandler(this.ViewTemplates_Load);
            this.g_modifyViewTemplates.ResumeLayout(false);
            this.g_modifyViewTemplates.PerformLayout();
            this.p_editToolbox.ResumeLayout(false);
            this.gb_tags.ResumeLayout(false);
            this.gb_tags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.ListBox lb_templates;
        private System.Windows.Forms.Label lbl_templateName;
        private System.Windows.Forms.TextBox tb_templateName;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.GroupBox g_modifyViewTemplates;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel p_editToolbox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_templateID;
        private System.Windows.Forms.Label lbl_templateID;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.GroupBox gb_tags;
        private System.Windows.Forms.Label lbl_INFound;
        private System.Windows.Forms.Button btn_INadd;
        private System.Windows.Forms.Label lbl_intervieweeName;
        private System.Windows.Forms.Label lbl_SNFound;
        private System.Windows.Forms.Button btn_SNadd;
        private System.Windows.Forms.Label lbl_senderName;
        private System.Windows.Forms.Label lbl_FAFound;
        private System.Windows.Forms.Button btn_FAadd;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.Label lbl_JRFound;
        private System.Windows.Forms.Button btn_JRadd;
        private System.Windows.Forms.Label lbl_role;
    }
}