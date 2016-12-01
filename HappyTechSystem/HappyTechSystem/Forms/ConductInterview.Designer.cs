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
            this.vacancyBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_vacancy = new System.Windows.Forms.Label();
            this.p_questions = new System.Windows.Forms.Panel();
            this.rb_rank5 = new System.Windows.Forms.RadioButton();
            this.rb_rank4 = new System.Windows.Forms.RadioButton();
            this.rb_rank3 = new System.Windows.Forms.RadioButton();
            this.rb_rank2 = new System.Windows.Forms.RadioButton();
            this.rb_rank1 = new System.Windows.Forms.RadioButton();
            this.tb_questionCount = new System.Windows.Forms.TextBox();
            this.lbl_outof = new System.Windows.Forms.Label();
            this.btn_interviewHelp = new System.Windows.Forms.Button();
            this.lbl_extraNotes = new System.Windows.Forms.Label();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.tb_rank5 = new System.Windows.Forms.TextBox();
            this.tb_rank4 = new System.Windows.Forms.TextBox();
            this.tb_rank3 = new System.Windows.Forms.TextBox();
            this.tb_rank2 = new System.Windows.Forms.TextBox();
            this.tb_questionIndex = new System.Windows.Forms.TextBox();
            this.lbl_questionID = new System.Windows.Forms.Label();
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
            this.lbl_interviewID = new System.Windows.Forms.Label();
            this.tb_interviewID = new System.Windows.Forms.TextBox();
            this.cb_title = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBankBindingSource)).BeginInit();
            this.p_questions.SuspendLayout();
            this.p_setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_vacancy
            // 
            this.cb_vacancy.DataSource = this.vacancyBankBindingSource;
            this.cb_vacancy.FormattingEnabled = true;
            this.cb_vacancy.Location = new System.Drawing.Point(220, 8);
            this.cb_vacancy.Name = "cb_vacancy";
            this.cb_vacancy.Size = new System.Drawing.Size(193, 21);
            this.cb_vacancy.TabIndex = 0;
            this.cb_vacancy.SelectedIndexChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // vacancyBankBindingSource
            // 
            this.vacancyBankBindingSource.DataSource = typeof(HappyTechSystem.Core.VacancyBank);
            // 
            // lbl_vacancy
            // 
            this.lbl_vacancy.AutoSize = true;
            this.lbl_vacancy.Location = new System.Drawing.Point(4, 11);
            this.lbl_vacancy.Name = "lbl_vacancy";
            this.lbl_vacancy.Size = new System.Drawing.Size(210, 13);
            this.lbl_vacancy.TabIndex = 1;
            this.lbl_vacancy.Text = "Choose a vacancy to use for this interview:";
            // 
            // p_questions
            // 
            this.p_questions.Controls.Add(this.rb_rank5);
            this.p_questions.Controls.Add(this.rb_rank4);
            this.p_questions.Controls.Add(this.rb_rank3);
            this.p_questions.Controls.Add(this.rb_rank2);
            this.p_questions.Controls.Add(this.rb_rank1);
            this.p_questions.Controls.Add(this.tb_questionCount);
            this.p_questions.Controls.Add(this.lbl_outof);
            this.p_questions.Controls.Add(this.btn_interviewHelp);
            this.p_questions.Controls.Add(this.lbl_extraNotes);
            this.p_questions.Controls.Add(this.tb_notes);
            this.p_questions.Controls.Add(this.tb_rank5);
            this.p_questions.Controls.Add(this.tb_rank4);
            this.p_questions.Controls.Add(this.tb_rank3);
            this.p_questions.Controls.Add(this.tb_rank2);
            this.p_questions.Controls.Add(this.tb_questionIndex);
            this.p_questions.Controls.Add(this.lbl_questionID);
            this.p_questions.Controls.Add(this.tb_rank1);
            this.p_questions.Controls.Add(this.btn_nextQuestion);
            this.p_questions.Controls.Add(this.btn_previousQuestion);
            this.p_questions.Controls.Add(this.tb_questionText);
            this.p_questions.Enabled = false;
            this.p_questions.Location = new System.Drawing.Point(12, 186);
            this.p_questions.Name = "p_questions";
            this.p_questions.Size = new System.Drawing.Size(956, 342);
            this.p_questions.TabIndex = 2;
            // 
            // rb_rank5
            // 
            this.rb_rank5.AutoSize = true;
            this.rb_rank5.Location = new System.Drawing.Point(806, 149);
            this.rb_rank5.Name = "rb_rank5";
            this.rb_rank5.Size = new System.Drawing.Size(90, 17);
            this.rb_rank5.TabIndex = 31;
            this.rb_rank5.TabStop = true;
            this.rb_rank5.Text = "Rank 5 (Best)";
            this.rb_rank5.UseVisualStyleBackColor = true;
            this.rb_rank5.CheckedChanged += new System.EventHandler(this.rb_rank5_CheckedChanged);
            // 
            // rb_rank4
            // 
            this.rb_rank4.AutoSize = true;
            this.rb_rank4.Location = new System.Drawing.Point(614, 149);
            this.rb_rank4.Name = "rb_rank4";
            this.rb_rank4.Size = new System.Drawing.Size(95, 17);
            this.rb_rank4.TabIndex = 30;
            this.rb_rank4.TabStop = true;
            this.rb_rank4.Text = "Rank 4 (Good)";
            this.rb_rank4.UseVisualStyleBackColor = true;
            this.rb_rank4.CheckedChanged += new System.EventHandler(this.rb_rank4_CheckedChanged);
            // 
            // rb_rank3
            // 
            this.rb_rank3.AutoSize = true;
            this.rb_rank3.Location = new System.Drawing.Point(418, 149);
            this.rb_rank3.Name = "rb_rank3";
            this.rb_rank3.Size = new System.Drawing.Size(113, 17);
            this.rb_rank3.TabIndex = 29;
            this.rb_rank3.TabStop = true;
            this.rb_rank3.Text = "Rank 3 (Mediocre)";
            this.rb_rank3.UseVisualStyleBackColor = true;
            this.rb_rank3.CheckedChanged += new System.EventHandler(this.rb_rank3_CheckedChanged);
            // 
            // rb_rank2
            // 
            this.rb_rank2.AutoSize = true;
            this.rb_rank2.Location = new System.Drawing.Point(242, 149);
            this.rb_rank2.Name = "rb_rank2";
            this.rb_rank2.Size = new System.Drawing.Size(91, 17);
            this.rb_rank2.TabIndex = 28;
            this.rb_rank2.TabStop = true;
            this.rb_rank2.Text = "Rank 2 (Poor)";
            this.rb_rank2.UseVisualStyleBackColor = true;
            this.rb_rank2.CheckedChanged += new System.EventHandler(this.rb_rank2_CheckedChanged);
            // 
            // rb_rank1
            // 
            this.rb_rank1.AutoSize = true;
            this.rb_rank1.Location = new System.Drawing.Point(53, 149);
            this.rb_rank1.Name = "rb_rank1";
            this.rb_rank1.Size = new System.Drawing.Size(97, 17);
            this.rb_rank1.TabIndex = 27;
            this.rb_rank1.TabStop = true;
            this.rb_rank1.Text = "Rank 1 (Worst)";
            this.rb_rank1.UseVisualStyleBackColor = true;
            this.rb_rank1.CheckedChanged += new System.EventHandler(this.rb_rank1_CheckedChanged);
            // 
            // tb_questionCount
            // 
            this.tb_questionCount.Location = new System.Drawing.Point(153, 7);
            this.tb_questionCount.Name = "tb_questionCount";
            this.tb_questionCount.ReadOnly = true;
            this.tb_questionCount.Size = new System.Drawing.Size(25, 20);
            this.tb_questionCount.TabIndex = 26;
            // 
            // lbl_outof
            // 
            this.lbl_outof.AutoSize = true;
            this.lbl_outof.Location = new System.Drawing.Point(134, 10);
            this.lbl_outof.Name = "lbl_outof";
            this.lbl_outof.Size = new System.Drawing.Size(16, 13);
            this.lbl_outof.TabIndex = 25;
            this.lbl_outof.Text = "of";
            // 
            // btn_interviewHelp
            // 
            this.btn_interviewHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_interviewHelp.Location = new System.Drawing.Point(881, 10);
            this.btn_interviewHelp.Name = "btn_interviewHelp";
            this.btn_interviewHelp.Size = new System.Drawing.Size(62, 33);
            this.btn_interviewHelp.TabIndex = 24;
            this.btn_interviewHelp.Text = "?";
            this.btn_interviewHelp.UseVisualStyleBackColor = true;
            this.btn_interviewHelp.Click += new System.EventHandler(this.btn_interviewHelp_Click);
            // 
            // lbl_extraNotes
            // 
            this.lbl_extraNotes.AutoSize = true;
            this.lbl_extraNotes.Location = new System.Drawing.Point(352, 261);
            this.lbl_extraNotes.Name = "lbl_extraNotes";
            this.lbl_extraNotes.Size = new System.Drawing.Size(262, 13);
            this.lbl_extraNotes.TabIndex = 17;
            this.lbl_extraNotes.Text = "Add any additional notes about the interviewee below:";
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(281, 277);
            this.tb_notes.Multiline = true;
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_notes.Size = new System.Drawing.Size(386, 56);
            this.tb_notes.TabIndex = 16;
            // 
            // tb_rank5
            // 
            this.tb_rank5.Location = new System.Drawing.Point(761, 172);
            this.tb_rank5.Multiline = true;
            this.tb_rank5.Name = "tb_rank5";
            this.tb_rank5.ReadOnly = true;
            this.tb_rank5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rank5.Size = new System.Drawing.Size(182, 79);
            this.tb_rank5.TabIndex = 14;
            // 
            // tb_rank4
            // 
            this.tb_rank4.Location = new System.Drawing.Point(573, 172);
            this.tb_rank4.Multiline = true;
            this.tb_rank4.Name = "tb_rank4";
            this.tb_rank4.ReadOnly = true;
            this.tb_rank4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rank4.Size = new System.Drawing.Size(182, 79);
            this.tb_rank4.TabIndex = 12;
            // 
            // tb_rank3
            // 
            this.tb_rank3.Location = new System.Drawing.Point(385, 172);
            this.tb_rank3.Multiline = true;
            this.tb_rank3.Name = "tb_rank3";
            this.tb_rank3.ReadOnly = true;
            this.tb_rank3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rank3.Size = new System.Drawing.Size(182, 79);
            this.tb_rank3.TabIndex = 10;
            // 
            // tb_rank2
            // 
            this.tb_rank2.Location = new System.Drawing.Point(195, 172);
            this.tb_rank2.Multiline = true;
            this.tb_rank2.Name = "tb_rank2";
            this.tb_rank2.ReadOnly = true;
            this.tb_rank2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rank2.Size = new System.Drawing.Size(182, 79);
            this.tb_rank2.TabIndex = 8;
            // 
            // tb_questionIndex
            // 
            this.tb_questionIndex.Location = new System.Drawing.Point(106, 7);
            this.tb_questionIndex.Name = "tb_questionIndex";
            this.tb_questionIndex.ReadOnly = true;
            this.tb_questionIndex.Size = new System.Drawing.Size(25, 20);
            this.tb_questionIndex.TabIndex = 7;
            this.tb_questionIndex.UseWaitCursor = true;
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
            // tb_rank1
            // 
            this.tb_rank1.Location = new System.Drawing.Point(7, 172);
            this.tb_rank1.Multiline = true;
            this.tb_rank1.Name = "tb_rank1";
            this.tb_rank1.ReadOnly = true;
            this.tb_rank1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rank1.Size = new System.Drawing.Size(182, 79);
            this.tb_rank1.TabIndex = 4;
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Location = new System.Drawing.Point(682, 52);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(94, 54);
            this.btn_nextQuestion.TabIndex = 2;
            this.btn_nextQuestion.Text = "Next Question";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // btn_previousQuestion
            // 
            this.btn_previousQuestion.Location = new System.Drawing.Point(133, 52);
            this.btn_previousQuestion.Name = "btn_previousQuestion";
            this.btn_previousQuestion.Size = new System.Drawing.Size(94, 54);
            this.btn_previousQuestion.TabIndex = 1;
            this.btn_previousQuestion.Text = "Previous Question";
            this.btn_previousQuestion.UseVisualStyleBackColor = true;
            this.btn_previousQuestion.Click += new System.EventHandler(this.btn_previousQuestion_Click);
            // 
            // tb_questionText
            // 
            this.tb_questionText.Location = new System.Drawing.Point(233, 28);
            this.tb_questionText.Multiline = true;
            this.tb_questionText.Name = "tb_questionText";
            this.tb_questionText.ReadOnly = true;
            this.tb_questionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_questionText.Size = new System.Drawing.Size(443, 102);
            this.tb_questionText.TabIndex = 0;
            // 
            // btn_complete
            // 
            this.btn_complete.Enabled = false;
            this.btn_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.Location = new System.Drawing.Point(342, 525);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(298, 49);
            this.btn_complete.TabIndex = 3;
            this.btn_complete.Text = "Complete Interview";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // lbl_applicantName
            // 
            this.lbl_applicantName.AutoSize = true;
            this.lbl_applicantName.Location = new System.Drawing.Point(39, 89);
            this.lbl_applicantName.Name = "lbl_applicantName";
            this.lbl_applicantName.Size = new System.Drawing.Size(133, 13);
            this.lbl_applicantName.TabIndex = 4;
            this.lbl_applicantName.Text = "Enter applicant\'s full name:";
            // 
            // btn_beginInterview
            // 
            this.btn_beginInterview.Enabled = false;
            this.btn_beginInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beginInterview.Location = new System.Drawing.Point(509, 57);
            this.btn_beginInterview.Name = "btn_beginInterview";
            this.btn_beginInterview.Size = new System.Drawing.Size(227, 42);
            this.btn_beginInterview.TabIndex = 16;
            this.btn_beginInterview.Text = "Begin Interview";
            this.btn_beginInterview.UseVisualStyleBackColor = true;
            this.btn_beginInterview.Click += new System.EventHandler(this.btn_beginInterview_Click);
            // 
            // lbl_interviewerName
            // 
            this.lbl_interviewerName.AutoSize = true;
            this.lbl_interviewerName.Location = new System.Drawing.Point(39, 37);
            this.lbl_interviewerName.Name = "lbl_interviewerName";
            this.lbl_interviewerName.Size = new System.Drawing.Size(143, 13);
            this.lbl_interviewerName.TabIndex = 17;
            this.lbl_interviewerName.Text = "Enter the interviewer\'s name:";
            // 
            // tb_interviewerName
            // 
            this.tb_interviewerName.Location = new System.Drawing.Point(220, 34);
            this.tb_interviewerName.Name = "tb_interviewerName";
            this.tb_interviewerName.Size = new System.Drawing.Size(238, 20);
            this.tb_interviewerName.TabIndex = 18;
            this.tb_interviewerName.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // tb_applicantName
            // 
            this.tb_applicantName.Location = new System.Drawing.Point(220, 86);
            this.tb_applicantName.Name = "tb_applicantName";
            this.tb_applicantName.Size = new System.Drawing.Size(239, 20);
            this.tb_applicantName.TabIndex = 19;
            this.tb_applicantName.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // lbl_attachCV
            // 
            this.lbl_attachCV.AutoSize = true;
            this.lbl_attachCV.Location = new System.Drawing.Point(39, 141);
            this.lbl_attachCV.Name = "lbl_attachCV";
            this.lbl_attachCV.Size = new System.Drawing.Size(112, 13);
            this.lbl_attachCV.TabIndex = 20;
            this.lbl_attachCV.Text = "Attach Applicant\'s CV:";
            // 
            // tb_cvPath
            // 
            this.tb_cvPath.Location = new System.Drawing.Point(220, 138);
            this.tb_cvPath.Name = "tb_cvPath";
            this.tb_cvPath.ReadOnly = true;
            this.tb_cvPath.Size = new System.Drawing.Size(239, 20);
            this.tb_cvPath.TabIndex = 21;
            this.tb_cvPath.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // btn_browseCV
            // 
            this.btn_browseCV.Location = new System.Drawing.Point(465, 138);
            this.btn_browseCV.Name = "btn_browseCV";
            this.btn_browseCV.Size = new System.Drawing.Size(25, 20);
            this.btn_browseCV.TabIndex = 22;
            this.btn_browseCV.Text = "...";
            this.btn_browseCV.UseVisualStyleBackColor = true;
            this.btn_browseCV.Click += new System.EventHandler(this.btn_browseCV_Click);
            // 
            // btn_beginHelp
            // 
            this.btn_beginHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beginHelp.Location = new System.Drawing.Point(564, 105);
            this.btn_beginHelp.Name = "btn_beginHelp";
            this.btn_beginHelp.Size = new System.Drawing.Size(115, 23);
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
            this.p_setup.Controls.Add(this.lbl_interviewID);
            this.p_setup.Controls.Add(this.tb_interviewID);
            this.p_setup.Controls.Add(this.cb_title);
            this.p_setup.Controls.Add(this.lbl_title);
            this.p_setup.Controls.Add(this.tb_email);
            this.p_setup.Controls.Add(this.lbl_email);
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
            this.p_setup.Location = new System.Drawing.Point(118, 12);
            this.p_setup.Name = "p_setup";
            this.p_setup.Size = new System.Drawing.Size(755, 168);
            this.p_setup.TabIndex = 24;
            // 
            // lbl_interviewID
            // 
            this.lbl_interviewID.AutoSize = true;
            this.lbl_interviewID.Location = new System.Drawing.Point(640, 6);
            this.lbl_interviewID.Name = "lbl_interviewID";
            this.lbl_interviewID.Size = new System.Drawing.Size(67, 13);
            this.lbl_interviewID.TabIndex = 29;
            this.lbl_interviewID.Text = "Interview ID:";
            // 
            // tb_interviewID
            // 
            this.tb_interviewID.Location = new System.Drawing.Point(713, 3);
            this.tb_interviewID.Name = "tb_interviewID";
            this.tb_interviewID.ReadOnly = true;
            this.tb_interviewID.Size = new System.Drawing.Size(32, 20);
            this.tb_interviewID.TabIndex = 28;
            // 
            // cb_title
            // 
            this.cb_title.FormattingEnabled = true;
            this.cb_title.Items.AddRange(new object[] {
            "Mr",
            "Miss",
            "Mrs"});
            this.cb_title.Location = new System.Drawing.Point(220, 60);
            this.cb_title.Name = "cb_title";
            this.cb_title.Size = new System.Drawing.Size(52, 21);
            this.cb_title.TabIndex = 27;
            this.cb_title.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(39, 63);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(114, 13);
            this.lbl_title.TabIndex = 26;
            this.lbl_title.Text = "Select Applicant\'s Title";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(221, 112);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(192, 20);
            this.tb_email.TabIndex = 25;
            this.tb_email.TextChanged += new System.EventHandler(this.ConductInterviewUnlocker);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(39, 115);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(175, 13);
            this.lbl_email.TabIndex = 24;
            this.lbl_email.Text = "Enter the applicant\'s Email Address:";
            // 
            // ConductInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 581);
            this.Controls.Add(this.p_setup);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.p_questions);
            this.Name = "ConductInterview";
            this.Text = "Conduct an Interview";
            this.Load += new System.EventHandler(this.ConductInterview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBankBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tb_rank1;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Button btn_previousQuestion;
        private System.Windows.Forms.TextBox tb_questionText;
        private System.Windows.Forms.TextBox tb_questionIndex;
        private System.Windows.Forms.Label lbl_questionID;
        private System.Windows.Forms.TextBox tb_rank5;
        private System.Windows.Forms.TextBox tb_rank4;
        private System.Windows.Forms.TextBox tb_rank3;
        private System.Windows.Forms.TextBox tb_rank2;
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
        private System.Windows.Forms.BindingSource vacancyBankBindingSource;
        private System.Windows.Forms.TextBox tb_questionCount;
        private System.Windows.Forms.Label lbl_outof;
        private System.Windows.Forms.RadioButton rb_rank5;
        private System.Windows.Forms.RadioButton rb_rank4;
        private System.Windows.Forms.RadioButton rb_rank3;
        private System.Windows.Forms.RadioButton rb_rank2;
        private System.Windows.Forms.RadioButton rb_rank1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cb_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_interviewID;
        private System.Windows.Forms.TextBox tb_interviewID;
    }
}