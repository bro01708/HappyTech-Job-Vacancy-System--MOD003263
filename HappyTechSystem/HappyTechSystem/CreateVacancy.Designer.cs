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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_slots = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_questionBank
            // 
            this.lb_questionBank.FormattingEnabled = true;
            this.lb_questionBank.Location = new System.Drawing.Point(13, 135);
            this.lb_questionBank.Name = "lb_questionBank";
            this.lb_questionBank.Size = new System.Drawing.Size(213, 147);
            this.lb_questionBank.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(43, 22);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name the vacancy:";
            // 
            // lb_questionsToBeUsed
            // 
            this.lb_questionsToBeUsed.FormattingEnabled = true;
            this.lb_questionsToBeUsed.Location = new System.Drawing.Point(294, 135);
            this.lb_questionsToBeUsed.Name = "lb_questionsToBeUsed";
            this.lb_questionsToBeUsed.Size = new System.Drawing.Size(213, 147);
            this.lb_questionsToBeUsed.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(237, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(47, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "-->";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(237, 213);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(47, 43);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "[R]";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // tb_vacancyName
            // 
            this.tb_vacancyName.Location = new System.Drawing.Point(24, 38);
            this.tb_vacancyName.Name = "tb_vacancyName";
            this.tb_vacancyName.Size = new System.Drawing.Size(132, 20);
            this.tb_vacancyName.TabIndex = 5;
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(12, 288);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(448, 40);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create Vacancy";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // lbl_selectQuestion
            // 
            this.lbl_selectQuestion.AutoSize = true;
            this.lbl_selectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectQuestion.Location = new System.Drawing.Point(22, 86);
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
            this.lbl_questionBank.Location = new System.Drawing.Point(66, 119);
            this.lbl_questionBank.Name = "lbl_questionBank";
            this.lbl_questionBank.Size = new System.Drawing.Size(90, 13);
            this.lbl_questionBank.TabIndex = 10;
            this.lbl_questionBank.Text = "Question Bank";
            // 
            // lbl_questionsToBeUsed
            // 
            this.lbl_questionsToBeUsed.AutoSize = true;
            this.lbl_questionsToBeUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionsToBeUsed.Location = new System.Drawing.Point(333, 119);
            this.lbl_questionsToBeUsed.Name = "lbl_questionsToBeUsed";
            this.lbl_questionsToBeUsed.Size = new System.Drawing.Size(127, 13);
            this.lbl_questionsToBeUsed.TabIndex = 11;
            this.lbl_questionsToBeUsed.Text = "Questions to be used";
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(467, 289);
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
            this.lbl_score.Location = new System.Drawing.Point(167, 22);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(191, 13);
            this.lbl_score.TabIndex = 13;
            this.lbl_score.Text = "Set the minimum score for acceptance:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(364, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // lbl_slots
            // 
            this.lbl_slots.AutoSize = true;
            this.lbl_slots.Location = new System.Drawing.Point(167, 49);
            this.lbl_slots.Name = "lbl_slots";
            this.lbl_slots.Size = new System.Drawing.Size(172, 13);
            this.lbl_slots.TabIndex = 15;
            this.lbl_slots.Text = "Enter the amount of interview slots:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(364, 47);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown2.TabIndex = 16;
            // 
            // CreateVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lbl_slots);
            this.Controls.Add(this.numericUpDown1);
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
            this.Name = "CreateVacancy";
            this.Text = "Create a Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_slots;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}