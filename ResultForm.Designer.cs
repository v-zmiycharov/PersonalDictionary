namespace PersonalDictionary
{
    partial class ResultForm
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
            this.panelWords = new PersonalDictionary.CustomPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnRetakeExam = new System.Windows.Forms.Button();
            this.lblQuestionsCount = new System.Windows.Forms.Label();
            this.btnNewExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelWords
            // 
            this.panelWords.Location = new System.Drawing.Point(12, 31);
            this.panelWords.Name = "panelWords";
            this.panelWords.Padding = new System.Windows.Forms.Padding(15);
            this.panelWords.Size = new System.Drawing.Size(677, 468);
            this.panelWords.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(714, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 31);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // btnRetakeExam
            // 
            this.btnRetakeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRetakeExam.Location = new System.Drawing.Point(720, 113);
            this.btnRetakeExam.Name = "btnRetakeExam";
            this.btnRetakeExam.Size = new System.Drawing.Size(153, 36);
            this.btnRetakeExam.TabIndex = 6;
            this.btnRetakeExam.Text = "Retake exam!";
            this.btnRetakeExam.UseVisualStyleBackColor = true;
            this.btnRetakeExam.Click += new System.EventHandler(this.btnRetakeExam_Click);
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.AutoSize = true;
            this.lblQuestionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionsCount.Location = new System.Drawing.Point(717, 31);
            this.lblQuestionsCount.Name = "lblQuestionsCount";
            this.lblQuestionsCount.Size = new System.Drawing.Size(76, 17);
            this.lblQuestionsCount.TabIndex = 5;
            this.lblQuestionsCount.Text = "Questions:";
            // 
            // btnNewExam
            // 
            this.btnNewExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewExam.Location = new System.Drawing.Point(720, 463);
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(153, 36);
            this.btnNewExam.TabIndex = 8;
            this.btnNewExam.Text = "New exam!";
            this.btnNewExam.UseVisualStyleBackColor = true;
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 511);
            this.Controls.Add(this.btnNewExam);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRetakeExam);
            this.Controls.Add(this.lblQuestionsCount);
            this.Controls.Add(this.panelWords);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPanel panelWords;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRetakeExam;
        private System.Windows.Forms.Label lblQuestionsCount;
        private System.Windows.Forms.Button btnNewExam;
    }
}