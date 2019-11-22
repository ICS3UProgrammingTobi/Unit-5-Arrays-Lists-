namespace IntroductionToArraysTobi
{
    partial class frmArrays
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstAverageNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(105, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(35, 392);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(110, 32);
            this.btnCalculateAverage.TabIndex = 1;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(217, 411);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "label1";
            // 
            // lstAverageNumber
            // 
            this.lstAverageNumber.FormattingEnabled = true;
            this.lstAverageNumber.Location = new System.Drawing.Point(58, 78);
            this.lstAverageNumber.Name = "lstAverageNumber";
            this.lstAverageNumber.Size = new System.Drawing.Size(256, 303);
            this.lstAverageNumber.TabIndex = 3;
            // 
            // frmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lstAverageNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.btnStart);
            this.Name = "frmArrays";
            this.Text = "Introduction to Arrays Tobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lstAverageNumber;
    }
}

