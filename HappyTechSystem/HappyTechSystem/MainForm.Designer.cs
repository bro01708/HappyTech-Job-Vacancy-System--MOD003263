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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmailTempleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductInterviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewQuestionBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewEmailTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewVacanciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewInterviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyViewEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.lbl_nav = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_databaseStatus = new System.Windows.Forms.Label();
            this.lbl_databaseLoad = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.p_splash = new System.Windows.Forms.Panel();
            this.p_databaseStatus = new System.Windows.Forms.Panel();
            this.lbl_qbStatus = new System.Windows.Forms.Label();
            this.lbl_emailStatus = new System.Windows.Forms.Label();
            this.lbl_vacancyBank = new System.Windows.Forms.Label();
            this.lbl_qbLoad = new System.Windows.Forms.Label();
            this.lbl_emailLoad = new System.Windows.Forms.Label();
            this.lbl_vacancyLoad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.p_splash.SuspendLayout();
            this.p_databaseStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.conductInterviewToolStripMenuItem,
            this.modifyViewToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQuestionToolStripMenuItem,
            this.newEmailTempleToolStripMenuItem,
            this.newVacancyToolStripMenuItem});
            this.createToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // newQuestionToolStripMenuItem
            // 
            this.newQuestionToolStripMenuItem.Name = "newQuestionToolStripMenuItem";
            this.newQuestionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newQuestionToolStripMenuItem.Text = "New Question";
            this.newQuestionToolStripMenuItem.Click += new System.EventHandler(this.newQuestionToolStripMenuItem_Click);
            // 
            // newEmailTempleToolStripMenuItem
            // 
            this.newEmailTempleToolStripMenuItem.Name = "newEmailTempleToolStripMenuItem";
            this.newEmailTempleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newEmailTempleToolStripMenuItem.Text = "New Email Template";
            this.newEmailTempleToolStripMenuItem.Click += new System.EventHandler(this.newEmailTempleToolStripMenuItem_Click);
            // 
            // newVacancyToolStripMenuItem
            // 
            this.newVacancyToolStripMenuItem.Name = "newVacancyToolStripMenuItem";
            this.newVacancyToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newVacancyToolStripMenuItem.Text = "New Vacancy";
            this.newVacancyToolStripMenuItem.Click += new System.EventHandler(this.newVacancyToolStripMenuItem_Click);
            // 
            // conductInterviewToolStripMenuItem
            // 
            this.conductInterviewToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.conductInterviewToolStripMenuItem.Name = "conductInterviewToolStripMenuItem";
            this.conductInterviewToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.conductInterviewToolStripMenuItem.Text = "Conduct Interview";
            this.conductInterviewToolStripMenuItem.Click += new System.EventHandler(this.conductInterviewToolStripMenuItem_Click);
            // 
            // modifyViewToolStripMenuItem1
            // 
            this.modifyViewToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyViewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyViewQuestionBankToolStripMenuItem,
            this.modifyViewEmailTemplatesToolStripMenuItem,
            this.modifyViewVacanciesToolStripMenuItem,
            this.modifyViewInterviewsToolStripMenuItem,
            this.modifyViewEmailsToolStripMenuItem});
            this.modifyViewToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.modifyViewToolStripMenuItem1.Name = "modifyViewToolStripMenuItem1";
            this.modifyViewToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.modifyViewToolStripMenuItem1.Text = "Modify/View";
            // 
            // modifyViewQuestionBankToolStripMenuItem
            // 
            this.modifyViewQuestionBankToolStripMenuItem.Name = "modifyViewQuestionBankToolStripMenuItem";
            this.modifyViewQuestionBankToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifyViewQuestionBankToolStripMenuItem.Text = "Question Bank";
            this.modifyViewQuestionBankToolStripMenuItem.Click += new System.EventHandler(this.modifyViewQuestionBankToolStripMenuItemClick);
            // 
            // modifyViewEmailTemplatesToolStripMenuItem
            // 
            this.modifyViewEmailTemplatesToolStripMenuItem.Name = "modifyViewEmailTemplatesToolStripMenuItem";
            this.modifyViewEmailTemplatesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifyViewEmailTemplatesToolStripMenuItem.Text = "Email Templates";
            this.modifyViewEmailTemplatesToolStripMenuItem.Click += new System.EventHandler(this.modifyViewEmailTemplatesToolStripMenuItem_Click);
            // 
            // modifyViewVacanciesToolStripMenuItem
            // 
            this.modifyViewVacanciesToolStripMenuItem.Name = "modifyViewVacanciesToolStripMenuItem";
            this.modifyViewVacanciesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifyViewVacanciesToolStripMenuItem.Text = "Vacancies";
            this.modifyViewVacanciesToolStripMenuItem.Click += new System.EventHandler(this.modifyViewVacanciesToolStripMenuItem_Click);
            // 
            // modifyViewInterviewsToolStripMenuItem
            // 
            this.modifyViewInterviewsToolStripMenuItem.Name = "modifyViewInterviewsToolStripMenuItem";
            this.modifyViewInterviewsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifyViewInterviewsToolStripMenuItem.Text = "Interviews";
            this.modifyViewInterviewsToolStripMenuItem.Click += new System.EventHandler(this.modifyViewInterviewsToolStripMenuItem_Click);
            // 
            // modifyViewEmailsToolStripMenuItem
            // 
            this.modifyViewEmailsToolStripMenuItem.Name = "modifyViewEmailsToolStripMenuItem";
            this.modifyViewEmailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifyViewEmailsToolStripMenuItem.Text = "Emails";
            this.modifyViewEmailsToolStripMenuItem.Click += new System.EventHandler(this.modifyViewEmailsToolStripMenuItem_Click);
            // 
            // lbl_dev
            // 
            this.lbl_dev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev.ForeColor = System.Drawing.Color.Teal;
            this.lbl_dev.Location = new System.Drawing.Point(162, 232);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(311, 15);
            this.lbl_dev.TabIndex = 5;
            this.lbl_dev.Text = "Developed for use by HappyTech Ltd. All rights reserved.";
            // 
            // lbl_nav
            // 
            this.lbl_nav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nav.AutoSize = true;
            this.lbl_nav.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nav.ForeColor = System.Drawing.Color.Teal;
            this.lbl_nav.Location = new System.Drawing.Point(53, 174);
            this.lbl_nav.Name = "lbl_nav";
            this.lbl_nav.Size = new System.Drawing.Size(499, 26);
            this.lbl_nav.TabIndex = 7;
            this.lbl_nav.Text = "Use the dropdowns above to navigate the program";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Teal;
            this.lbl_welcome.Location = new System.Drawing.Point(16, 143);
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
            this.lbl_databaseStatus.Location = new System.Drawing.Point(15, 9);
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
            this.lbl_databaseLoad.Location = new System.Drawing.Point(110, 9);
            this.lbl_databaseLoad.Name = "lbl_databaseLoad";
            this.lbl_databaseLoad.Size = new System.Drawing.Size(97, 13);
            this.lbl_databaseLoad.TabIndex = 12;
            this.lbl_databaseLoad.Text = "DB File Not Found!";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(257, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(131, 137);
            this.pb_logo.TabIndex = 9;
            this.pb_logo.TabStop = false;
            // 
            // p_splash
            // 
            this.p_splash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_splash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_splash.BackColor = System.Drawing.Color.DarkGray;
            this.p_splash.Controls.Add(this.lbl_welcome);
            this.p_splash.Controls.Add(this.lbl_dev);
            this.p_splash.Controls.Add(this.lbl_nav);
            this.p_splash.Controls.Add(this.pb_logo);
            this.p_splash.Location = new System.Drawing.Point(185, 239);
            this.p_splash.Name = "p_splash";
            this.p_splash.Size = new System.Drawing.Size(633, 271);
            this.p_splash.TabIndex = 14;
            // 
            // p_databaseStatus
            // 
            this.p_databaseStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_databaseStatus.BackColor = System.Drawing.Color.DarkGray;
            this.p_databaseStatus.Controls.Add(this.lbl_vacancyLoad);
            this.p_databaseStatus.Controls.Add(this.lbl_emailLoad);
            this.p_databaseStatus.Controls.Add(this.lbl_qbLoad);
            this.p_databaseStatus.Controls.Add(this.lbl_vacancyBank);
            this.p_databaseStatus.Controls.Add(this.lbl_emailStatus);
            this.p_databaseStatus.Controls.Add(this.lbl_qbStatus);
            this.p_databaseStatus.Controls.Add(this.lbl_databaseLoad);
            this.p_databaseStatus.Controls.Add(this.lbl_databaseStatus);
            this.p_databaseStatus.Location = new System.Drawing.Point(796, 27);
            this.p_databaseStatus.Name = "p_databaseStatus";
            this.p_databaseStatus.Size = new System.Drawing.Size(212, 85);
            this.p_databaseStatus.TabIndex = 15;
            // 
            // lbl_qbStatus
            // 
            this.lbl_qbStatus.AutoSize = true;
            this.lbl_qbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qbStatus.ForeColor = System.Drawing.Color.Teal;
            this.lbl_qbStatus.Location = new System.Drawing.Point(15, 31);
            this.lbl_qbStatus.Name = "lbl_qbStatus";
            this.lbl_qbStatus.Size = new System.Drawing.Size(80, 13);
            this.lbl_qbStatus.TabIndex = 13;
            this.lbl_qbStatus.Text = "Question Bank:";
            // 
            // lbl_emailStatus
            // 
            this.lbl_emailStatus.AutoSize = true;
            this.lbl_emailStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_emailStatus.ForeColor = System.Drawing.Color.Teal;
            this.lbl_emailStatus.Location = new System.Drawing.Point(15, 44);
            this.lbl_emailStatus.Name = "lbl_emailStatus";
            this.lbl_emailStatus.Size = new System.Drawing.Size(63, 13);
            this.lbl_emailStatus.TabIndex = 14;
            this.lbl_emailStatus.Text = "Email Bank:";
            // 
            // lbl_vacancyBank
            // 
            this.lbl_vacancyBank.AutoSize = true;
            this.lbl_vacancyBank.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vacancyBank.ForeColor = System.Drawing.Color.Teal;
            this.lbl_vacancyBank.Location = new System.Drawing.Point(15, 57);
            this.lbl_vacancyBank.Name = "lbl_vacancyBank";
            this.lbl_vacancyBank.Size = new System.Drawing.Size(80, 13);
            this.lbl_vacancyBank.TabIndex = 15;
            this.lbl_vacancyBank.Text = "Vacancy Bank:";
            // 
            // lbl_qbLoad
            // 
            this.lbl_qbLoad.AutoSize = true;
            this.lbl_qbLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qbLoad.ForeColor = System.Drawing.Color.Red;
            this.lbl_qbLoad.Location = new System.Drawing.Point(110, 31);
            this.lbl_qbLoad.Name = "lbl_qbLoad";
            this.lbl_qbLoad.Size = new System.Drawing.Size(66, 13);
            this.lbl_qbLoad.TabIndex = 16;
            this.lbl_qbLoad.Text = "Not Loaded!";
            // 
            // lbl_emailLoad
            // 
            this.lbl_emailLoad.AutoSize = true;
            this.lbl_emailLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_emailLoad.ForeColor = System.Drawing.Color.Red;
            this.lbl_emailLoad.Location = new System.Drawing.Point(110, 44);
            this.lbl_emailLoad.Name = "lbl_emailLoad";
            this.lbl_emailLoad.Size = new System.Drawing.Size(66, 13);
            this.lbl_emailLoad.TabIndex = 17;
            this.lbl_emailLoad.Text = "Not Loaded!";
            // 
            // lbl_vacancyLoad
            // 
            this.lbl_vacancyLoad.AutoSize = true;
            this.lbl_vacancyLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vacancyLoad.ForeColor = System.Drawing.Color.Red;
            this.lbl_vacancyLoad.Location = new System.Drawing.Point(110, 57);
            this.lbl_vacancyLoad.Name = "lbl_vacancyLoad";
            this.lbl_vacancyLoad.Size = new System.Drawing.Size(66, 13);
            this.lbl_vacancyLoad.TabIndex = 18;
            this.lbl_vacancyLoad.Text = "Not Loaded!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.p_databaseStatus);
            this.Controls.Add(this.p_splash);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Application Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.p_splash.ResumeLayout(false);
            this.p_splash.PerformLayout();
            this.p_databaseStatus.ResumeLayout(false);
            this.p_databaseStatus.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem modifyViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyViewQuestionBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyViewEmailTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyViewVacanciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyViewInterviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyViewEmailsToolStripMenuItem;
        private System.Windows.Forms.Panel p_splash;
        private System.Windows.Forms.Panel p_databaseStatus;
        private System.Windows.Forms.Label lbl_vacancyLoad;
        private System.Windows.Forms.Label lbl_emailLoad;
        private System.Windows.Forms.Label lbl_qbLoad;
        private System.Windows.Forms.Label lbl_vacancyBank;
        private System.Windows.Forms.Label lbl_emailStatus;
        private System.Windows.Forms.Label lbl_qbStatus;
    }
}