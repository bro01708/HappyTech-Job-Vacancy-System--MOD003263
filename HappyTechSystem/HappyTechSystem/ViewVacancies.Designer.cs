namespace HappyTechSystem
{
    partial class ViewVacancies
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_selectVacancy = new System.Windows.Forms.Label();
            this.lbl_minScore = new System.Windows.Forms.Label();
            this.nud_acceptance = new System.Windows.Forms.NumericUpDown();
            this.lbl_slots = new System.Windows.Forms.Label();
            this.nud_slots = new System.Windows.Forms.NumericUpDown();
            this.lb_questionsUsed = new System.Windows.Forms.ListBox();
            this.lbl_usedQuestions = new System.Windows.Forms.Label();
            this.gb_editViewVacancy = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_vacancyName = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_questionBank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slots)).BeginInit();
            this.gb_editViewVacancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 0;
            // 
            // lbl_selectVacancy
            // 
            this.lbl_selectVacancy.AutoSize = true;
            this.lbl_selectVacancy.Location = new System.Drawing.Point(9, 9);
            this.lbl_selectVacancy.Name = "lbl_selectVacancy";
            this.lbl_selectVacancy.Size = new System.Drawing.Size(186, 13);
            this.lbl_selectVacancy.TabIndex = 1;
            this.lbl_selectVacancy.Text = "Choose a vacancy from the list below:";
            // 
            // lbl_minScore
            // 
            this.lbl_minScore.AutoSize = true;
            this.lbl_minScore.Location = new System.Drawing.Point(182, 21);
            this.lbl_minScore.Name = "lbl_minScore";
            this.lbl_minScore.Size = new System.Drawing.Size(158, 13);
            this.lbl_minScore.TabIndex = 2;
            this.lbl_minScore.Text = "Minimum Score for Acceptance:";
            // 
            // nud_acceptance
            // 
            this.nud_acceptance.Location = new System.Drawing.Point(346, 19);
            this.nud_acceptance.Name = "nud_acceptance";
            this.nud_acceptance.ReadOnly = true;
            this.nud_acceptance.Size = new System.Drawing.Size(77, 20);
            this.nud_acceptance.TabIndex = 3;
            // 
            // lbl_slots
            // 
            this.lbl_slots.AutoSize = true;
            this.lbl_slots.Location = new System.Drawing.Point(182, 48);
            this.lbl_slots.Name = "lbl_slots";
            this.lbl_slots.Size = new System.Drawing.Size(79, 13);
            this.lbl_slots.TabIndex = 4;
            this.lbl_slots.Text = "Interview Slots:";
            // 
            // nud_slots
            // 
            this.nud_slots.Location = new System.Drawing.Point(346, 48);
            this.nud_slots.Name = "nud_slots";
            this.nud_slots.ReadOnly = true;
            this.nud_slots.Size = new System.Drawing.Size(77, 20);
            this.nud_slots.TabIndex = 5;
            // 
            // lb_questionsUsed
            // 
            this.lb_questionsUsed.FormattingEnabled = true;
            this.lb_questionsUsed.Location = new System.Drawing.Point(224, 124);
            this.lb_questionsUsed.Name = "lb_questionsUsed";
            this.lb_questionsUsed.Size = new System.Drawing.Size(211, 134);
            this.lb_questionsUsed.TabIndex = 6;
            // 
            // lbl_usedQuestions
            // 
            this.lbl_usedQuestions.AutoSize = true;
            this.lbl_usedQuestions.Location = new System.Drawing.Point(279, 108);
            this.lbl_usedQuestions.Name = "lbl_usedQuestions";
            this.lbl_usedQuestions.Size = new System.Drawing.Size(107, 13);
            this.lbl_usedQuestions.TabIndex = 7;
            this.lbl_usedQuestions.Text = "Questions to be used";
            // 
            // gb_editViewVacancy
            // 
            this.gb_editViewVacancy.Controls.Add(this.lbl_questionBank);
            this.gb_editViewVacancy.Controls.Add(this.listBox2);
            this.gb_editViewVacancy.Controls.Add(this.lbl_vacancyName);
            this.gb_editViewVacancy.Controls.Add(this.textBox1);
            this.gb_editViewVacancy.Controls.Add(this.nud_slots);
            this.gb_editViewVacancy.Controls.Add(this.lbl_usedQuestions);
            this.gb_editViewVacancy.Controls.Add(this.lbl_minScore);
            this.gb_editViewVacancy.Controls.Add(this.lb_questionsUsed);
            this.gb_editViewVacancy.Controls.Add(this.nud_acceptance);
            this.gb_editViewVacancy.Controls.Add(this.lbl_slots);
            this.gb_editViewVacancy.Location = new System.Drawing.Point(138, 25);
            this.gb_editViewVacancy.Name = "gb_editViewVacancy";
            this.gb_editViewVacancy.Size = new System.Drawing.Size(441, 264);
            this.gb_editViewVacancy.TabIndex = 8;
            this.gb_editViewVacancy.TabStop = false;
            this.gb_editViewVacancy.Text = "Edit and View Vacancies";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(585, 35);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(52, 51);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lbl_vacancyName
            // 
            this.lbl_vacancyName.AutoSize = true;
            this.lbl_vacancyName.Location = new System.Drawing.Point(38, 29);
            this.lbl_vacancyName.Name = "lbl_vacancyName";
            this.lbl_vacancyName.Size = new System.Drawing.Size(80, 13);
            this.lbl_vacancyName.TabIndex = 9;
            this.lbl_vacancyName.Text = "Vacancy Name";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 124);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(211, 134);
            this.listBox2.TabIndex = 10;
            // 
            // lbl_questionBank
            // 
            this.lbl_questionBank.AutoSize = true;
            this.lbl_questionBank.Location = new System.Drawing.Point(75, 108);
            this.lbl_questionBank.Name = "lbl_questionBank";
            this.lbl_questionBank.Size = new System.Drawing.Size(77, 13);
            this.lbl_questionBank.TabIndex = 11;
            this.lbl_questionBank.Text = "Question Bank";
            // 
            // ViewVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.gb_editViewVacancy);
            this.Controls.Add(this.lbl_selectVacancy);
            this.Controls.Add(this.listBox1);
            this.Name = "ViewVacancies";
            this.Text = "Modify and View Vacancies";
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slots)).EndInit();
            this.gb_editViewVacancy.ResumeLayout(false);
            this.gb_editViewVacancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_selectVacancy;
        private System.Windows.Forms.Label lbl_minScore;
        private System.Windows.Forms.NumericUpDown nud_acceptance;
        private System.Windows.Forms.Label lbl_slots;
        private System.Windows.Forms.NumericUpDown nud_slots;
        private System.Windows.Forms.ListBox lb_questionsUsed;
        private System.Windows.Forms.Label lbl_usedQuestions;
        private System.Windows.Forms.GroupBox gb_editViewVacancy;
        private System.Windows.Forms.Label lbl_vacancyName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_questionBank;
        private System.Windows.Forms.ListBox listBox2;
    }
}