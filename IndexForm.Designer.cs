namespace PersonalDictionary
{
    partial class IndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRandomLanguage = new System.Windows.Forms.CheckBox();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.File1Upload = new System.Windows.Forms.Button();
            this.File2Upload = new System.Windows.Forms.Button();
            this.lblFile1Chosen = new System.Windows.Forms.Label();
            this.lblFile2Chosen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQuestionsCount = new System.Windows.Forms.TextBox();
            this.cbxShowTimer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // cbxRandomLanguage
            // 
            this.cbxRandomLanguage.AutoSize = true;
            this.cbxRandomLanguage.Location = new System.Drawing.Point(15, 68);
            this.cbxRandomLanguage.Name = "cbxRandomLanguage";
            this.cbxRandomLanguage.Size = new System.Drawing.Size(167, 17);
            this.cbxRandomLanguage.TabIndex = 8;
            this.cbxRandomLanguage.Text = "First word in random language";
            this.cbxRandomLanguage.UseVisualStyleBackColor = true;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(256, 118);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(143, 23);
            this.btnStartExam.TabIndex = 9;
            this.btnStartExam.Text = "Start exam!";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.startExamBtn_Click);
            // 
            // File1Upload
            // 
            this.File1Upload.Location = new System.Drawing.Point(48, 9);
            this.File1Upload.Name = "File1Upload";
            this.File1Upload.Size = new System.Drawing.Size(134, 23);
            this.File1Upload.TabIndex = 10;
            this.File1Upload.Text = "Choose file 1";
            this.File1Upload.UseVisualStyleBackColor = true;
            this.File1Upload.Click += new System.EventHandler(this.File1Upload_Click);
            // 
            // File2Upload
            // 
            this.File2Upload.Location = new System.Drawing.Point(256, 9);
            this.File2Upload.Name = "File2Upload";
            this.File2Upload.Size = new System.Drawing.Size(143, 23);
            this.File2Upload.TabIndex = 11;
            this.File2Upload.Text = "Choose file 2";
            this.File2Upload.UseVisualStyleBackColor = true;
            this.File2Upload.Click += new System.EventHandler(this.File2Upload_Click);
            // 
            // lblFile1Chosen
            // 
            this.lblFile1Chosen.AutoSize = true;
            this.lblFile1Chosen.Location = new System.Drawing.Point(48, 39);
            this.lblFile1Chosen.Name = "lblFile1Chosen";
            this.lblFile1Chosen.Size = new System.Drawing.Size(0, 13);
            this.lblFile1Chosen.TabIndex = 12;
            // 
            // lblFile2Chosen
            // 
            this.lblFile2Chosen.AutoSize = true;
            this.lblFile2Chosen.Location = new System.Drawing.Point(253, 39);
            this.lblFile2Chosen.Name = "lblFile2Chosen";
            this.lblFile2Chosen.Size = new System.Drawing.Size(0, 13);
            this.lblFile2Chosen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Take ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "questions";
            // 
            // tbxQuestionsCount
            // 
            this.tbxQuestionsCount.Location = new System.Drawing.Point(272, 68);
            this.tbxQuestionsCount.Name = "tbxQuestionsCount";
            this.tbxQuestionsCount.Size = new System.Drawing.Size(69, 20);
            this.tbxQuestionsCount.TabIndex = 17;
            // 
            // cbxShowTimer
            // 
            this.cbxShowTimer.AutoSize = true;
            this.cbxShowTimer.Location = new System.Drawing.Point(15, 91);
            this.cbxShowTimer.Name = "cbxShowTimer";
            this.cbxShowTimer.Size = new System.Drawing.Size(78, 17);
            this.cbxShowTimer.TabIndex = 18;
            this.cbxShowTimer.Text = "Show timer";
            this.cbxShowTimer.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 177);
            this.Controls.Add(this.cbxShowTimer);
            this.Controls.Add(this.tbxQuestionsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFile2Chosen);
            this.Controls.Add(this.lblFile1Chosen);
            this.Controls.Add(this.File2Upload);
            this.Controls.Add(this.File1Upload);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.cbxRandomLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IndexForm";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxRandomLanguage;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button File1Upload;
        private System.Windows.Forms.Button File2Upload;
        private System.Windows.Forms.Label lblFile1Chosen;
        private System.Windows.Forms.Label lblFile2Chosen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQuestionsCount;
        private System.Windows.Forms.CheckBox cbxShowTimer;
    }
}

