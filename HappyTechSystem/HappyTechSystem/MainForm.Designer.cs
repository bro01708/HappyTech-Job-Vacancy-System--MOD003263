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
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQuestionBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.lbl_nav = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionToolStripMenuItem,
            this.vacancyToolStripMenuItem,
            this.interviewToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAQuestionToolStripMenuItem,
            this.viewQuestionBankToolStripMenuItem});
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.questionToolStripMenuItem.Text = "Question";
            // 
            // createAQuestionToolStripMenuItem
            // 
            this.createAQuestionToolStripMenuItem.Name = "createAQuestionToolStripMenuItem";
            this.createAQuestionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.createAQuestionToolStripMenuItem.Text = "Create a Question";
            this.createAQuestionToolStripMenuItem.Click += new System.EventHandler(this.createAQuestionToolStripMenuItem_Click);
            // 
            // viewQuestionBankToolStripMenuItem
            // 
            this.viewQuestionBankToolStripMenuItem.Name = "viewQuestionBankToolStripMenuItem";
            this.viewQuestionBankToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewQuestionBankToolStripMenuItem.Text = "View Question Bank";
            this.viewQuestionBankToolStripMenuItem.Click += new System.EventHandler(this.viewQuestionBankToolStripMenuItem_Click);
            // 
            // vacancyToolStripMenuItem
            // 
            this.vacancyToolStripMenuItem.Name = "vacancyToolStripMenuItem";
            this.vacancyToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.vacancyToolStripMenuItem.Text = "Vacancy";
            // 
            // interviewToolStripMenuItem
            // 
            this.interviewToolStripMenuItem.Name = "interviewToolStripMenuItem";
            this.interviewToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.interviewToolStripMenuItem.Text = "Interview";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev.Location = new System.Drawing.Point(232, 360);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(311, 15);
            this.lbl_dev.TabIndex = 5;
            this.lbl_dev.Text = "Developed for use by HappyTech Ltd. All rights reserved.";
            // 
            // lbl_nav
            // 
            this.lbl_nav.AutoSize = true;
            this.lbl_nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nav.Location = new System.Drawing.Point(137, 286);
            this.lbl_nav.Name = "lbl_nav";
            this.lbl_nav.Size = new System.Drawing.Size(505, 26);
            this.lbl_nav.TabIndex = 7;
            this.lbl_nav.Text = "Use the dropdowns above to navigate the program!";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(100, 255);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(601, 31);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Welcome to the HappyTech Application Manager";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(307, 150);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(149, 102);
            this.pb_logo.TabIndex = 9;
            this.pb_logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 516);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_nav);
            this.Controls.Add(this.lbl_dev);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQuestionBankToolStripMenuItem;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.ToolStripMenuItem vacancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nav;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}