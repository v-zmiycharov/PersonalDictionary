using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PersonalDictionary
{
    public partial class ExamForm : Form
    {
        private Dictionary<string, string> Words { get; set; }
        private Dictionary<string, TextBox> Inputs { get; set; }
        private int Seconds { get; set; }
        public IndexForm IndexForm { get; set; }

        public ExamForm(IndexForm indexForm)
        {
            InitializeComponent();
            this.IndexForm = indexForm;
            Words = GetWords();
            InitializeLabels();
            CreateInputs();
        }

        private void btnFinishExam_Click(object sender, EventArgs e)
        {
            string text = String.Format("You have completed {0}/{1} questions.\nAre you sure you want to finish the exam?"
                , Inputs.Values.Count(tbx => tbx.Text != null && tbx.Text != ""), Words.Count);

            if((MessageBox.Show(text, "Finish exam", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                this.Hide();
                var resultForm = new ResultForm(GetResult(), this.IndexForm);
                resultForm.ShowDialog();
                this.Close();
            }
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            var indexForm = new IndexForm();
            indexForm.ShowDialog();
            this.Close();
        }

        private void InitializeLabels()
        {
            lblQuestionsCount.Text = "Questions: " + Words.Count;

            timer.Interval = 1000;

            Seconds = 0;
            // Hook up the Elapsed event for the timer.
            if(this.IndexForm.ShowTimer)
                timer.Tick += new EventHandler(UpdateLabelAndSecondsTimedEvent);
            else
                timer.Tick += new EventHandler(UpdateSecondsTimedEvent);

            timer.Start();
        }

        private void UpdateLabelAndSecondsTimedEvent(object source, EventArgs e)
        {
            Seconds++;
            var ts = TimeSpan.FromSeconds(Seconds);
            lblTime.Text = String.Format("{0}:{1}:{2}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));
        }

        private void UpdateSecondsTimedEvent(object source, EventArgs e)
        {
            Seconds++;
        }

        private void CreateInputs()
        {
            panelWords.AutoScroll = true;
            Inputs = new Dictionary<string, TextBox>();

            int maxLblWidth = 0;
            List<Label> labels = new List<Label>();
            
            foreach(var key in Words.Keys)
            {
                Label lbl = new Label();
                lbl.Text = key;
                if(lbl.PreferredWidth > maxLblWidth)
                {
                    maxLblWidth = lbl.PreferredWidth;
                }
            }

            int i = 0;
            foreach(var key in Words.Keys)
            {
                //Create a new label and text box
                Label lbl = new Label();
                TextBox tbx = new TextBox();

                //Initialize label's property
                lbl.Text = key;
                lbl.Location = new Point(10, tbx.Bottom + (i * 30));
                lbl.Width = maxLblWidth;
                lbl.TextAlign = ContentAlignment.TopRight;

                //Initialize textBoxes Property
                tbx.Location = new Point(maxLblWidth + 15, lbl.Top - 3);
                tbx.Width = 300;

                //Add the labels and text box to the form
                panelWords.Controls.Add(lbl);
                panelWords.Controls.Add(tbx);

                Inputs.Add(key, tbx);

                i++;
            }
        }

        private Result GetResult()
        {
            Result result = new Result() { FinalTime = TimeSpan.FromSeconds(Seconds) };
            result.ResultWords = new List<ResultWordItem>();
            foreach(var key in Words.Keys)
            {
                result.ResultWords.Add(new ResultWordItem()
                    {
                        FirstWord = key,
                        SecondWord = Words[key],
                        InputWord = Inputs[key].Text
                    });
            }

            return result;
        }

        private Dictionary<string, string> GetWords()
        {
            bool isFirstWordRandom = IndexForm.IsFirstWordRandom;

            var items = IndexForm.ExamDictionary.Values.ToList();
            items.Shuffle();
            
            if(this.IndexForm.Restriction.HasValue)
            {
                items = items.Take(this.IndexForm.Restriction.Value).ToList();
            }

            Dictionary<string, string> words = new Dictionary<string, string>();
            if (isFirstWordRandom)
            {
                var rand = new Random();
                foreach (var item in items)
                {
                    if (rand.Next(2) == 0)
                    {
                        words.Add(item.FirstWord, item.SecondWord);
                    }
                    else
                    {
                        words.Add(item.SecondWord, item.FirstWord);
                    }
                }
            }
            else
            {
                foreach (var item in items)
                {
                    words.Add(item.FirstWord, item.SecondWord);
                }
            }

            return words;
        }
    }
}
