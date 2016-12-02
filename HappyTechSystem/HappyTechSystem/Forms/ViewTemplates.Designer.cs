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
            this.tb_templateID = new System.Windows.Forms.TextBox();
            this.lbl_templateID = new System.Windows.Forms.Label();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.lbl_body = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.p_editToolbox = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.g_modifyViewTemplates.SuspendLayout();
            this.p_editToolbox.SuspendLayout();
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
            this.lb_templates.Location = new System.Drawing.Point(12, 35);
            this.lb_templates.Name = "lb_templates";
            this.lb_templates.Size = new System.Drawing.Size(130, 212);
            this.lb_templates.TabIndex = 1;
            this.lb_templates.SelectedIndexChanged += new System.EventHandler(this.lb_templates_SelectedIndexChanged);
            // 
            // lbl_templateName
            // 
            this.lbl_templateName.AutoSize = true;
            this.lbl_templateName.Location = new System.Drawing.Point(18, 56);
            this.lbl_templateName.Name = "lbl_templateName";
            this.lbl_templateName.Size = new System.Drawing.Size(97, 13);
            this.lbl_templateName.TabIndex = 2;
            this.lbl_templateName.Text = "Name of Template:";
            // 
            // tb_templateName
            // 
            this.tb_templateName.Location = new System.Drawing.Point(118, 53);
            this.tb_templateName.Name = "tb_templateName";
            this.tb_templateName.ReadOnly = true;
            this.tb_templateName.Size = new System.Drawing.Size(100, 20);
            this.tb_templateName.TabIndex = 3;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(118, 79);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.ReadOnly = true;
            this.tb_subject.Size = new System.Drawing.Size(116, 20);
            this.tb_subject.TabIndex = 9;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(18, 82);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 8;
            this.lbl_subject.Text = "Subject:";
            // 
            // g_modifyViewTemplates
            // 
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
            this.g_modifyViewTemplates.Size = new System.Drawing.Size(452, 281);
            this.g_modifyViewTemplates.TabIndex = 10;
            this.g_modifyViewTemplates.TabStop = false;
            this.g_modifyViewTemplates.Text = "Modify and View Template";
            // 
            // tb_templateID
            // 
            this.tb_templateID.Location = new System.Drawing.Point(118, 20);
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
            this.tb_body.Location = new System.Drawing.Point(118, 105);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.ReadOnly = true;
            this.tb_body.Size = new System.Drawing.Size(289, 164);
            this.tb_body.TabIndex = 11;
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(18, 108);
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
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(0, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 48);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 253);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(130, 40);
            this.btn_close.TabIndex = 57;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ViewTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 299);
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
    }
}