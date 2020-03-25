﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Note
    {
        private String text { get; private set; }
        private String author { get; set; }
        private int notesPriority { get; set; }
        public Note()
        {
            this.text = "Default Text";
            this.author = "Default Author";
            this.notesPriority = 1;
        }
        public Note(string text)
        {
            this.text = text;
            this.author = "Default author";
            this.notesPriority = 1;
        }
        public Note(string text, int notesPriority)
        {
            this.text = text;
            this.author = "Default author";
            this.notesPriority = notesPriority;
        }
        public override string ToString()
        {
            return this.text + this.author + this.notesPriority;
        }

    }
}
