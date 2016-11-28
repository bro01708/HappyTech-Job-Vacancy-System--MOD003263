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
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.tb_greeting = new System.Windows.Forms.TextBox();
            this.g_modifyViewTemplates = new System.Windows.Forms.GroupBox();
            this.tb_signOff = new System.Windows.Forms.TextBox();
            this.lbl_signOff = new System.Windows.Forms.Label();
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
            this.lb_templates.Size = new System.Drawing.Size(130, 225);
            this.lb_templates.TabIndex = 1;
            // 
            // lbl_templateName
            // 
            this.lbl_templateName.AutoSize = true;
            this.lbl_templateName.Location = new System.Drawing.Point(18, 31);
            this.lbl_templateName.Name = "lbl_templateName";
            this.lbl_templateName.Size = new System.Drawing.Size(97, 13);
            this.lbl_templateName.TabIndex = 2;
            this.lbl_templateName.Text = "Name of Template:";
            // 
            // tb_templateName
            // 
            this.tb_templateName.Location = new System.Drawing.Point(118, 28);
            this.tb_templateName.Name = "tb_templateName";
            this.tb_templateName.ReadOnly = true;
            this.tb_templateName.Size = new System.Drawing.Size(100, 20);
            this.tb_templateName.TabIndex = 3;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(118, 54);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.ReadOnly = true;
            this.tb_subject.Size = new System.Drawing.Size(116, 20);
            this.tb_subject.TabIndex = 9;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(18, 57);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 8;
            this.lbl_subject.Text = "Subject:";
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Location = new System.Drawing.Point(18, 83);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(50, 13);
            this.lbl_greeting.TabIndex = 7;
            this.lbl_greeting.Text = "Greeting:";
            // 
            // tb_greeting
            // 
            this.tb_greeting.Location = new System.Drawing.Point(118, 80);
            this.tb_greeting.Name = "tb_greeting";
            this.tb_greeting.ReadOnly = true;
            this.tb_greeting.Size = new System.Drawing.Size(289, 20);
            this.tb_greeting.TabIndex = 6;
            // 
            // g_modifyViewTemplates
            // 
            this.g_modifyViewTemplates.Controls.Add(this.tb_signOff);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_signOff);
            this.g_modifyViewTemplates.Controls.Add(this.tb_body);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_body);
            this.g_modifyViewTemplates.Controls.Add(this.tb_greeting);
            this.g_modifyViewTemplates.Controls.Add(this.tb_subject);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_templateName);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_subject);
            this.g_modifyViewTemplates.Controls.Add(this.tb_templateName);
            this.g_modifyViewTemplates.Controls.Add(this.lbl_greeting);
            this.g_modifyViewTemplates.Location = new System.Drawing.Point(148, 12);
            this.g_modifyViewTemplates.Name = "g_modifyViewTemplates";
            this.g_modifyViewTemplates.Size = new System.Drawing.Size(452, 284);
            this.g_modifyViewTemplates.TabIndex = 10;
            this.g_modifyViewTemplates.TabStop = false;
            this.g_modifyViewTemplates.Text = "Modify and View Template";
            // 
            // tb_signOff
            // 
            this.tb_signOff.Location = new System.Drawing.Point(118, 249);
            this.tb_signOff.Name = "tb_signOff";
            this.tb_signOff.ReadOnly = true;
            this.tb_signOff.Size = new System.Drawing.Size(289, 20);
            this.tb_signOff.TabIndex = 13;
            // 
            // lbl_signOff
            // 
            this.lbl_signOff.AutoSize = true;
            this.lbl_signOff.Location = new System.Drawing.Point(20, 252);
            this.lbl_signOff.Name = "lbl_signOff";
            this.lbl_signOff.Size = new System.Drawing.Size(48, 13);
            this.lbl_signOff.TabIndex = 12;
            this.lbl_signOff.Text = "Sign Off:";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(118, 111);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.ReadOnly = true;
            this.tb_body.Size = new System.Drawing.Size(289, 130);
            this.tb_body.TabIndex = 11;
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(18, 111);
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
            this.btn_close.Location = new System.Drawing.Point(12, 266);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(130, 32);
            this.btn_close.TabIndex = 57;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ViewTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 306);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.g_modifyViewTemplates);
            this.Controls.Add(this.lb_templates);
            this.Controls.Add(this.lbl_select);
            this.Name = "ViewTemplates";
            this.Text = "Modify and View Templates";
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
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.TextBox tb_greeting;
        private System.Windows.Forms.GroupBox g_modifyViewTemplates;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Label lbl_signOff;
        private System.Windows.Forms.TextBox tb_signOff;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel p_editToolbox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
    }
}