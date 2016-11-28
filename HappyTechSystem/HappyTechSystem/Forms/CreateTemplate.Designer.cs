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
            this.btn_addName = new System.Windows.Forms.Button();
            this.btn_position = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_feedbackHelp = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_insertGreeting = new System.Windows.Forms.Button();
            this.btn_insertSignOff = new System.Windows.Forms.Button();
            this.lbl_templateID = new System.Windows.Forms.Label();
            this.tb_templateID = new System.Windows.Forms.TextBox();
            this.btn_removeGreeting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tb_body.Size = new System.Drawing.Size(479, 321);
            this.tb_body.TabIndex = 3;
            this.tb_body.TextChanged += new System.EventHandler(this.CreateTemplateUnlocker);
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(183, 77);
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
            // btn_addName
            // 
            this.btn_addName.Location = new System.Drawing.Point(3, 42);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(153, 22);
            this.btn_addName.TabIndex = 6;
            this.btn_addName.Text = "Insert Interviewee\'s Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            this.btn_addName.Click += new System.EventHandler(this.btn_addName_Click);
            // 
            // btn_position
            // 
            this.btn_position.Location = new System.Drawing.Point(3, 70);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(153, 22);
            this.btn_position.TabIndex = 7;
            this.btn_position.Text = "Insert Position";
            this.btn_position.UseVisualStyleBackColor = true;
            this.btn_position.Click += new System.EventHandler(this.btn_position_Click);
            // 
            // btn_feedback
            // 
            this.btn_feedback.Location = new System.Drawing.Point(3, 98);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(118, 22);
            this.btn_feedback.TabIndex = 8;
            this.btn_feedback.Text = "Insert Feedback Area";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(8, 442);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(646, 43);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create Email Template";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(660, 445);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(66, 40);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_feedbackHelp
            // 
            this.btn_feedbackHelp.Location = new System.Drawing.Point(127, 98);
            this.btn_feedbackHelp.Name = "btn_feedbackHelp";
            this.btn_feedbackHelp.Size = new System.Drawing.Size(29, 22);
            this.btn_feedbackHelp.TabIndex = 15;
            this.btn_feedbackHelp.Text = "?";
            this.btn_feedbackHelp.UseVisualStyleBackColor = true;
            this.btn_feedbackHelp.Click += new System.EventHandler(this.btn_feedbackHelp_Click);
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
            // btn_insertGreeting
            // 
            this.btn_insertGreeting.Location = new System.Drawing.Point(3, 14);
            this.btn_insertGreeting.Name = "btn_insertGreeting";
            this.btn_insertGreeting.Size = new System.Drawing.Size(153, 22);
            this.btn_insertGreeting.TabIndex = 18;
            this.btn_insertGreeting.Text = "Insert Greeting";
            this.btn_insertGreeting.UseVisualStyleBackColor = true;
            this.btn_insertGreeting.Click += new System.EventHandler(this.btn_insertGreeting_Click);
            // 
            // btn_insertSignOff
            // 
            this.btn_insertSignOff.Location = new System.Drawing.Point(3, 126);
            this.btn_insertSignOff.Name = "btn_insertSignOff";
            this.btn_insertSignOff.Size = new System.Drawing.Size(153, 22);
            this.btn_insertSignOff.TabIndex = 19;
            this.btn_insertSignOff.Text = "Insert Sign Off";
            this.btn_insertSignOff.UseVisualStyleBackColor = true;
            this.btn_insertSignOff.Click += new System.EventHandler(this.btn_insertSignOff_Click);
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
            // btn_removeGreeting
            // 
            this.btn_removeGreeting.Location = new System.Drawing.Point(162, 14);
            this.btn_removeGreeting.Name = "btn_removeGreeting";
            this.btn_removeGreeting.Size = new System.Drawing.Size(30, 22);
            this.btn_removeGreeting.TabIndex = 22;
            this.btn_removeGreeting.Text = "[R]";
            this.btn_removeGreeting.UseVisualStyleBackColor = true;
            this.btn_removeGreeting.Click += new System.EventHandler(this.btn_removeGreeting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_insertGreeting);
            this.panel1.Controls.Add(this.btn_removeGreeting);
            this.panel1.Controls.Add(this.btn_addName);
            this.panel1.Controls.Add(this.btn_position);
            this.panel1.Controls.Add(this.btn_feedback);
            this.panel1.Controls.Add(this.btn_insertSignOff);
            this.panel1.Controls.Add(this.btn_feedbackHelp);
            this.panel1.Location = new System.Drawing.Point(534, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 151);
            this.panel1.TabIndex = 23;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 490);
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
            this.Name = "CreateTemplate";
            this.Text = "Create an Email Template";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_addName;
        private System.Windows.Forms.Button btn_position;
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_feedbackHelp;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_insertGreeting;
        private System.Windows.Forms.Button btn_insertSignOff;
        private System.Windows.Forms.Label lbl_templateID;
        private System.Windows.Forms.TextBox tb_templateID;
        private System.Windows.Forms.Button btn_removeGreeting;
        private System.Windows.Forms.Panel panel1;
    }
}