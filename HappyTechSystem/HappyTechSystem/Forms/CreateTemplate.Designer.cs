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
            this.tb_greeting = new System.Windows.Forms.TextBox();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_addName = new System.Windows.Forms.Button();
            this.btn_position = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.lbl_signOff = new System.Windows.Forms.Label();
            this.tb_signOff = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_help = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_help2 = new System.Windows.Forms.Label();
            this.btn_feedbackHelp = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_greeting
            // 
            this.tb_greeting.Location = new System.Drawing.Point(63, 148);
            this.tb_greeting.Name = "tb_greeting";
            this.tb_greeting.Size = new System.Drawing.Size(289, 20);
            this.tb_greeting.TabIndex = 0;
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Location = new System.Drawing.Point(12, 151);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(50, 13);
            this.lbl_greeting.TabIndex = 1;
            this.lbl_greeting.Text = "Greeting:";
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(12, 177);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(34, 13);
            this.lbl_body.TabIndex = 2;
            this.lbl_body.Text = "Body:";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(63, 174);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(371, 130);
            this.tb_body.TabIndex = 3;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(12, 125);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 4;
            this.lbl_subject.Text = "Subject:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(63, 122);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(116, 20);
            this.tb_subject.TabIndex = 5;
            // 
            // btn_addName
            // 
            this.btn_addName.Location = new System.Drawing.Point(450, 172);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(153, 22);
            this.btn_addName.TabIndex = 6;
            this.btn_addName.Text = "Insert Interviewee\'s Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            // 
            // btn_position
            // 
            this.btn_position.Location = new System.Drawing.Point(450, 201);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(153, 22);
            this.btn_position.TabIndex = 7;
            this.btn_position.Text = "Insert Position";
            this.btn_position.UseVisualStyleBackColor = true;
            // 
            // btn_feedback
            // 
            this.btn_feedback.Location = new System.Drawing.Point(450, 230);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(118, 22);
            this.btn_feedback.TabIndex = 8;
            this.btn_feedback.Text = "Insert Feedback Area";
            this.btn_feedback.UseVisualStyleBackColor = true;
            // 
            // lbl_signOff
            // 
            this.lbl_signOff.AutoSize = true;
            this.lbl_signOff.Location = new System.Drawing.Point(12, 314);
            this.lbl_signOff.Name = "lbl_signOff";
            this.lbl_signOff.Size = new System.Drawing.Size(48, 13);
            this.lbl_signOff.TabIndex = 9;
            this.lbl_signOff.Text = "Sign Off:";
            // 
            // tb_signOff
            // 
            this.tb_signOff.Location = new System.Drawing.Point(63, 314);
            this.tb_signOff.Name = "tb_signOff";
            this.tb_signOff.Size = new System.Drawing.Size(289, 20);
            this.tb_signOff.TabIndex = 10;
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(12, 346);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(590, 43);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create Email Template";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help.Location = new System.Drawing.Point(14, 12);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(411, 18);
            this.lbl_help.TabIndex = 12;
            this.lbl_help.Text = "Use the controls below to create your email template.";
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
            // lbl_help2
            // 
            this.lbl_help2.AutoSize = true;
            this.lbl_help2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help2.Location = new System.Drawing.Point(14, 41);
            this.lbl_help2.Name = "lbl_help2";
            this.lbl_help2.Size = new System.Drawing.Size(333, 18);
            this.lbl_help2.TabIndex = 14;
            this.lbl_help2.Text = "Click the \"?\" button if you need further help!";
            // 
            // btn_feedbackHelp
            // 
            this.btn_feedbackHelp.Location = new System.Drawing.Point(574, 230);
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
            this.lbl_name.Location = new System.Drawing.Point(35, 82);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(218, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name of Template (e.g. \"Accept\", \"Reject\"):";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(259, 79);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(116, 20);
            this.tb_name.TabIndex = 17;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 400);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_feedbackHelp);
            this.Controls.Add(this.lbl_help2);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_signOff);
            this.Controls.Add(this.lbl_signOff);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.btn_position);
            this.Controls.Add(this.btn_addName);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.tb_body);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_greeting);
            this.Controls.Add(this.tb_greeting);
            this.Name = "CreateTemplate";
            this.Text = "Create an Email Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_greeting;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_addName;
        private System.Windows.Forms.Button btn_position;
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.Label lbl_signOff;
        private System.Windows.Forms.TextBox tb_signOff;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_help2;
        private System.Windows.Forms.Button btn_feedbackHelp;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
    }
}