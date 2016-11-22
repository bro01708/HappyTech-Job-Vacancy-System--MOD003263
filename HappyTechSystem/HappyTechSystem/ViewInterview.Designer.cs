namespace HappyTechSystem
{
    partial class ViewInterview
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
            this.lb_interviews = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_intervieweeName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_emailPreview = new System.Windows.Forms.Label();
            this.btn_cvOpen = new System.Windows.Forms.Button();
            this.gb_selectInterview = new System.Windows.Forms.GroupBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_interviewer = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_questionRanks = new System.Windows.Forms.ListBox();
            this.lbl_totalScore = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_intervieweeStatus = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_questionsAsked = new System.Windows.Forms.Label();
            this.gb_selectInterview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_interviews
            // 
            this.lb_interviews.FormattingEnabled = true;
            this.lb_interviews.Location = new System.Drawing.Point(6, 19);
            this.lb_interviews.Name = "lb_interviews";
            this.lb_interviews.Size = new System.Drawing.Size(179, 290);
            this.lb_interviews.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_intervieweeName
            // 
            this.lbl_intervieweeName.AutoSize = true;
            this.lbl_intervieweeName.Location = new System.Drawing.Point(273, 22);
            this.lbl_intervieweeName.Name = "lbl_intervieweeName";
            this.lbl_intervieweeName.Size = new System.Drawing.Size(96, 13);
            this.lbl_intervieweeName.TabIndex = 3;
            this.lbl_intervieweeName.Text = "Interviewee Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(376, 262);
            this.textBox2.TabIndex = 4;
            // 
            // lbl_emailPreview
            // 
            this.lbl_emailPreview.AutoSize = true;
            this.lbl_emailPreview.Location = new System.Drawing.Point(500, 19);
            this.lbl_emailPreview.Name = "lbl_emailPreview";
            this.lbl_emailPreview.Size = new System.Drawing.Size(76, 13);
            this.lbl_emailPreview.TabIndex = 5;
            this.lbl_emailPreview.Text = "Email Preview:";
            // 
            // btn_cvOpen
            // 
            this.btn_cvOpen.Enabled = false;
            this.btn_cvOpen.Location = new System.Drawing.Point(411, 32);
            this.btn_cvOpen.Name = "btn_cvOpen";
            this.btn_cvOpen.Size = new System.Drawing.Size(75, 31);
            this.btn_cvOpen.TabIndex = 6;
            this.btn_cvOpen.Text = "Open CV";
            this.btn_cvOpen.UseVisualStyleBackColor = true;
            // 
            // gb_selectInterview
            // 
            this.gb_selectInterview.Controls.Add(this.lbl_filter);
            this.gb_selectInterview.Controls.Add(this.lb_interviews);
            this.gb_selectInterview.Controls.Add(this.comboBox1);
            this.gb_selectInterview.Location = new System.Drawing.Point(12, 13);
            this.gb_selectInterview.Name = "gb_selectInterview";
            this.gb_selectInterview.Size = new System.Drawing.Size(196, 368);
            this.gb_selectInterview.TabIndex = 7;
            this.gb_selectInterview.TabStop = false;
            this.gb_selectInterview.Text = "Select Interview";
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Location = new System.Drawing.Point(19, 325);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(142, 13);
            this.lbl_filter.TabIndex = 9;
            this.lbl_filter.Text = "Filter Interviews by Vacancy:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(6, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "All";
            // 
            // lbl_interviewer
            // 
            this.lbl_interviewer.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbl_interviewer.AutoSize = true;
            this.lbl_interviewer.Location = new System.Drawing.Point(264, 70);
            this.lbl_interviewer.Name = "lbl_interviewer";
            this.lbl_interviewer.Size = new System.Drawing.Size(105, 13);
            this.lbl_interviewer.TabIndex = 9;
            this.lbl_interviewer.Text = "Name of Interviewer:";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox3.Location = new System.Drawing.Point(231, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 8;
            // 
            // lb_questionRanks
            // 
            this.lb_questionRanks.FormattingEnabled = true;
            this.lb_questionRanks.Location = new System.Drawing.Point(214, 166);
            this.lb_questionRanks.Name = "lb_questionRanks";
            this.lb_questionRanks.Size = new System.Drawing.Size(283, 264);
            this.lb_questionRanks.TabIndex = 10;
            // 
            // lbl_totalScore
            // 
            this.lbl_totalScore.AutoSize = true;
            this.lbl_totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalScore.Location = new System.Drawing.Point(548, 336);
            this.lbl_totalScore.Name = "lbl_totalScore";
            this.lbl_totalScore.Size = new System.Drawing.Size(237, 25);
            this.lbl_totalScore.TabIndex = 11;
            this.lbl_totalScore.Text = "Interviewee\'s Total Score:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(791, 336);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(48, 25);
            this.lbl_score.TabIndex = 12;
            this.lbl_score.Text = "???";
            // 
            // lbl_intervieweeStatus
            // 
            this.lbl_intervieweeStatus.AutoSize = true;
            this.lbl_intervieweeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervieweeStatus.Location = new System.Drawing.Point(548, 371);
            this.lbl_intervieweeStatus.Name = "lbl_intervieweeStatus";
            this.lbl_intervieweeStatus.Size = new System.Drawing.Size(178, 25);
            this.lbl_intervieweeStatus.TabIndex = 13;
            this.lbl_intervieweeStatus.Text = "Interviewee Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(791, 371);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 25);
            this.lbl_status.TabIndex = 14;
            this.lbl_status.Text = "???";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(18, 388);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(179, 42);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // lbl_questionsAsked
            // 
            this.lbl_questionsAsked.AutoSize = true;
            this.lbl_questionsAsked.Location = new System.Drawing.Point(273, 150);
            this.lbl_questionsAsked.Name = "lbl_questionsAsked";
            this.lbl_questionsAsked.Size = new System.Drawing.Size(144, 13);
            this.lbl_questionsAsked.TabIndex = 16;
            this.lbl_questionsAsked.Text = "Questions Asked + Rankings";
            // 
            // ViewInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 438);
            this.Controls.Add(this.lbl_questionsAsked);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_intervieweeStatus);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_totalScore);
            this.Controls.Add(this.lb_questionRanks);
            this.Controls.Add(this.lbl_interviewer);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.gb_selectInterview);
            this.Controls.Add(this.lbl_emailPreview);
            this.Controls.Add(this.btn_cvOpen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_intervieweeName);
            this.Controls.Add(this.textBox1);
            this.Name = "ViewInterview";
            this.Text = "View Interviews";
            this.gb_selectInterview.ResumeLayout(false);
            this.gb_selectInterview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_interviews;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_intervieweeName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_emailPreview;
        private System.Windows.Forms.Button btn_cvOpen;
        private System.Windows.Forms.GroupBox gb_selectInterview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Label lbl_interviewer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lb_questionRanks;
        private System.Windows.Forms.Label lbl_totalScore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_intervieweeStatus;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_questionsAsked;
    }
}