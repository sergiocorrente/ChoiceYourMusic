using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceYourMusic
{
    public class Music
    {
        public string Title{ get; set; }
        public string Category { get; set;}
        public List<string> Instruments { get; set; }

        public Music(string title, string category, List<string> instruments)
        {
            Title = title;
            
            Category = category;

            Instruments = instruments;
        }


        public Music(string title, string category)
        {
            Title = title;

            Category = category;

            Instruments = new List<string>();
        }



        public virtual string Description()
        {
            string description;

            if (Instruments.Count != 0)
            {
                description = $"This track {Title} is of style {Category} and faitures musical instruments ";

                foreach (var item in Instruments)
                {
                    description += ", " + item  ;
                }

                description += ". ";
            }
            else
            {
                description = $"This track {Title} is of style { Category } ";
            }

            return description + ". ";
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
