using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class TimeNote :  Note
    {
        private DateTime time { get; set; }
        public TimeNote()
        {
            this.time = DateTime.Now;
        }
        public TimeNote(string text, string author, int notesPriority, DateTime time)
        {
            this.time = time;
        }
        public override string ToString()
        {
            return base.ToString() + this.time;
        }

    }
}
