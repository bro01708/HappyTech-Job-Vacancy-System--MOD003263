namespace HappyTechSystem
{
    partial class CreateTemplate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_addName = new System.Windows.Forms.Button();
            this.btn_position = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Location = new System.Drawing.Point(13, 41);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(50, 13);
            this.lbl_greeting.TabIndex = 1;
            this.lbl_greeting.Text = "Greeting:";
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(24, 67);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(34, 13);
            this.lbl_body.TabIndex = 2;
            this.lbl_body.Text = "Body:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 131);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(13, 15);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 4;
            this.lbl_subject.Text = "Subject:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_addName
            // 
            this.btn_addName.Location = new System.Drawing.Point(456, 67);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(151, 23);
            this.btn_addName.TabIndex = 6;
            this.btn_addName.Text = "Insert Interviewee\'s Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            // 
            // btn_position
            // 
            this.btn_position.Location = new System.Drawing.Point(456, 97);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(151, 23);
            this.btn_position.TabIndex = 7;
            this.btn_position.Text = "Insert Position";
            this.btn_position.UseVisualStyleBackColor = true;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 360);
            this.Controls.Add(this.btn_position);
            this.Controls.Add(this.btn_addName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_greeting);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_addName;
        private System.Windows.Forms.Button btn_position;
    }
}