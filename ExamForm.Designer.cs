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
            this.components = new System.ComponentModel.Container();
            this.lblQuestionsCount = new System.Windows.Forms.Label();
            this.btnFinishExam = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.panelWords = new PersonalDictionary.CustomPanel();
            this.SuspendLayout();
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.AutoSize = true;
            this.lblQuestionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionsCount.Location = new System.Drawing.Point(431, 31);
            this.lblQuestionsCount.Name = "lblQuestionsCount";
            this.lblQuestionsCount.Size = new System.Drawing.Size(76, 17);
            this.lblQuestionsCount.TabIndex = 1;
            this.lblQuestionsCount.Text = "Questions:";
            // 
            // btnFinishExam
            // 
            this.btnFinishExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinishExam.Location = new System.Drawing.Point(434, 113);
            this.btnFinishExam.Name = "btnFinishExam";
            this.btnFinishExam.Size = new System.Drawing.Size(153, 36);
            this.btnFinishExam.TabIndex = 3;
            this.btnFinishExam.Text = "Finish exam!";
            this.btnFinishExam.UseVisualStyleBackColor = true;
            this.btnFinishExam.Click += new System.EventHandler(this.btnFinishExam_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(428, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 31);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // panelWords
            // 
            this.panelWords.Location = new System.Drawing.Point(12, 31);
            this.panelWords.Name = "panelWords";
            this.panelWords.Size = new System.Drawing.Size(400, 418);
            this.panelWords.TabIndex = 0;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 471);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnFinishExam);
            this.Controls.Add(this.lblQuestionsCount);
            this.Controls.Add(this.panelWords);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPanel panelWords;
        private System.Windows.Forms.Label lblQuestionsCount;
        private System.Windows.Forms.Button btnFinishExam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
    }
}