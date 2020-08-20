using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceYourMusic
{
    public class Faitures : Music
    {
        string Duration { get; set; }
        string Contains{ get; set; }
        public Faitures(string title, string category, List<string> Instruments, string duration , string contains ): base( title,category,Instruments) 
        {
            Duration = duration;
            Contains = contains;
        }
        public override string Description()
        {
            return base.Description() + $"This track has a duration of {Duration} and faitures {Contains} styles.";
        }

    }
}
