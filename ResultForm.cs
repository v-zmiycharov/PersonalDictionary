using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary
{
    public partial class ResultForm : Form
    {
        public Result Result { get; set; }
        public IndexForm IndexForm { get; set; }

        public ResultForm(Result result, IndexForm indexForm)
        {
            InitializeComponent();
            Result = result;
            IndexForm = indexForm;
            InitializeLabels();
            CreateInputLabels();
        }

        private void btnRetakeExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            var examForm = new ExamForm(IndexForm);
            examForm.ShowDialog();
            this.Close();
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            var indexForm = new IndexForm();
            indexForm.ShowDialog();
            this.Close();
        }

        private void panelWords_MouseEnter(object sender, EventArgs e)
        {
            panelWords.Focus();
        }

        private void InitializeLabels()
        {
            lblQuestionsCount.Text = String.Format("Result: {0} / {1}", Result.ResultWords.Count(e => e.IsCorrect), Result.ResultWords.Count);

            var ts = Result.FinalTime;
            lblTime.Text = String.Format("{0}:{1}:{2}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));

            panelWords.AutoScroll = true;
            panelWords.BackColor = Color.White;
            panelWords.MouseEnter += panelWords_MouseEnter;
        }

        private void CreateInputLabels()
        {
            panelWords.AutoScroll = true;

            int i = 0;
            var uncorrectAnswers = Result.ResultWords.Where(e => !e.IsCorrect);

            int initialSpace = 10;
            foreach (var item in uncorrectAnswers)
            {
                //Create a new label
                Label lbl = new Label();

                //Initialize label's property
                lbl.Text = String.Format("{0} - {1} ( correct: {2} )", item.FirstWord, item.InputWord, item.SecondWord);
                lbl.Location = new Point(20, initialSpace + (i * 30));
                lbl.AutoSize = true;
                lbl.ForeColor = Color.Red;

                //Add the labels to the form
                panelWords.Controls.Add(lbl);

                i++;
            }
        }

    }
}
