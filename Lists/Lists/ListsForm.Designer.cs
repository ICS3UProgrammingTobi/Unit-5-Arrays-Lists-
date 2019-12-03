namespace Lists
{
    partial class frmLists
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
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(60, 13);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(35, 13);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "label1";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(83, 409);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "label2";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(245, 13);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(46, 87);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(260, 251);
            this.lstMarks.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmLists";
            this.Text = "Lists Tobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button button2;
    }
}

