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
    public partial class ExamForm : Form
    {
        public Dictionary<string, string> Words { get; set; }

        public ExamForm(bool isFirstWordRandom, Dictionary<string, DictionaryItem> examDictionary)
        {
            InitializeComponent();
            InitializeWords(isFirstWordRandom, examDictionary);
            InitializeLabels();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            e.Cancel = !(MessageBox.Show("Are you sure you want to exit?", "Close form", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        private void InitializeWords(bool isFirstWordRandom, Dictionary<string, DictionaryItem> examDictionary)
        {
            var items = examDictionary.Values.ToList(); ;
            Words = new Dictionary<string, string>();
            if (isFirstWordRandom)
            {
                var rand = new Random();
                foreach (var item in items)
                {
                    if (rand.Next(2) == 0)
                    {
                        Words.Add(item.FirstWord, item.SecondWord);
                    }
                    else
                    {
                        Words.Add(item.SecondWord, item.FirstWord);
                    }
                }
            }
            else
            {
                foreach (var item in items)
                {
                    Words.Add(item.FirstWord, item.SecondWord);
                }
            }
        }

        private void InitializeLabels()
        {
            lblQuestionsCount.Text = "Questions: " + Words.Count;
        }
    }
}
