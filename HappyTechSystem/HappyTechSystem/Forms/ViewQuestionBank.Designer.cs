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
            this.tb_categoryTag = new System.Windows.Forms.TextBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lbl_rank5 = new System.Windows.Forms.Label();
            this.tb_response1 = new System.Windows.Forms.TextBox();
            this.lbl_rank4 = new System.Windows.Forms.Label();
            this.tb_feedback1 = new System.Windows.Forms.TextBox();
            this.lbl_rank3 = new System.Windows.Forms.Label();
            this.tb_response2 = new System.Windows.Forms.TextBox();
            this.lbl_rank2 = new System.Windows.Forms.Label();
            this.tb_feedback2 = new System.Windows.Forms.TextBox();
            this.lbl_rank1 = new System.Windows.Forms.Label();
            this.tb_response3 = new System.Windows.Forms.TextBox();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.tb_feedback3 = new System.Windows.Forms.TextBox();
            this.lbl_response = new System.Windows.Forms.Label();
            this.tb_response4 = new System.Windows.Forms.TextBox();
            this.tb_feedback5 = new System.Windows.Forms.TextBox();
            this.tb_feedback4 = new System.Windows.Forms.TextBox();
            this.tb_response5 = new System.Windows.Forms.TextBox();
            this.cb_filterCategories = new System.Windows.Forms.ComboBox();
            this.lbl_questionFilter = new System.Windows.Forms.Label();
            this.p_editToolbox.SuspendLayout();
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
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(0, 51);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 48);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete Question";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(585, 235);
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
            this.btn_close.Location = new System.Drawing.Point(9, 614);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(639, 32);
            this.btn_close.TabIndex = 52;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(0, 0);
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
            this.p_editToolbox.Location = new System.Drawing.Point(585, 289);
            this.p_editToolbox.Name = "p_editToolbox";
            this.p_editToolbox.Size = new System.Drawing.Size(63, 100);
            this.p_editToolbox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Question ID";
            // 
            // tb_questionID
            // 
            this.tb_questionID.Location = new System.Drawing.Point(91, 250);
            this.tb_questionID.Name = "tb_questionID";
            this.tb_questionID.ReadOnly = true;
            this.tb_questionID.Size = new System.Drawing.Size(28, 20);
            this.tb_questionID.TabIndex = 57;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(14, 276);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(71, 13);
            this.lbl_category.TabIndex = 58;
            this.lbl_category.Text = "Category Tag";
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.AutoSize = true;
            this.lbl_questionText.Location = new System.Drawing.Point(204, 219);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(76, 13);
            this.lbl_questionText.TabIndex = 59;
            this.lbl_questionText.Text = "Question Text:";
            // 
            // tb_categoryTag
            // 
            this.tb_categoryTag.Location = new System.Drawing.Point(91, 273);
            this.tb_categoryTag.Name = "tb_categoryTag";
            this.tb_categoryTag.ReadOnly = true;
            this.tb_categoryTag.Size = new System.Drawing.Size(100, 20);
            this.tb_categoryTag.TabIndex = 78;
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(207, 235);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(360, 99);
            this.tb_question.TabIndex = 60;
            // 
            // lbl_rank5
            // 
            this.lbl_rank5.AutoSize = true;
            this.lbl_rank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank5.Location = new System.Drawing.Point(18, 565);
            this.lbl_rank5.Name = "lbl_rank5";
            this.lbl_rank5.Size = new System.Drawing.Size(112, 18);
            this.lbl_rank5.TabIndex = 77;
            this.lbl_rank5.Text = "Rank 5 (Best)";
            // 
            // tb_response1
            // 
            this.tb_response1.Location = new System.Drawing.Point(191, 367);
            this.tb_response1.Multiline = true;
            this.tb_response1.Name = "tb_response1";
            this.tb_response1.ReadOnly = true;
            this.tb_response1.Size = new System.Drawing.Size(185, 41);
            this.tb_response1.TabIndex = 61;
            // 
            // lbl_rank4
            // 
            this.lbl_rank4.AutoSize = true;
            this.lbl_rank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank4.Location = new System.Drawing.Point(18, 517);
            this.lbl_rank4.Name = "lbl_rank4";
            this.lbl_rank4.Size = new System.Drawing.Size(61, 18);
            this.lbl_rank4.TabIndex = 76;
            this.lbl_rank4.Text = "Rank 4";
            // 
            // tb_feedback1
            // 
            this.tb_feedback1.Location = new System.Drawing.Point(382, 367);
            this.tb_feedback1.Multiline = true;
            this.tb_feedback1.Name = "tb_feedback1";
            this.tb_feedback1.ReadOnly = true;
            this.tb_feedback1.Size = new System.Drawing.Size(185, 41);
            this.tb_feedback1.TabIndex = 62;
            // 
            // lbl_rank3
            // 
            this.lbl_rank3.AutoSize = true;
            this.lbl_rank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank3.Location = new System.Drawing.Point(18, 470);
            this.lbl_rank3.Name = "lbl_rank3";
            this.lbl_rank3.Size = new System.Drawing.Size(61, 18);
            this.lbl_rank3.TabIndex = 75;
            this.lbl_rank3.Text = "Rank 3";
            // 
            // tb_response2
            // 
            this.tb_response2.Location = new System.Drawing.Point(191, 414);
            this.tb_response2.Multiline = true;
            this.tb_response2.Name = "tb_response2";
            this.tb_response2.ReadOnly = true;
            this.tb_response2.Size = new System.Drawing.Size(185, 41);
            this.tb_response2.TabIndex = 63;
            // 
            // lbl_rank2
            // 
            this.lbl_rank2.AutoSize = true;
            this.lbl_rank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank2.Location = new System.Drawing.Point(18, 424);
            this.lbl_rank2.Name = "lbl_rank2";
            this.lbl_rank2.Size = new System.Drawing.Size(61, 18);
            this.lbl_rank2.TabIndex = 74;
            this.lbl_rank2.Text = "Rank 2";
            // 
            // tb_feedback2
            // 
            this.tb_feedback2.Location = new System.Drawing.Point(382, 414);
            this.tb_feedback2.Multiline = true;
            this.tb_feedback2.Name = "tb_feedback2";
            this.tb_feedback2.ReadOnly = true;
            this.tb_feedback2.Size = new System.Drawing.Size(185, 41);
            this.tb_feedback2.TabIndex = 64;
            // 
            // lbl_rank1
            // 
            this.lbl_rank1.AutoSize = true;
            this.lbl_rank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank1.Location = new System.Drawing.Point(18, 377);
            this.lbl_rank1.Name = "lbl_rank1";
            this.lbl_rank1.Size = new System.Drawing.Size(124, 18);
            this.lbl_rank1.TabIndex = 73;
            this.lbl_rank1.Text = "Rank 1 (Worst)";
            // 
            // tb_response3
            // 
            this.tb_response3.Location = new System.Drawing.Point(191, 461);
            this.tb_response3.Multiline = true;
            this.tb_response3.Name = "tb_response3";
            this.tb_response3.ReadOnly = true;
            this.tb_response3.Size = new System.Drawing.Size(185, 41);
            this.tb_response3.TabIndex = 65;
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Location = new System.Drawing.Point(414, 351);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(133, 13);
            this.lbl_feedback.TabIndex = 72;
            this.lbl_feedback.Text = "Feedback Text (for Emails)";
            // 
            // tb_feedback3
            // 
            this.tb_feedback3.Location = new System.Drawing.Point(382, 461);
            this.tb_feedback3.Multiline = true;
            this.tb_feedback3.Name = "tb_feedback3";
            this.tb_feedback3.ReadOnly = true;
            this.tb_feedback3.Size = new System.Drawing.Size(185, 41);
            this.tb_feedback3.TabIndex = 66;
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.Location = new System.Drawing.Point(242, 351);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(90, 13);
            this.lbl_response.TabIndex = 71;
            this.lbl_response.Text = "Response Criteria";
            // 
            // tb_response4
            // 
            this.tb_response4.Location = new System.Drawing.Point(191, 508);
            this.tb_response4.Multiline = true;
            this.tb_response4.Name = "tb_response4";
            this.tb_response4.ReadOnly = true;
            this.tb_response4.Size = new System.Drawing.Size(185, 41);
            this.tb_response4.TabIndex = 67;
            // 
            // tb_feedback5
            // 
            this.tb_feedback5.Location = new System.Drawing.Point(382, 555);
            this.tb_feedback5.Multiline = true;
            this.tb_feedback5.Name = "tb_feedback5";
            this.tb_feedback5.ReadOnly = true;
            this.tb_feedback5.Size = new System.Drawing.Size(185, 41);
            this.tb_feedback5.TabIndex = 70;
            // 
            // tb_feedback4
            // 
            this.tb_feedback4.Location = new System.Drawing.Point(382, 508);
            this.tb_feedback4.Multiline = true;
            this.tb_feedback4.Name = "tb_feedback4";
            this.tb_feedback4.ReadOnly = true;
            this.tb_feedback4.Size = new System.Drawing.Size(185, 41);
            this.tb_feedback4.TabIndex = 68;
            // 
            // tb_response5
            // 
            this.tb_response5.Location = new System.Drawing.Point(191, 555);
            this.tb_response5.Multiline = true;
            this.tb_response5.Name = "tb_response5";
            this.tb_response5.ReadOnly = true;
            this.tb_response5.Size = new System.Drawing.Size(185, 41);
            this.tb_response5.TabIndex = 69;
            // 
            // cb_filterCategories
            // 
            this.cb_filterCategories.FormattingEnabled = true;
            this.cb_filterCategories.Location = new System.Drawing.Point(527, 12);
            this.cb_filterCategories.Name = "cb_filterCategories";
            this.cb_filterCategories.Size = new System.Drawing.Size(121, 21);
            this.cb_filterCategories.TabIndex = 79;
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
            // ViewQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 658);
            this.Controls.Add(this.lbl_questionFilter);
            this.Controls.Add(this.cb_filterCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_questionID);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_questionText);
            this.Controls.Add(this.tb_categoryTag);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.lbl_rank5);
            this.Controls.Add(this.tb_response1);
            this.Controls.Add(this.lbl_rank4);
            this.Controls.Add(this.tb_feedback1);
            this.Controls.Add(this.lbl_rank3);
            this.Controls.Add(this.tb_response2);
            this.Controls.Add(this.lbl_rank2);
            this.Controls.Add(this.tb_feedback2);
            this.Controls.Add(this.lbl_rank1);
            this.Controls.Add(this.tb_response3);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.tb_feedback3);
            this.Controls.Add(this.lbl_response);
            this.Controls.Add(this.tb_response4);
            this.Controls.Add(this.tb_feedback5);
            this.Controls.Add(this.tb_feedback4);
            this.Controls.Add(this.tb_response5);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_questionID);
            this.Controls.Add(this.lb_Q);
            this.Name = "ViewQuestionBank";
            this.Text = "Modify and View Question Bank";
            this.Load += new System.EventHandler(this.ViewQuestionBank_Load);
            this.p_editToolbox.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tb_categoryTag;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lbl_rank5;
        private System.Windows.Forms.TextBox tb_response1;
        private System.Windows.Forms.Label lbl_rank4;
        private System.Windows.Forms.TextBox tb_feedback1;
        private System.Windows.Forms.Label lbl_rank3;
        private System.Windows.Forms.TextBox tb_response2;
        private System.Windows.Forms.Label lbl_rank2;
        private System.Windows.Forms.TextBox tb_feedback2;
        private System.Windows.Forms.Label lbl_rank1;
        private System.Windows.Forms.TextBox tb_response3;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.TextBox tb_feedback3;
        private System.Windows.Forms.Label lbl_response;
        private System.Windows.Forms.TextBox tb_response4;
        private System.Windows.Forms.TextBox tb_feedback5;
        private System.Windows.Forms.TextBox tb_feedback4;
        private System.Windows.Forms.TextBox tb_response5;
        private System.Windows.Forms.ComboBox cb_filterCategories;
        private System.Windows.Forms.Label lbl_questionFilter;
    }
}