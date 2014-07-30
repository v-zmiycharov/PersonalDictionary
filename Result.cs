using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary
{
    public class Result
    {
        public List<ResultWordItem> ResultWords { get; set; }
        public TimeSpan FinalTime { get; set; }
    }

    public class ResultWordItem
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
        public string InputWord { get; set; }
        public bool IsCorrect
        {
            get
            {
                return SecondWord.Equals(InputWord, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}
