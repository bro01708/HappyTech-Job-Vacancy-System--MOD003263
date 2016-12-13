namespace HappyTechSystem
{
    partial class CreateVacancy
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
            this.lb_questionBank = new System.Windows.Forms.ListBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lb_questionsToBeUsed = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tb_vacancyName = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_selectQuestion = new System.Windows.Forms.Label();
            this.lbl_questionBank = new System.Windows.Forms.Label();
            this.lbl_questionsToBeUsed = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.nud_acceptanceScore = new System.Windows.Forms.NumericUpDown();
            this.lbl_slots = new System.Windows.Forms.Label();
            this.nud_interviewSlots = new System.Windows.Forms.NumericUpDown();
            this.lbl_vacancyID = new System.Windows.Forms.Label();
            this.tb_VacancyID = new System.Windows.Forms.TextBox();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptanceScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_interviewSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_questionBank
            // 
            this.lb_questionBank.FormattingEnabled = true;
            this.lb_questionBank.HorizontalScrollbar = true;
            this.lb_questionBank.Location = new System.Drawing.Point(14, 144);
            this.lb_questionBank.Name = "lb_questionBank";
            this.lb_questionBank.Size = new System.Drawing.Size(485, 147);
            this.lb_questionBank.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(136, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name the vacancy:";
            // 
            // lb_questionsToBeUsed
            // 
            this.lb_questionsToBeUsed.FormattingEnabled = true;
            this.lb_questionsToBeUsed.HorizontalScrollbar = true;
            this.lb_questionsToBeUsed.Location = new System.Drawing.Point(12, 367);
            this.lb_questionsToBeUsed.Name = "lb_questionsToBeUsed";
            this.lb_questionsToBeUsed.Size = new System.Drawing.Size(486, 147);
            this.lb_questionsToBeUsed.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 297);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add ↓";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(421, 318);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(78, 43);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tb_vacancyName
            // 
            this.tb_vacancyName.Location = new System.Drawing.Point(104, 29);
            this.tb_vacancyName.Name = "tb_vacancyName";
            this.tb_vacancyName.Size = new System.Drawing.Size(160, 20);
            this.tb_vacancyName.TabIndex = 5;
            this.tb_vacancyName.TextChanged += new System.EventHandler(this.tb_vacancyName_TextChanged);
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(13, 520);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(448, 40);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create Vacancy";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_selectQuestion
            // 
            this.lbl_selectQuestion.AutoSize = true;
            this.lbl_selectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectQuestion.Location = new System.Drawing.Point(23, 95);
            this.lbl_selectQuestion.Name = "lbl_selectQuestion";
            this.lbl_selectQuestion.Size = new System.Drawing.Size(485, 13);
            this.lbl_selectQuestion.TabIndex = 9;
            this.lbl_selectQuestion.Text = "----------------------------- Select Questions to use for this vacancy: ---------" +
    "-------------------- ";
            // 
            // lbl_questionBank
            // 
            this.lbl_questionBank.AutoSize = true;
            this.lbl_questionBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionBank.Location = new System.Drawing.Point(206, 128);
            this.lbl_questionBank.Name = "lbl_questionBank";
            this.lbl_questionBank.Size = new System.Drawing.Size(90, 13);
            this.lbl_questionBank.TabIndex = 10;
            this.lbl_questionBank.Text = "Question Bank";
            // 
            // lbl_questionsToBeUsed
            // 
            this.lbl_questionsToBeUsed.AutoSize = true;
            this.lbl_questionsToBeUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionsToBeUsed.Location = new System.Drawing.Point(197, 351);
            this.lbl_questionsToBeUsed.Name = "lbl_questionsToBeUsed";
            this.lbl_questionsToBeUsed.Size = new System.Drawing.Size(127, 13);
            this.lbl_questionsToBeUsed.TabIndex = 11;
            this.lbl_questionsToBeUsed.Text = "Questions to be used";
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(468, 521);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(40, 39);
            this.btn_help.TabIndex = 12;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(258, 71);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(191, 13);
            this.lbl_score.TabIndex = 13;
            this.lbl_score.Text = "Set the minimum score for acceptance:";
            // 
            // nud_acceptanceScore
            // 
            this.nud_acceptanceScore.Location = new System.Drawing.Point(457, 68);
            this.nud_acceptanceScore.Name = "nud_acceptanceScore";
            this.nud_acceptanceScore.Size = new System.Drawing.Size(42, 20);
            this.nud_acceptanceScore.TabIndex = 14;
            // 
            // lbl_slots
            // 
            this.lbl_slots.AutoSize = true;
            this.lbl_slots.Location = new System.Drawing.Point(23, 70);
            this.lbl_slots.Name = "lbl_slots";
            this.lbl_slots.Size = new System.Drawing.Size(161, 13);
            this.lbl_slots.TabIndex = 15;
            this.lbl_slots.Text = "Enter the amount of hirable slots:";
            // 
            // nud_interviewSlots
            // 
            this.nud_interviewSlots.Location = new System.Drawing.Point(190, 68);
            this.nud_interviewSlots.Name = "nud_interviewSlots";
            this.nud_interviewSlots.Size = new System.Drawing.Size(46, 20);
            this.nud_interviewSlots.TabIndex = 16;
            this.nud_interviewSlots.ValueChanged += new System.EventHandler(this.nud_interviewSlots_ValueChanged);
            // 
            // lbl_vacancyID
            // 
            this.lbl_vacancyID.AutoSize = true;
            this.lbl_vacancyID.Location = new System.Drawing.Point(12, 13);
            this.lbl_vacancyID.Name = "lbl_vacancyID";
            this.lbl_vacancyID.Size = new System.Drawing.Size(66, 13);
            this.lbl_vacancyID.TabIndex = 17;
            this.lbl_vacancyID.Text = "Vacancy ID:";
            // 
            // tb_VacancyID
            // 
            this.tb_VacancyID.Location = new System.Drawing.Point(26, 29);
            this.tb_VacancyID.Name = "tb_VacancyID";
            this.tb_VacancyID.ReadOnly = true;
            this.tb_VacancyID.Size = new System.Drawing.Size(30, 20);
            this.tb_VacancyID.TabIndex = 18;
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(323, 29);
            this.tb_role.Name = "tb_role";
            this.tb_role.Size = new System.Drawing.Size(176, 20);
            this.tb_role.TabIndex = 19;
            this.tb_role.TextChanged += new System.EventHandler(this.tb_role_TextChanged);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(352, 13);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(130, 13);
            this.lbl_role.TabIndex = 20;
            this.lbl_role.Text = "Specify the job Role/Title:";
            // 
            // CreateVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 572);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.tb_role);
            this.Controls.Add(this.tb_VacancyID);
            this.Controls.Add(this.lbl_vacancyID);
            this.Controls.Add(this.nud_interviewSlots);
            this.Controls.Add(this.lbl_slots);
            this.Controls.Add(this.nud_acceptanceScore);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_questionsToBeUsed);
            this.Controls.Add(this.lbl_questionBank);
            this.Controls.Add(this.lbl_selectQuestion);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_vacancyName);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_questionsToBeUsed);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lb_questionBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateVacancy";
            this.Text = "Create a Vacancy";
            this.Load += new System.EventHandler(this.CreateVacancy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptanceScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_interviewSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_questionBank;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ListBox lb_questionsToBeUsed;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox tb_vacancyName;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_selectQuestion;
        private System.Windows.Forms.Label lbl_questionBank;
        private System.Windows.Forms.Label lbl_questionsToBeUsed;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.NumericUpDown nud_acceptanceScore;
        private System.Windows.Forms.Label lbl_slots;
        private System.Windows.Forms.NumericUpDown nud_interviewSlots;
        private System.Windows.Forms.Label lbl_vacancyID;
        private System.Windows.Forms.TextBox tb_VacancyID;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.Label lbl_role;
    }
}