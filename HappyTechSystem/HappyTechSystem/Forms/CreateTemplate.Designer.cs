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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(10, 91);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(34, 13);
            this.lbl_body.TabIndex = 2;
            this.lbl_body.Text = "Body:";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(61, 88);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(371, 130);
            this.tb_body.TabIndex = 3;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(10, 65);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 4;
            this.lbl_subject.Text = "Subject:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(61, 62);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(189, 20);
            this.tb_subject.TabIndex = 5;
            // 
            // btn_addName
            // 
            this.btn_addName.Location = new System.Drawing.Point(438, 112);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(153, 22);
            this.btn_addName.TabIndex = 6;
            this.btn_addName.Text = "Insert Interviewee\'s Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            // 
            // btn_position
            // 
            this.btn_position.Location = new System.Drawing.Point(438, 140);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(153, 22);
            this.btn_position.TabIndex = 7;
            this.btn_position.Text = "Insert Position";
            this.btn_position.UseVisualStyleBackColor = true;
            // 
            // btn_feedback
            // 
            this.btn_feedback.Location = new System.Drawing.Point(438, 168);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(118, 22);
            this.btn_feedback.TabIndex = 8;
            this.btn_feedback.Text = "Insert Feedback Area";
            this.btn_feedback.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(12, 224);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(590, 43);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create Email Template";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(519, 5);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(83, 40);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_feedbackHelp
            // 
            this.btn_feedbackHelp.Location = new System.Drawing.Point(562, 168);
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
            this.lbl_name.Location = new System.Drawing.Point(209, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(218, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name of Template (e.g. \"Accept\", \"Reject\"):";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(249, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(116, 20);
            this.tb_name.TabIndex = 17;
            // 
            // btn_insertGreeting
            // 
            this.btn_insertGreeting.Location = new System.Drawing.Point(438, 84);
            this.btn_insertGreeting.Name = "btn_insertGreeting";
            this.btn_insertGreeting.Size = new System.Drawing.Size(153, 22);
            this.btn_insertGreeting.TabIndex = 18;
            this.btn_insertGreeting.Text = "Insert Greeting";
            this.btn_insertGreeting.UseVisualStyleBackColor = true;
            // 
            // btn_insertSignOff
            // 
            this.btn_insertSignOff.Location = new System.Drawing.Point(438, 196);
            this.btn_insertSignOff.Name = "btn_insertSignOff";
            this.btn_insertSignOff.Size = new System.Drawing.Size(153, 22);
            this.btn_insertSignOff.TabIndex = 19;
            this.btn_insertSignOff.Text = "Insert Sign Off";
            this.btn_insertSignOff.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 21;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_templateID);
            this.Controls.Add(this.btn_insertSignOff);
            this.Controls.Add(this.btn_insertGreeting);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_feedbackHelp);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.btn_position);
            this.Controls.Add(this.btn_addName);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.tb_body);
            this.Controls.Add(this.lbl_body);
            this.Name = "CreateTemplate";
            this.Text = "Create an Email Template";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}