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
            this.SuspendLayout();
            // 
            // lb_Q
            // 
            this.lb_Q.FormattingEnabled = true;
            this.lb_Q.Location = new System.Drawing.Point(12, 29);
            this.lb_Q.Name = "lb_Q";
            this.lb_Q.Size = new System.Drawing.Size(170, 329);
            this.lb_Q.TabIndex = 0;
            // 
            // lbl_questionID
            // 
            this.lbl_questionID.AutoSize = true;
            this.lbl_questionID.Location = new System.Drawing.Point(12, 10);
            this.lbl_questionID.Name = "lbl_questionID";
            this.lbl_questionID.Size = new System.Drawing.Size(63, 13);
            this.lbl_questionID.TabIndex = 1;
            this.lbl_questionID.Text = "Question ID";
            // 
            // ViewQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 384);
            this.Controls.Add(this.lbl_questionID);
            this.Controls.Add(this.lb_Q);
            this.Name = "ViewQuestionBank";
            this.Text = "ViewQuestionBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Q;
        private System.Windows.Forms.Label lbl_questionID;
    }
}