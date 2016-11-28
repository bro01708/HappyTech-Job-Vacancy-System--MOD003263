namespace HappyTechSystem
{
    partial class ConductInterview
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
            this.components = new System.ComponentModel.Container();
            this.cb_vacancy = new System.Windows.Forms.ComboBox();
            this.lbl_vacancy = new System.Windows.Forms.Label();
            this.p_questions = new System.Windows.Forms.Panel();
            this.btn_interviewHelp = new System.Windows.Forms.Button();
            this.lbl_extraNotes = new System.Windows.Forms.Label();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.cb_rank5 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cb_rank4 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cb_rank3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cb_rank2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_questionID = new System.Windows.Forms.TextBox();
            this.lbl_questionID = new System.Windows.Forms.Label();
            this.cb_rank1 = new System.Windows.Forms.CheckBox();
            this.tb_rank1 = new System.Windows.Forms.TextBox();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.btn_previousQuestion = new System.Windows.Forms.Button();
            this.tb_questionText = new System.Windows.Forms.TextBox();
            this.btn_complete = new System.Windows.Forms.Button();
            this.lbl_applicantName = new System.Windows.Forms.Label();
            this.btn_beginInterview = new System.Windows.Forms.Button();
            this.lbl_interviewerName = new System.Windows.Forms.Label();
            this.tb_interviewerName = new System.Windows.Forms.TextBox();
            this.tb_applicantName = new System.Windows.Forms.TextBox();
            this.lbl_attachCV = new System.Windows.Forms.Label();
            this.tb_cvPath = new System.Windows.Forms.TextBox();
            this.btn_browseCV = new System.Windows.Forms.Button();
            this.btn_beginHelp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.p_setup = new System.Windows.Forms.Panel();
            this.beginInterviewCheck = new System.Windows.Forms.Timer(this.components);
            this.p_questions.SuspendLayout();
            this.p_setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_vacancy
            // 
            this.cb_vacancy.FormattingEnabled = true;
            this.cb_vacancy.Location = new System.Drawing.Point(232, 7);
            this.cb_vacancy.Name = "cb_vacancy";
            this.cb_vacancy.Size = new System.Drawing.Size(121, 21);
            this.cb_vacancy.TabIndex = 0;
            this.cb_vacancy.SelectedIndexChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // lbl_vacancy
            // 
            this.lbl_vacancy.AutoSize = true;
            this.lbl_vacancy.Location = new System.Drawing.Point(16, 14);
            this.lbl_vacancy.Name = "lbl_vacancy";
            this.lbl_vacancy.Size = new System.Drawing.Size(210, 13);
            this.lbl_vacancy.TabIndex = 1;
            this.lbl_vacancy.Text = "Choose a vacancy to use for this interview:";
            // 
            // p_questions
            // 
            this.p_questions.Controls.Add(this.btn_interviewHelp);
            this.p_questions.Controls.Add(this.lbl_extraNotes);
            this.p_questions.Controls.Add(this.tb_notes);
            this.p_questions.Controls.Add(this.cb_rank5);
            this.p_questions.Controls.Add(this.textBox5);
            this.p_questions.Controls.Add(this.cb_rank4);
            this.p_questions.Controls.Add(this.textBox4);
            this.p_questions.Controls.Add(this.cb_rank3);
            this.p_questions.Controls.Add(this.textBox3);
            this.p_questions.Controls.Add(this.cb_rank2);
            this.p_questions.Controls.Add(this.textBox2);
            this.p_questions.Controls.Add(this.tb_questionID);
            this.p_questions.Controls.Add(this.lbl_questionID);
            this.p_questions.Controls.Add(this.cb_rank1);
            this.p_questions.Controls.Add(this.tb_rank1);
            this.p_questions.Controls.Add(this.btn_nextQuestion);
            this.p_questions.Controls.Add(this.btn_previousQuestion);
            this.p_questions.Controls.Add(this.tb_questionText);
            this.p_questions.Enabled = false;
            this.p_questions.Location = new System.Drawing.Point(33, 157);
            this.p_questions.Name = "p_questions";
            this.p_questions.Size = new System.Drawing.Size(755, 347);
            this.p_questions.TabIndex = 2;
            // 
            // btn_interviewHelp
            // 
            this.btn_interviewHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_interviewHelp.Location = new System.Drawing.Point(713, 10);
            this.btn_interviewHelp.Name = "btn_interviewHelp";
            this.btn_interviewHelp.Size = new System.Drawing.Size(33, 33);
            this.btn_interviewHelp.TabIndex = 24;
            this.btn_interviewHelp.Text = "?";
            this.btn_interviewHelp.UseVisualStyleBackColor = true;
            this.btn_interviewHelp.Click += new System.EventHandler(this.btn_interviewHelp_Click);
            // 
            // lbl_extraNotes
            // 
            this.lbl_extraNotes.AutoSize = true;
            this.lbl_extraNotes.Location = new System.Drawing.Point(248, 261);
            this.lbl_extraNotes.Name = "lbl_extraNotes";
            this.lbl_extraNotes.Size = new System.Drawing.Size(262, 13);
            this.lbl_extraNotes.TabIndex = 17;
            this.lbl_extraNotes.Text = "Add any additional notes about the interviewee below:";
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(184, 280);
            this.tb_notes.Multiline = true;
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(386, 56);
            this.tb_notes.TabIndex = 16;
            // 
            // cb_rank5
            // 
            this.cb_rank5.AutoSize = true;
            this.cb_rank5.Location = new System.Drawing.Point(627, 149);
            this.cb_rank5.Name = "cb_rank5";
            this.cb_rank5.Size = new System.Drawing.Size(91, 17);
            this.cb_rank5.TabIndex = 15;
            this.cb_rank5.Text = "Rank 5 (Best)";
            this.cb_rank5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(603, 172);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(143, 66);
            this.textBox5.TabIndex = 14;
            // 
            // cb_rank4
            // 
            this.cb_rank4.AutoSize = true;
            this.cb_rank4.Location = new System.Drawing.Point(474, 149);
            this.cb_rank4.Name = "cb_rank4";
            this.cb_rank4.Size = new System.Drawing.Size(96, 17);
            this.cb_rank4.TabIndex = 13;
            this.cb_rank4.Text = "Rank 4 (Great)";
            this.cb_rank4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(454, 172);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(143, 66);
            this.textBox4.TabIndex = 12;
            // 
            // cb_rank3
            // 
            this.cb_rank3.AutoSize = true;
            this.cb_rank3.Location = new System.Drawing.Point(316, 149);
            this.cb_rank3.Name = "cb_rank3";
            this.cb_rank3.Size = new System.Drawing.Size(116, 17);
            this.cb_rank3.TabIndex = 11;
            this.cb_rank3.Text = "Rank 3 (Adequete)";
            this.cb_rank3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(305, 172);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(143, 66);
            this.textBox3.TabIndex = 10;
            // 
            // cb_rank2
            // 
            this.cb_rank2.AutoSize = true;
            this.cb_rank2.Location = new System.Drawing.Point(170, 149);
            this.cb_rank2.Name = "cb_rank2";
            this.cb_rank2.Size = new System.Drawing.Size(114, 17);
            this.cb_rank2.TabIndex = 9;
            this.cb_rank2.Text = "Rank 2 (Mediocre)";
            this.cb_rank2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(143, 66);
            this.textBox2.TabIndex = 8;
            // 
            // tb_questionID
            // 
            this.tb_questionID.Location = new System.Drawing.Point(106, 7);
            this.tb_questionID.Name = "tb_questionID";
            this.tb_questionID.ReadOnly = true;
            this.tb_questionID.Size = new System.Drawing.Size(25, 20);
            this.tb_questionID.TabIndex = 7;
            // 
            // lbl_questionID
            // 
            this.lbl_questionID.AutoSize = true;
            this.lbl_questionID.Location = new System.Drawing.Point(4, 10);
            this.lbl_questionID.Name = "lbl_questionID";
            this.lbl_questionID.Size = new System.Drawing.Size(96, 13);
            this.lbl_questionID.TabIndex = 6;
            this.lbl_questionID.Text = "Current Question #";
            // 
            // cb_rank1
            // 
            this.cb_rank1.AutoSize = true;
            this.cb_rank1.Location = new System.Drawing.Point(33, 149);
            this.cb_rank1.Name = "cb_rank1";
            this.cb_rank1.Size = new System.Drawing.Size(98, 17);
            this.cb_rank1.TabIndex = 5;
            this.cb_rank1.Text = "Rank 1 (Worst)";
            this.cb_rank1.UseVisualStyleBackColor = true;
            // 
            // tb_rank1
            // 
            this.tb_rank1.Location = new System.Drawing.Point(7, 172);
            this.tb_rank1.Multiline = true;
            this.tb_rank1.Name = "tb_rank1";
            this.tb_rank1.ReadOnly = true;
            this.tb_rank1.Size = new System.Drawing.Size(143, 66);
            this.tb_rank1.TabIndex = 4;
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Location = new System.Drawing.Point(576, 55);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(94, 54);
            this.btn_nextQuestion.TabIndex = 2;
            this.btn_nextQuestion.Text = "Next Question";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_previousQuestion
            // 
            this.btn_previousQuestion.Location = new System.Drawing.Point(84, 55);
            this.btn_previousQuestion.Name = "btn_previousQuestion";
            this.btn_previousQuestion.Size = new System.Drawing.Size(94, 54);
            this.btn_previousQuestion.TabIndex = 1;
            this.btn_previousQuestion.Text = "Previous Question";
            this.btn_previousQuestion.UseVisualStyleBackColor = true;
            // 
            // tb_questionText
            // 
            this.tb_questionText.Location = new System.Drawing.Point(184, 31);
            this.tb_questionText.Multiline = true;
            this.tb_questionText.Name = "tb_questionText";
            this.tb_questionText.ReadOnly = true;
            this.tb_questionText.Size = new System.Drawing.Size(386, 102);
            this.tb_questionText.TabIndex = 0;
            // 
            // btn_complete
            // 
            this.btn_complete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_complete.Enabled = false;
            this.btn_complete.Location = new System.Drawing.Point(256, 508);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(298, 49);
            this.btn_complete.TabIndex = 3;
            this.btn_complete.Text = "Complete Interview";
            this.btn_complete.UseVisualStyleBackColor = true;
            // 
            // lbl_applicantName
            // 
            this.lbl_applicantName.AutoSize = true;
            this.lbl_applicantName.Location = new System.Drawing.Point(16, 43);
            this.lbl_applicantName.Name = "lbl_applicantName";
            this.lbl_applicantName.Size = new System.Drawing.Size(110, 13);
            this.lbl_applicantName.TabIndex = 4;
            this.lbl_applicantName.Text = "Enter applicant name:";
            // 
            // btn_beginInterview
            // 
            this.btn_beginInterview.Enabled = false;
            this.btn_beginInterview.Location = new System.Drawing.Point(242, 108);
            this.btn_beginInterview.Name = "btn_beginInterview";
            this.btn_beginInterview.Size = new System.Drawing.Size(255, 24);
            this.btn_beginInterview.TabIndex = 16;
            this.btn_beginInterview.Text = "Begin Interview";
            this.btn_beginInterview.UseVisualStyleBackColor = true;
            this.btn_beginInterview.Click += new System.EventHandler(this.btn_beginInterview_Click);
            // 
            // lbl_interviewerName
            // 
            this.lbl_interviewerName.AutoSize = true;
            this.lbl_interviewerName.Location = new System.Drawing.Point(16, 77);
            this.lbl_interviewerName.Name = "lbl_interviewerName";
            this.lbl_interviewerName.Size = new System.Drawing.Size(143, 13);
            this.lbl_interviewerName.TabIndex = 17;
            this.lbl_interviewerName.Text = "Enter the interviewer\'s name:";
            // 
            // tb_interviewerName
            // 
            this.tb_interviewerName.Location = new System.Drawing.Point(165, 74);
            this.tb_interviewerName.Name = "tb_interviewerName";
            this.tb_interviewerName.Size = new System.Drawing.Size(188, 20);
            this.tb_interviewerName.TabIndex = 18;
            this.tb_interviewerName.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // tb_applicantName
            // 
            this.tb_applicantName.Location = new System.Drawing.Point(165, 40);
            this.tb_applicantName.Name = "tb_applicantName";
            this.tb_applicantName.Size = new System.Drawing.Size(188, 20);
            this.tb_applicantName.TabIndex = 19;
            this.tb_applicantName.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // lbl_attachCV
            // 
            this.lbl_attachCV.AutoSize = true;
            this.lbl_attachCV.Location = new System.Drawing.Point(369, 43);
            this.lbl_attachCV.Name = "lbl_attachCV";
            this.lbl_attachCV.Size = new System.Drawing.Size(58, 13);
            this.lbl_attachCV.TabIndex = 20;
            this.lbl_attachCV.Text = "Attach CV:";
            // 
            // tb_cvPath
            // 
            this.tb_cvPath.Location = new System.Drawing.Point(433, 39);
            this.tb_cvPath.Name = "tb_cvPath";
            this.tb_cvPath.ReadOnly = true;
            this.tb_cvPath.Size = new System.Drawing.Size(224, 20);
            this.tb_cvPath.TabIndex = 21;
            this.tb_cvPath.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // btn_browseCV
            // 
            this.btn_browseCV.Location = new System.Drawing.Point(663, 37);
            this.btn_browseCV.Name = "btn_browseCV";
            this.btn_browseCV.Size = new System.Drawing.Size(38, 23);
            this.btn_browseCV.TabIndex = 22;
            this.btn_browseCV.Text = "...";
            this.btn_browseCV.UseVisualStyleBackColor = true;
            this.btn_browseCV.Click += new System.EventHandler(this.btn_browseCV_Click);
            // 
            // btn_beginHelp
            // 
            this.btn_beginHelp.Location = new System.Drawing.Point(503, 108);
            this.btn_beginHelp.Name = "btn_beginHelp";
            this.btn_beginHelp.Size = new System.Drawing.Size(27, 24);
            this.btn_beginHelp.TabIndex = 23;
            this.btn_beginHelp.Text = "?";
            this.btn_beginHelp.UseVisualStyleBackColor = true;
            this.btn_beginHelp.Click += new System.EventHandler(this.btn_beginHelp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // p_setup
            // 
            this.p_setup.Controls.Add(this.btn_beginHelp);
            this.p_setup.Controls.Add(this.lbl_vacancy);
            this.p_setup.Controls.Add(this.btn_browseCV);
            this.p_setup.Controls.Add(this.cb_vacancy);
            this.p_setup.Controls.Add(this.tb_cvPath);
            this.p_setup.Controls.Add(this.lbl_applicantName);
            this.p_setup.Controls.Add(this.lbl_attachCV);
            this.p_setup.Controls.Add(this.btn_beginInterview);
            this.p_setup.Controls.Add(this.tb_applicantName);
            this.p_setup.Controls.Add(this.lbl_interviewerName);
            this.p_setup.Controls.Add(this.tb_interviewerName);
            this.p_setup.Location = new System.Drawing.Point(33, 12);
            this.p_setup.Name = "p_setup";
            this.p_setup.Size = new System.Drawing.Size(755, 139);
            this.p_setup.TabIndex = 24;
            // 
            // beginInterviewCheck
            // 
            this.beginInterviewCheck.Enabled = true;
            // 
            // ConductInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 562);
            this.Controls.Add(this.p_setup);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.p_questions);
            this.Name = "ConductInterview";
            this.Text = "Conduct an Interview";
            this.p_questions.ResumeLayout(false);
            this.p_questions.PerformLayout();
            this.p_setup.ResumeLayout(false);
            this.p_setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_vacancy;
        private System.Windows.Forms.Label lbl_vacancy;
        private System.Windows.Forms.Panel p_questions;
        private System.Windows.Forms.CheckBox cb_rank1;
        private System.Windows.Forms.TextBox tb_rank1;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Button btn_previousQuestion;
        private System.Windows.Forms.TextBox tb_questionText;
        private System.Windows.Forms.TextBox tb_questionID;
        private System.Windows.Forms.Label lbl_questionID;
        private System.Windows.Forms.CheckBox cb_rank5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox cb_rank4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox cb_rank3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox cb_rank2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Label lbl_applicantName;
        private System.Windows.Forms.Button btn_beginInterview;
        private System.Windows.Forms.Label lbl_interviewerName;
        private System.Windows.Forms.TextBox tb_interviewerName;
        private System.Windows.Forms.TextBox tb_applicantName;
        private System.Windows.Forms.Label lbl_attachCV;
        private System.Windows.Forms.Label lbl_extraNotes;
        private System.Windows.Forms.TextBox tb_notes;
        private System.Windows.Forms.TextBox tb_cvPath;
        private System.Windows.Forms.Button btn_browseCV;
        private System.Windows.Forms.Button btn_beginHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel p_setup;
        private System.Windows.Forms.Button btn_interviewHelp;
        private System.Windows.Forms.Timer beginInterviewCheck;
    }
}