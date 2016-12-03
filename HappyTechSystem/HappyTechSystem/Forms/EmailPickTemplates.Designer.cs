namespace HappyTechSystem.Forms
{
    partial class EmailPickTemplates
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
            this.lbl_accept = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_accept = new System.Windows.Forms.ComboBox();
            this.cb_reject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_accept
            // 
            this.lbl_accept.AutoSize = true;
            this.lbl_accept.Location = new System.Drawing.Point(26, 13);
            this.lbl_accept.Name = "lbl_accept";
            this.lbl_accept.Size = new System.Drawing.Size(177, 13);
            this.lbl_accept.TabIndex = 0;
            this.lbl_accept.Text = "Choose an Accept Template to use:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Rejection Template to use:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(141, 56);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(127, 23);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm Templates";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // cb_accept
            // 
            this.cb_accept.FormattingEnabled = true;
            this.cb_accept.Location = new System.Drawing.Point(29, 29);
            this.cb_accept.Name = "cb_accept";
            this.cb_accept.Size = new System.Drawing.Size(174, 21);
            this.cb_accept.TabIndex = 3;
            // 
            // cb_reject
            // 
            this.cb_reject.FormattingEnabled = true;
            this.cb_reject.Location = new System.Drawing.Point(209, 29);
            this.cb_reject.Name = "cb_reject";
            this.cb_reject.Size = new System.Drawing.Size(174, 21);
            this.cb_reject.TabIndex = 4;
            // 
            // EmailPickTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 90);
            this.Controls.Add(this.cb_reject);
            this.Controls.Add(this.cb_accept);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailPickTemplates";
            this.Text = "EmailPickTemplates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_accept;
        private System.Windows.Forms.ComboBox cb_reject;
    }
}