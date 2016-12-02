namespace HappyTechSystem
{
    partial class ViewQuestionBank
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
            this.lb_Q = new System.Windows.Forms.ListBox();
            this.lbl_questionID = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.p_editToolbox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_questionID = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_questionText = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.cb_filterCategories = new System.Windows.Forms.ComboBox();
            this.lbl_questionFilter = new System.Windows.Forms.Label();
            this.p_respFeed = new System.Windows.Forms.Panel();
            this.gb_feedback = new System.Windows.Forms.GroupBox();
            this.tb_feedback5 = new System.Windows.Forms.TextBox();
            this.tb_feedback3 = new System.Windows.Forms.TextBox();
            this.tb_feedback1 = new System.Windows.Forms.TextBox();
            this.tb_feedback4 = new System.Windows.Forms.TextBox();
            this.tb_feedback2 = new System.Windows.Forms.TextBox();
            this.gb_responses = new System.Windows.Forms.GroupBox();
            this.tb_response2 = new System.Windows.Forms.TextBox();
            this.tb_response1 = new System.Windows.Forms.TextBox();
            this.tb_response4 = new System.Windows.Forms.TextBox();
            this.tb_response5 = new System.Windows.Forms.TextBox();
            this.tb_response3 = new System.Windows.Forms.TextBox();
            this.lbl_rank5 = new System.Windows.Forms.Label();
            this.lbl_rank4 = new System.Windows.Forms.Label();
            this.lbl_rank3 = new System.Windows.Forms.Label();
            this.lbl_rank1 = new System.Windows.Forms.Label();
            this.lbl_rank2 = new System.Windows.Forms.Label();
            this.cb_categoryTag = new System.Windows.Forms.ComboBox();
            this.p_editToolbox.SuspendLayout();
            this.p_respFeed.SuspendLayout();
            this.gb_feedback.SuspendLayout();
            this.gb_responses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Q
            // 
            this.lb_Q.FormattingEnabled = true;
            this.lb_Q.Location = new System.Drawing.Point(12, 39);
            this.lb_Q.Name = "lb_Q";
            this.lb_Q.Size = new System.Drawing.Size(639, 160);
            this.lb_Q.TabIndex = 0;
            this.lb_Q.SelectedIndexChanged += new System.EventHandler(this.lb_Q_SelectedIndexChanged);
            // 
            // lbl_questionID
            // 
            this.lbl_questionID.AutoSize = true;
            this.lbl_questionID.Location = new System.Drawing.Point(9, 15);
            this.lbl_questionID.Name = "lbl_questionID";
            this.lbl_questionID.Size = new System.Drawing.Size(170, 13);
            this.lbl_questionID.TabIndex = 1;
            this.lbl_questionID.Text = "Pick a question from the list below:";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(66, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 48);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete Question";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(1155, 39);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 48);
            this.btn_edit.TabIndex = 51;
            this.btn_edit.Text = "Toggle Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 497);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(1242, 32);
            this.btn_close.TabIndex = 52;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Location = new System.Drawing.Point(0, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 48);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // p_editToolbox
            // 
            this.p_editToolbox.Controls.Add(this.btn_delete);
            this.p_editToolbox.Controls.Add(this.btn_save);
            this.p_editToolbox.Location = new System.Drawing.Point(1122, 102);
            this.p_editToolbox.Name = "p_editToolbox";
            this.p_editToolbox.Size = new System.Drawing.Size(132, 50);
            this.p_editToolbox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Question ID";
            // 
            // tb_questionID
            // 
            this.tb_questionID.Location = new System.Drawing.Point(727, 12);
            this.tb_questionID.Name = "tb_questionID";
            this.tb_questionID.ReadOnly = true;
            this.tb_questionID.Size = new System.Drawing.Size(28, 20);
            this.tb_questionID.TabIndex = 57;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(767, 15);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(71, 13);
            this.lbl_category.TabIndex = 58;
            this.lbl_category.Text = "Category Tag";
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.AutoSize = true;
            this.lbl_questionText.Location = new System.Drawing.Point(658, 47);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(76, 13);
            this.lbl_questionText.TabIndex = 59;
            this.lbl_questionText.Text = "Question Text:";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(661, 66);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_question.Size = new System.Drawing.Size(455, 133);
            this.tb_question.TabIndex = 60;
            // 
            // cb_filterCategories
            // 
            this.cb_filterCategories.FormattingEnabled = true;
            this.cb_filterCategories.Location = new System.Drawing.Point(527, 12);
            this.cb_filterCategories.Name = "cb_filterCategories";
            this.cb_filterCategories.Size = new System.Drawing.Size(121, 21);
            this.cb_filterCategories.TabIndex = 79;
            this.cb_filterCategories.SelectedIndexChanged += new System.EventHandler(this.cb_filterCategories_SelectedIndexChanged);
            // 
            // lbl_questionFilter
            // 
            this.lbl_questionFilter.AutoSize = true;
            this.lbl_questionFilter.Location = new System.Drawing.Point(427, 15);
            this.lbl_questionFilter.Name = "lbl_questionFilter";
            this.lbl_questionFilter.Size = new System.Drawing.Size(94, 13);
            this.lbl_questionFilter.TabIndex = 80;
            this.lbl_questionFilter.Text = "Filter questions by:";
            // 
            // p_respFeed
            // 
            this.p_respFeed.Controls.Add(this.gb_feedback);
            this.p_respFeed.Controls.Add(this.gb_responses);
            this.p_respFeed.Controls.Add(this.lbl_rank5);
            this.p_respFeed.Controls.Add(this.lbl_rank4);
            this.p_respFeed.Controls.Add(this.lbl_rank3);
            this.p_respFeed.Controls.Add(this.lbl_rank1);
            this.p_respFeed.Controls.Add(this.lbl_rank2);
            this.p_respFeed.Location = new System.Drawing.Point(12, 205);
            this.p_respFeed.Name = "p_respFeed";
            this.p_respFeed.Size = new System.Drawing.Size(1242, 286);
            this.p_respFeed.TabIndex = 81;
            // 
            // gb_feedback
            // 
            this.gb_feedback.Controls.Add(this.tb_feedback5);
            this.gb_feedback.Controls.Add(this.tb_feedback3);
            this.gb_feedback.Controls.Add(this.tb_feedback1);
            this.gb_feedback.Controls.Add(this.tb_feedback4);
            this.gb_feedback.Controls.Add(this.tb_feedback2);
            this.gb_feedback.Location = new System.Drawing.Point(3, 164);
            this.gb_feedback.Name = "gb_feedback";
            this.gb_feedback.Size = new System.Drawing.Size(1226, 118);
            this.gb_feedback.TabIndex = 31;
            this.gb_feedback.TabStop = false;
            this.gb_feedback.Text = "Feedback (for Emails)";
            // 
            // tb_feedback5
            // 
            this.tb_feedback5.Location = new System.Drawing.Point(978, 19);
            this.tb_feedback5.Multiline = true;
            this.tb_feedback5.Name = "tb_feedback5";
            this.tb_feedback5.ReadOnly = true;
            this.tb_feedback5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback5.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback5.TabIndex = 16;
            // 
            // tb_feedback3
            // 
            this.tb_feedback3.Location = new System.Drawing.Point(492, 19);
            this.tb_feedback3.Multiline = true;
            this.tb_feedback3.Name = "tb_feedback3";
            this.tb_feedback3.ReadOnly = true;
            this.tb_feedback3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback3.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback3.TabIndex = 12;
            // 
            // tb_feedback1
            // 
            this.tb_feedback1.Location = new System.Drawing.Point(6, 19);
            this.tb_feedback1.Multiline = true;
            this.tb_feedback1.Name = "tb_feedback1";
            this.tb_feedback1.ReadOnly = true;
            this.tb_feedback1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback1.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback1.TabIndex = 8;
            // 
            // tb_feedback4
            // 
            this.tb_feedback4.Location = new System.Drawing.Point(735, 19);
            this.tb_feedback4.Multiline = true;
            this.tb_feedback4.Name = "tb_feedback4";
            this.tb_feedback4.ReadOnly = true;
            this.tb_feedback4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback4.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback4.TabIndex = 14;
            // 
            // tb_feedback2
            // 
            this.tb_feedback2.Location = new System.Drawing.Point(249, 19);
            this.tb_feedback2.Multiline = true;
            this.tb_feedback2.Name = "tb_feedback2";
            this.tb_feedback2.ReadOnly = true;
            this.tb_feedback2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback2.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback2.TabIndex = 10;
            // 
            // gb_responses
            // 
            this.gb_responses.Controls.Add(this.tb_response2);
            this.gb_responses.Controls.Add(this.tb_response1);
            this.gb_responses.Controls.Add(this.tb_response4);
            this.gb_responses.Controls.Add(this.tb_response5);
            this.gb_responses.Controls.Add(this.tb_response3);
            this.gb_responses.Location = new System.Drawing.Point(3, 29);
            this.gb_responses.Name = "gb_responses";
            this.gb_responses.Size = new System.Drawing.Size(1226, 129);
            this.gb_responses.TabIndex = 30;
            this.gb_responses.TabStop = false;
            this.gb_responses.Text = "Response Criteria";
            // 
            // tb_response2
            // 
            this.tb_response2.Location = new System.Drawing.Point(249, 31);
            this.tb_response2.Multiline = true;
            this.tb_response2.Name = "tb_response2";
            this.tb_response2.ReadOnly = true;
            this.tb_response2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response2.Size = new System.Drawing.Size(237, 84);
            this.tb_response2.TabIndex = 9;
            // 
            // tb_response1
            // 
            this.tb_response1.Location = new System.Drawing.Point(6, 31);
            this.tb_response1.Multiline = true;
            this.tb_response1.Name = "tb_response1";
            this.tb_response1.ReadOnly = true;
            this.tb_response1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response1.Size = new System.Drawing.Size(237, 84);
            this.tb_response1.TabIndex = 7;
            // 
            // tb_response4
            // 
            this.tb_response4.Location = new System.Drawing.Point(735, 31);
            this.tb_response4.Multiline = true;
            this.tb_response4.Name = "tb_response4";
            this.tb_response4.ReadOnly = true;
            this.tb_response4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response4.Size = new System.Drawing.Size(237, 84);
            this.tb_response4.TabIndex = 13;
            // 
            // tb_response5
            // 
            this.tb_response5.Location = new System.Drawing.Point(978, 31);
            this.tb_response5.Multiline = true;
            this.tb_response5.Name = "tb_response5";
            this.tb_response5.ReadOnly = true;
            this.tb_response5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response5.Size = new System.Drawing.Size(237, 84);
            this.tb_response5.TabIndex = 15;
            // 
            // tb_response3
            // 
            this.tb_response3.Location = new System.Drawing.Point(492, 31);
            this.tb_response3.Multiline = true;
            this.tb_response3.Name = "tb_response3";
            this.tb_response3.ReadOnly = true;
            this.tb_response3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response3.Size = new System.Drawing.Size(237, 84);
            this.tb_response3.TabIndex = 11;
            // 
            // lbl_rank5
            // 
            this.lbl_rank5.AutoSize = true;
            this.lbl_rank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank5.Location = new System.Drawing.Point(1044, 8);
            this.lbl_rank5.Name = "lbl_rank5";
            this.lbl_rank5.Size = new System.Drawing.Size(112, 18);
            this.lbl_rank5.TabIndex = 23;
            this.lbl_rank5.Text = "Rank 5 (Best)";
            // 
            // lbl_rank4
            // 
            this.lbl_rank4.AutoSize = true;
            this.lbl_rank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank4.Location = new System.Drawing.Point(792, 8);
            this.lbl_rank4.Name = "lbl_rank4";
            this.lbl_rank4.Size = new System.Drawing.Size(120, 18);
            this.lbl_rank4.TabIndex = 22;
            this.lbl_rank4.Text = "Rank 4 (Good)";
            // 
            // lbl_rank3
            // 
            this.lbl_rank3.AutoSize = true;
            this.lbl_rank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank3.Location = new System.Drawing.Point(537, 8);
            this.lbl_rank3.Name = "lbl_rank3";
            this.lbl_rank3.Size = new System.Drawing.Size(148, 18);
            this.lbl_rank3.TabIndex = 21;
            this.lbl_rank3.Text = "Rank 3 (Mediocre)";
            // 
            // lbl_rank1
            // 
            this.lbl_rank1.AutoSize = true;
            this.lbl_rank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank1.Location = new System.Drawing.Point(59, 8);
            this.lbl_rank1.Name = "lbl_rank1";
            this.lbl_rank1.Size = new System.Drawing.Size(124, 18);
            this.lbl_rank1.TabIndex = 19;
            this.lbl_rank1.Text = "Rank 1 (Worst)";
            // 
            // lbl_rank2
            // 
            this.lbl_rank2.AutoSize = true;
            this.lbl_rank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank2.Location = new System.Drawing.Point(309, 8);
            this.lbl_rank2.Name = "lbl_rank2";
            this.lbl_rank2.Size = new System.Drawing.Size(115, 18);
            this.lbl_rank2.TabIndex = 20;
            this.lbl_rank2.Text = "Rank 2 (Poor)";
            // 
            // cb_categoryTag
            // 
            this.cb_categoryTag.Enabled = false;
            this.cb_categoryTag.FormattingEnabled = true;
            this.cb_categoryTag.Location = new System.Drawing.Point(844, 11);
            this.cb_categoryTag.Name = "cb_categoryTag";
            this.cb_categoryTag.Size = new System.Drawing.Size(100, 21);
            this.cb_categoryTag.TabIndex = 82;
            // 
            // ViewQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 536);
            this.Controls.Add(this.cb_categoryTag);
            this.Controls.Add(this.p_respFeed);
            this.Controls.Add(this.lbl_questionFilter);
            this.Controls.Add(this.cb_filterCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_questionID);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_questionText);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_questionID);
            this.Controls.Add(this.lb_Q);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewQuestionBank";
            this.Text = "Modify and View Question Bank";
            this.Load += new System.EventHandler(this.ViewQuestionBank_Load);
            this.p_editToolbox.ResumeLayout(false);
            this.p_respFeed.ResumeLayout(false);
            this.p_respFeed.PerformLayout();
            this.gb_feedback.ResumeLayout(false);
            this.gb_feedback.PerformLayout();
            this.gb_responses.ResumeLayout(false);
            this.gb_responses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Q;
        private System.Windows.Forms.Label lbl_questionID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel p_editToolbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_questionID;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_questionText;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.ComboBox cb_filterCategories;
        private System.Windows.Forms.Label lbl_questionFilter;
        private System.Windows.Forms.Panel p_respFeed;
        private System.Windows.Forms.GroupBox gb_feedback;
        private System.Windows.Forms.TextBox tb_feedback5;
        private System.Windows.Forms.TextBox tb_feedback3;
        private System.Windows.Forms.TextBox tb_feedback1;
        private System.Windows.Forms.TextBox tb_feedback4;
        private System.Windows.Forms.TextBox tb_feedback2;
        private System.Windows.Forms.GroupBox gb_responses;
        private System.Windows.Forms.TextBox tb_response2;
        private System.Windows.Forms.TextBox tb_response1;
        private System.Windows.Forms.TextBox tb_response4;
        private System.Windows.Forms.TextBox tb_response5;
        private System.Windows.Forms.TextBox tb_response3;
        private System.Windows.Forms.Label lbl_rank5;
        private System.Windows.Forms.Label lbl_rank4;
        private System.Windows.Forms.Label lbl_rank3;
        private System.Windows.Forms.Label lbl_rank1;
        private System.Windows.Forms.Label lbl_rank2;
        private System.Windows.Forms.ComboBox cb_categoryTag;
    }
}