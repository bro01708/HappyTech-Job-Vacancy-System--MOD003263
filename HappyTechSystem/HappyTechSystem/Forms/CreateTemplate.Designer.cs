namespace HappyTechSystem
{
    partial class CreateTemplate
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
            this.lbl_body = new System.Windows.Forms.Label();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_templateID = new System.Windows.Forms.Label();
            this.tb_templateID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SNStatus = new System.Windows.Forms.Label();
            this.lbl_senderAdded = new System.Windows.Forms.Label();
            this.btn_addSenderName = new System.Windows.Forms.Button();
            this.lbl_FAStatus = new System.Windows.Forms.Label();
            this.lbl_JRStatus = new System.Windows.Forms.Label();
            this.lbl_INStatus = new System.Windows.Forms.Label();
            this.lbl_feedbackAdded = new System.Windows.Forms.Label();
            this.btn_addFeedback = new System.Windows.Forms.Button();
            this.lbl_roleAdded = new System.Windows.Forms.Label();
            this.btn_addRole = new System.Windows.Forms.Button();
            this.btn_addName = new System.Windows.Forms.Button();
            this.lbl_intervieweesNameAdded = new System.Windows.Forms.Label();
            this.lbl_reminder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(9, 103);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(34, 13);
            this.lbl_body.TabIndex = 2;
            this.lbl_body.Text = "Body:";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(49, 103);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_body.Size = new System.Drawing.Size(479, 321);
            this.tb_body.TabIndex = 3;
            this.tb_body.TextChanged += new System.EventHandler(this.CreateTemplateUnlocker);
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(181, 77);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 4;
            this.lbl_subject.Text = "Subject:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(233, 77);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(189, 20);
            this.tb_subject.TabIndex = 5;
            this.tb_subject.TextChanged += new System.EventHandler(this.CreateTemplateUnlocker);
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(8, 442);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(737, 43);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create Email Template";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(751, 442);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(66, 43);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(218, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name of Template (e.g. \"Accept\", \"Reject\"):";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(233, 51);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(116, 20);
            this.tb_name.TabIndex = 17;
            this.tb_name.TextChanged += new System.EventHandler(this.CreateTemplateUnlocker);
            // 
            // lbl_templateID
            // 
            this.lbl_templateID.AutoSize = true;
            this.lbl_templateID.Location = new System.Drawing.Point(9, 15);
            this.lbl_templateID.Name = "lbl_templateID";
            this.lbl_templateID.Size = new System.Drawing.Size(68, 13);
            this.lbl_templateID.TabIndex = 20;
            this.lbl_templateID.Text = "Template ID:";
            // 
            // tb_templateID
            // 
            this.tb_templateID.Location = new System.Drawing.Point(83, 12);
            this.tb_templateID.Name = "tb_templateID";
            this.tb_templateID.ReadOnly = true;
            this.tb_templateID.Size = new System.Drawing.Size(34, 20);
            this.tb_templateID.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_SNStatus);
            this.panel1.Controls.Add(this.lbl_senderAdded);
            this.panel1.Controls.Add(this.btn_addSenderName);
            this.panel1.Controls.Add(this.lbl_FAStatus);
            this.panel1.Controls.Add(this.lbl_JRStatus);
            this.panel1.Controls.Add(this.lbl_INStatus);
            this.panel1.Controls.Add(this.lbl_feedbackAdded);
            this.panel1.Controls.Add(this.btn_addFeedback);
            this.panel1.Controls.Add(this.lbl_roleAdded);
            this.panel1.Controls.Add(this.btn_addRole);
            this.panel1.Controls.Add(this.btn_addName);
            this.panel1.Controls.Add(this.lbl_intervieweesNameAdded);
            this.panel1.Controls.Add(this.lbl_reminder);
            this.panel1.Location = new System.Drawing.Point(534, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 190);
            this.panel1.TabIndex = 23;
            // 
            // lbl_SNStatus
            // 
            this.lbl_SNStatus.AutoSize = true;
            this.lbl_SNStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_SNStatus.Location = new System.Drawing.Point(214, 172);
            this.lbl_SNStatus.Name = "lbl_SNStatus";
            this.lbl_SNStatus.Size = new System.Drawing.Size(60, 13);
            this.lbl_SNStatus.TabIndex = 12;
            this.lbl_SNStatus.Text = "Not Found!";
            // 
            // lbl_senderAdded
            // 
            this.lbl_senderAdded.AutoSize = true;
            this.lbl_senderAdded.Location = new System.Drawing.Point(4, 172);
            this.lbl_senderAdded.Name = "lbl_senderAdded";
            this.lbl_senderAdded.Size = new System.Drawing.Size(146, 13);
            this.lbl_senderAdded.TabIndex = 11;
            this.lbl_senderAdded.Text = "Sender Name [SenderName]:";
            // 
            // btn_addSenderName
            // 
            this.btn_addSenderName.Location = new System.Drawing.Point(4, 146);
            this.btn_addSenderName.Name = "btn_addSenderName";
            this.btn_addSenderName.Size = new System.Drawing.Size(271, 23);
            this.btn_addSenderName.TabIndex = 10;
            this.btn_addSenderName.Text = "Insert Senders Name";
            this.btn_addSenderName.UseVisualStyleBackColor = true;
            this.btn_addSenderName.Click += new System.EventHandler(this.btn_addSenderName_Click);
            // 
            // lbl_FAStatus
            // 
            this.lbl_FAStatus.AutoSize = true;
            this.lbl_FAStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_FAStatus.Location = new System.Drawing.Point(214, 130);
            this.lbl_FAStatus.Name = "lbl_FAStatus";
            this.lbl_FAStatus.Size = new System.Drawing.Size(60, 13);
            this.lbl_FAStatus.TabIndex = 9;
            this.lbl_FAStatus.Text = "Not Found!";
            // 
            // lbl_JRStatus
            // 
            this.lbl_JRStatus.AutoSize = true;
            this.lbl_JRStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_JRStatus.Location = new System.Drawing.Point(214, 88);
            this.lbl_JRStatus.Name = "lbl_JRStatus";
            this.lbl_JRStatus.Size = new System.Drawing.Size(60, 13);
            this.lbl_JRStatus.TabIndex = 8;
            this.lbl_JRStatus.Text = "Not Found!";
            // 
            // lbl_INStatus
            // 
            this.lbl_INStatus.AutoSize = true;
            this.lbl_INStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_INStatus.Location = new System.Drawing.Point(214, 45);
            this.lbl_INStatus.Name = "lbl_INStatus";
            this.lbl_INStatus.Size = new System.Drawing.Size(60, 13);
            this.lbl_INStatus.TabIndex = 7;
            this.lbl_INStatus.Text = "Not Found!";
            // 
            // lbl_feedbackAdded
            // 
            this.lbl_feedbackAdded.AutoSize = true;
            this.lbl_feedbackAdded.Location = new System.Drawing.Point(4, 130);
            this.lbl_feedbackAdded.Name = "lbl_feedbackAdded";
            this.lbl_feedbackAdded.Size = new System.Drawing.Size(162, 13);
            this.lbl_feedbackAdded.TabIndex = 6;
            this.lbl_feedbackAdded.Text = "Feedback Area [FeedbackArea]:";
            // 
            // btn_addFeedback
            // 
            this.btn_addFeedback.Location = new System.Drawing.Point(3, 104);
            this.btn_addFeedback.Name = "btn_addFeedback";
            this.btn_addFeedback.Size = new System.Drawing.Size(271, 23);
            this.btn_addFeedback.TabIndex = 5;
            this.btn_addFeedback.Text = "Insert Feedback Area";
            this.btn_addFeedback.UseVisualStyleBackColor = true;
            this.btn_addFeedback.Click += new System.EventHandler(this.btn_addFeedback_Click);
            // 
            // lbl_roleAdded
            // 
            this.lbl_roleAdded.AutoSize = true;
            this.lbl_roleAdded.Location = new System.Drawing.Point(4, 88);
            this.lbl_roleAdded.Name = "lbl_roleAdded";
            this.lbl_roleAdded.Size = new System.Drawing.Size(100, 13);
            this.lbl_roleAdded.TabIndex = 4;
            this.lbl_roleAdded.Text = "Job Role [JobRole]:";
            // 
            // btn_addRole
            // 
            this.btn_addRole.Location = new System.Drawing.Point(7, 62);
            this.btn_addRole.Name = "btn_addRole";
            this.btn_addRole.Size = new System.Drawing.Size(267, 23);
            this.btn_addRole.TabIndex = 3;
            this.btn_addRole.Text = "Insert Job Role";
            this.btn_addRole.UseVisualStyleBackColor = true;
            this.btn_addRole.Click += new System.EventHandler(this.btn_addRole_Click);
            // 
            // btn_addName
            // 
            this.btn_addName.Location = new System.Drawing.Point(7, 21);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(267, 23);
            this.btn_addName.TabIndex = 2;
            this.btn_addName.Text = "Insert Interviewee\'s Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            this.btn_addName.Click += new System.EventHandler(this.btn_addName_Click);
            // 
            // lbl_intervieweesNameAdded
            // 
            this.lbl_intervieweesNameAdded.AutoSize = true;
            this.lbl_intervieweesNameAdded.Location = new System.Drawing.Point(4, 45);
            this.lbl_intervieweesNameAdded.Name = "lbl_intervieweesNameAdded";
            this.lbl_intervieweesNameAdded.Size = new System.Drawing.Size(192, 13);
            this.lbl_intervieweesNameAdded.TabIndex = 1;
            this.lbl_intervieweesNameAdded.Text = "Interviewee\'s Name [InterviewerName]:";
            // 
            // lbl_reminder
            // 
            this.lbl_reminder.AutoSize = true;
            this.lbl_reminder.Location = new System.Drawing.Point(4, 4);
            this.lbl_reminder.Name = "lbl_reminder";
            this.lbl_reminder.Size = new System.Drawing.Size(179, 13);
            this.lbl_reminder.TabIndex = 0;
            this.lbl_reminder.Text = "Remember to add the following tags:";
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_templateID);
            this.Controls.Add(this.lbl_templateID);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.tb_body);
            this.Controls.Add(this.lbl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateTemplate";
            this.Text = "Create an Email Template";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_templateID;
        private System.Windows.Forms.TextBox tb_templateID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_intervieweesNameAdded;
        private System.Windows.Forms.Label lbl_reminder;
        private System.Windows.Forms.Button btn_addName;
        private System.Windows.Forms.Label lbl_roleAdded;
        private System.Windows.Forms.Button btn_addRole;
        private System.Windows.Forms.Button btn_addFeedback;
        private System.Windows.Forms.Label lbl_FAStatus;
        private System.Windows.Forms.Label lbl_JRStatus;
        private System.Windows.Forms.Label lbl_INStatus;
        private System.Windows.Forms.Label lbl_feedbackAdded;
        private System.Windows.Forms.Button btn_addSenderName;
        private System.Windows.Forms.Label lbl_SNStatus;
        private System.Windows.Forms.Label lbl_senderAdded;
    }
}