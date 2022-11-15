using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalReview
{
    public class Movie:Drama
    {
        public void RollTheFilm()
        {
            int i = 1;
            foreach (string line in Script)
            {
                Console.WriteLine($"Line{i}: {line}");
                i++;
            }

        }

        public override string Play()
        {
            return "No, this is a movie";
        }
    }
}
