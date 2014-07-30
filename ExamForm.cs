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

        public ExamForm(Dictionary<string, string> words)
        {
            InitializeComponent();
            Words = words;
            InitializeLabels();
            CreateInputs();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            e.Cancel = !(MessageBox.Show("Are you sure you want to exit?", "Close form", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        private void btnFinishExam_Click(object sender, EventArgs e)
        {
            string text = String.Format("You have completed {0}/{1} questions.\nAre you sure you want to finish the exam?"
                , Inputs.Values.Count(tbx => tbx.Text != null && tbx.Text != ""), Words.Count);

            if((MessageBox.Show(text, "Finish exam", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

            }
        }

        private void InitializeLabels()
        {
            lblQuestionsCount.Text = "Questions: " + Words.Count;

            timer.Interval = 1000;

            Seconds = 0;
            // Hook up the Elapsed event for the timer.
            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Start();
        }

        private void OnTimedEvent(object source, EventArgs e)
        {
            Seconds++;
            var ts = TimeSpan.FromSeconds(Seconds);
            lblTime.Text = String.Format("{0}:{1}:{2}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void CreateInputs()
        {
            panelWords.AutoScroll = true;
            Inputs = new Dictionary<string, TextBox>();

            int i = 0;
            foreach(var key in Words.Keys)
            {
                //Create a new label and text box
                Label lbl = new Label();
                TextBox tbx = new TextBox();

                //Initialize label's property
                lbl.Text = key;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Location = new Point(20, tbx.Bottom + (i * 30));
                lbl.AutoSize = true;

                //Initialize textBoxes Property
                tbx.Location = new Point(lbl.Width, lbl.Top - 3);
                tbx.Width = 200;

                //Add the labels and text box to the form
                panelWords.Controls.Add(lbl);
                panelWords.Controls.Add(tbx);

                Inputs.Add(key, tbx);

                i++;
            }
        }
    }
}
