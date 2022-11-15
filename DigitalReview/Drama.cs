using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalReview
{
    public class Drama:IArt
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public List<string> Script { get; set; }
        public string Creator { get; set; }

        private string theOutsideWorldCannotSeeThis = "Bet you cannot see this!";
        internal string otherFilesInTheSameAppMightWellSeeThis = "You may be able to see this!";
        public string anyoneCanSeeThisEvenCodeInOtherApps = "You may be able to see this!";
        protected string onlyVisibleToCodeInClassesThatInheritFromThis = "You may be able to see this!";

        public virtual string Play() {
            return "I'm not sure if I'm a plain drama, play or movie";
        }

        public string GetScriptAsText()
        {
            StringBuilder text = new StringBuilder();
            foreach(string line in Script)
            {
                text.Append(line);
            }
            return text.ToString();
        }

    }
}
