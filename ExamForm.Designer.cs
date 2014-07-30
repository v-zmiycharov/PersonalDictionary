namespace PersonalDictionary
{
    partial class ExamForm
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
            this.panelWords = new System.Windows.Forms.Panel();
            this.lblQuestionsCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnFinishExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelWords
            // 
            this.panelWords.Location = new System.Drawing.Point(12, 31);
            this.panelWords.Name = "panelWords";
            this.panelWords.Size = new System.Drawing.Size(400, 418);
            this.panelWords.TabIndex = 0;
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.AutoSize = true;
            this.lblQuestionsCount.Location = new System.Drawing.Point(456, 31);
            this.lblQuestionsCount.Name = "lblQuestionsCount";
            this.lblQuestionsCount.Size = new System.Drawing.Size(0, 13);
            this.lblQuestionsCount.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(459, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 2;
            // 
            // btnFinishExam
            // 
            this.btnFinishExam.Location = new System.Drawing.Point(462, 123);
            this.btnFinishExam.Name = "btnFinishExam";
            this.btnFinishExam.Size = new System.Drawing.Size(110, 23);
            this.btnFinishExam.TabIndex = 3;
            this.btnFinishExam.Text = "Finish exam!";
            this.btnFinishExam.UseVisualStyleBackColor = true;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 471);
            this.Controls.Add(this.btnFinishExam);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestionsCount);
            this.Controls.Add(this.panelWords);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWords;
        private System.Windows.Forms.Label lblQuestionsCount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnFinishExam;
    }
}