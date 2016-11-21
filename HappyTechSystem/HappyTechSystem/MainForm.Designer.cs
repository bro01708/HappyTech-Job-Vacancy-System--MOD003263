namespace HappyTechSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmailTempleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductInterviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEmailTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyVacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQuestionBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmailTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVacanciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInterviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.lbl_nav = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_databaseStatus = new System.Windows.Forms.Label();
            this.lbl_databaseLoad = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.conductInterviewToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.viewToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQuestionToolStripMenuItem,
            this.newEmailTempleToolStripMenuItem,
            this.newVacancyToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // newQuestionToolStripMenuItem
            // 
            this.newQuestionToolStripMenuItem.Name = "newQuestionToolStripMenuItem";
            this.newQuestionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newQuestionToolStripMenuItem.Text = "New Question";
            this.newQuestionToolStripMenuItem.Click += new System.EventHandler(this.newQuestionToolStripMenuItem_Click);
            // 
            // newEmailTempleToolStripMenuItem
            // 
            this.newEmailTempleToolStripMenuItem.Name = "newEmailTempleToolStripMenuItem";
            this.newEmailTempleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newEmailTempleToolStripMenuItem.Text = "New Email Template";
            this.newEmailTempleToolStripMenuItem.Click += new System.EventHandler(this.newEmailTempleToolStripMenuItem_Click);
            // 
            // newVacancyToolStripMenuItem
            // 
            this.newVacancyToolStripMenuItem.Name = "newVacancyToolStripMenuItem";
            this.newVacancyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newVacancyToolStripMenuItem.Text = "New Vacancy";
            this.newVacancyToolStripMenuItem.Click += new System.EventHandler(this.newVacancyToolStripMenuItem_Click);
            // 
            // conductInterviewToolStripMenuItem
            // 
            this.conductInterviewToolStripMenuItem.Name = "conductInterviewToolStripMenuItem";
            this.conductInterviewToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.conductInterviewToolStripMenuItem.Text = "Conduct Interview";
            this.conductInterviewToolStripMenuItem.Click += new System.EventHandler(this.conductInterviewToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyQuestionToolStripMenuItem,
            this.modifyEmailTemplateToolStripMenuItem,
            this.modifyVacancyToolStripMenuItem,
            this.modifyEmailToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.viewToolStripMenuItem.Text = "Modify";
            // 
            // modifyQuestionToolStripMenuItem
            // 
            this.modifyQuestionToolStripMenuItem.Name = "modifyQuestionToolStripMenuItem";
            this.modifyQuestionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyQuestionToolStripMenuItem.Text = "Question";
            this.modifyQuestionToolStripMenuItem.Click += new System.EventHandler(this.modifyQuestionToolStripMenuItem_Click);
            // 
            // modifyEmailTemplateToolStripMenuItem
            // 
            this.modifyEmailTemplateToolStripMenuItem.Name = "modifyEmailTemplateToolStripMenuItem";
            this.modifyEmailTemplateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyEmailTemplateToolStripMenuItem.Text = "Email Template";
            this.modifyEmailTemplateToolStripMenuItem.Click += new System.EventHandler(this.modifyEmailTemplateToolStripMenuItem_Click);
            // 
            // modifyVacancyToolStripMenuItem
            // 
            this.modifyVacancyToolStripMenuItem.Name = "modifyVacancyToolStripMenuItem";
            this.modifyVacancyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyVacancyToolStripMenuItem.Text = "Vacancy";
            this.modifyVacancyToolStripMenuItem.Click += new System.EventHandler(this.modifyVacancyToolStripMenuItem_Click);
            // 
            // modifyEmailToolStripMenuItem
            // 
            this.modifyEmailToolStripMenuItem.Name = "modifyEmailToolStripMenuItem";
            this.modifyEmailToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyEmailToolStripMenuItem.Text = "Email";
            this.modifyEmailToolStripMenuItem.Click += new System.EventHandler(this.modifyEmailToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewQuestionBankToolStripMenuItem,
            this.viewEmailTemplatesToolStripMenuItem,
            this.viewVacanciesToolStripMenuItem,
            this.viewInterviewsToolStripMenuItem,
            this.viewEmailsToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // viewQuestionBankToolStripMenuItem
            // 
            this.viewQuestionBankToolStripMenuItem.Name = "viewQuestionBankToolStripMenuItem";
            this.viewQuestionBankToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewQuestionBankToolStripMenuItem.Text = "Question Bank";
            this.viewQuestionBankToolStripMenuItem.Click += new System.EventHandler(this.viewQuestionBankToolStripMenuItem_Click);
            // 
            // viewEmailTemplatesToolStripMenuItem
            // 
            this.viewEmailTemplatesToolStripMenuItem.Name = "viewEmailTemplatesToolStripMenuItem";
            this.viewEmailTemplatesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewEmailTemplatesToolStripMenuItem.Text = "Email Templates";
            this.viewEmailTemplatesToolStripMenuItem.Click += new System.EventHandler(this.viewEmailTemplatesToolStripMenuItem_Click);
            // 
            // viewVacanciesToolStripMenuItem
            // 
            this.viewVacanciesToolStripMenuItem.Name = "viewVacanciesToolStripMenuItem";
            this.viewVacanciesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewVacanciesToolStripMenuItem.Text = "Vacancies";
            this.viewVacanciesToolStripMenuItem.Click += new System.EventHandler(this.viewVacanciesToolStripMenuItem_Click);
            // 
            // viewInterviewsToolStripMenuItem
            // 
            this.viewInterviewsToolStripMenuItem.Name = "viewInterviewsToolStripMenuItem";
            this.viewInterviewsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewInterviewsToolStripMenuItem.Text = "Interviews";
            this.viewInterviewsToolStripMenuItem.Click += new System.EventHandler(this.viewInterviewsToolStripMenuItem_Click);
            // 
            // viewEmailsToolStripMenuItem
            // 
            this.viewEmailsToolStripMenuItem.Name = "viewEmailsToolStripMenuItem";
            this.viewEmailsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewEmailsToolStripMenuItem.Text = "Emails";
            this.viewEmailsToolStripMenuItem.Click += new System.EventHandler(this.viewEmailsToolStripMenuItem_Click);
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev.ForeColor = System.Drawing.Color.Teal;
            this.lbl_dev.Location = new System.Drawing.Point(305, 385);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(311, 15);
            this.lbl_dev.TabIndex = 5;
            this.lbl_dev.Text = "Developed for use by HappyTech Ltd. All rights reserved.";
            // 
            // lbl_nav
            // 
            this.lbl_nav.AutoSize = true;
            this.lbl_nav.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nav.ForeColor = System.Drawing.Color.Teal;
            this.lbl_nav.Location = new System.Drawing.Point(213, 311);
            this.lbl_nav.Name = "lbl_nav";
            this.lbl_nav.Size = new System.Drawing.Size(499, 26);
            this.lbl_nav.TabIndex = 7;
            this.lbl_nav.Text = "Use the dropdowns above to navigate the program";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Teal;
            this.lbl_welcome.Location = new System.Drawing.Point(176, 280);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(601, 31);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Welcome to the HappyTech Application Manager";
            // 
            // lbl_databaseStatus
            // 
            this.lbl_databaseStatus.AutoSize = true;
            this.lbl_databaseStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_databaseStatus.ForeColor = System.Drawing.Color.Teal;
            this.lbl_databaseStatus.Location = new System.Drawing.Point(779, 35);
            this.lbl_databaseStatus.Name = "lbl_databaseStatus";
            this.lbl_databaseStatus.Size = new System.Drawing.Size(89, 13);
            this.lbl_databaseStatus.TabIndex = 11;
            this.lbl_databaseStatus.Text = "Database Status:";
            // 
            // lbl_databaseLoad
            // 
            this.lbl_databaseLoad.AutoSize = true;
            this.lbl_databaseLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_databaseLoad.ForeColor = System.Drawing.Color.Red;
            this.lbl_databaseLoad.Location = new System.Drawing.Point(874, 35);
            this.lbl_databaseLoad.Name = "lbl_databaseLoad";
            this.lbl_databaseLoad.Size = new System.Drawing.Size(63, 13);
            this.lbl_databaseLoad.TabIndex = 12;
            this.lbl_databaseLoad.Text = "Not Loaded";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::HappyTechSystem.Properties.Resources.logo3;
            this.pb_logo.Location = new System.Drawing.Point(409, 147);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(127, 130);
            this.pb_logo.TabIndex = 9;
            this.pb_logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 567);
            this.Controls.Add(this.lbl_databaseLoad);
            this.Controls.Add(this.lbl_databaseStatus);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_nav);
            this.Controls.Add(this.lbl_dev);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Application Manager";
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.Label lbl_nav;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_databaseStatus;
        private System.Windows.Forms.Label lbl_databaseLoad;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmailTempleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVacancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductInterviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyEmailTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyVacancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQuestionBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmailTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVacanciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInterviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmailsToolStripMenuItem;
    }
}