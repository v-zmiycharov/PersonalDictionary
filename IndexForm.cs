using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary
{
    public partial class IndexForm : Form
    {
        public Dictionary<string, DictionaryItem> ExamDictionary { get; set; }

        public IndexForm()
        {
            InitializeComponent();
        }

        private void File1Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    if (ExamDictionary == null)
                        ExamDictionary = new Dictionary<string, DictionaryItem>();

                    ClearExamDictionaryFirstWords();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] splitted = Array.ConvertAll(line.Split('&'), p => p.Trim());
                        if (splitted.Count() == 2)
                        {
                            string key = splitted[0];
                            string firstWordValue = splitted[1];
                            if (ExamDictionary.ContainsKey(key))
                            {
                                ExamDictionary[key].FirstWord = firstWordValue;
                            }
                            else
                            {
                                ExamDictionary.Add(key, new DictionaryItem() { FirstWord = firstWordValue });
                            }
                        }
                    }

                    lblFile1Chosen.Text = Path.GetFileNameWithoutExtension(path);
                }
            }
        }

        private void File2Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    if (ExamDictionary == null)
                        ExamDictionary = new Dictionary<string, DictionaryItem>();

                    ClearExamDictionarySecondWords();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] splitted = Array.ConvertAll(line.Split('&'), p => p.Trim());
                        if (splitted.Count() == 2)
                        {
                            string key = splitted[0];
                            string secondWordValue = splitted[1];
                            if (ExamDictionary.ContainsKey(key))
                            {
                                ExamDictionary[key].SecondWord = secondWordValue;
                            }
                            else
                            {
                                ExamDictionary.Add(key, new DictionaryItem() { SecondWord = secondWordValue });
                            }
                        }
                    }
                }

                lblFile2Chosen.Text = Path.GetFileNameWithoutExtension(path);
            }
        }

        private void startExamBtn_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                var examForm = new ExamForm(cbxRandomLanguage.Checked, ExamDictionary);
                examForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
        }

        private void ClearExamDictionaryFirstWords()
        {
            var helperDictionary = new Dictionary<string, DictionaryItem>(ExamDictionary);
            foreach (var item in helperDictionary)
            {
                if (String.IsNullOrWhiteSpace(item.Value.SecondWord))
                {
                    ExamDictionary.Remove(item.Key);
                }
                else
                {
                    ExamDictionary[item.Key].FirstWord = String.Empty;
                }
            }
        }

        private void ClearExamDictionarySecondWords()
        {
            var helperDictionary = new Dictionary<string, DictionaryItem>(ExamDictionary);
            foreach (var item in helperDictionary)
            {
                if (String.IsNullOrWhiteSpace(item.Value.FirstWord))
                {
                    ExamDictionary.Remove(item.Key);
                }
                else
                {
                    ExamDictionary[item.Key].SecondWord = String.Empty;
                }
            }
        }

        private bool ValidateInput()
        {
            var values = ExamDictionary != null ? ExamDictionary.Values : null;
            return values != null && values.Count > 0 && !values.Any(e => (e.FirstWord == null || e.FirstWord == "") || (e.SecondWord == null || e.SecondWord == ""));
        }
    }
}
