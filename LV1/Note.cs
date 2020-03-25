using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Note
    {
        private String text;
        private String author;
        private int notesPriority;
        public Note()
        {
            this.text = "Default Text";
            this.author = "Default Author";
            this.notesPriority = 1;
        }
        
        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }
        public int NotesPriority
        {
            get{ return this.notesPriority; }
            set { this.notesPriority = value; }
        }
        public String getText()
        {
            return this.text;
        }
        public String getAuthor()
        {
            return this.author;
        }
        public int getNotesPriority()
        {
            return this.notesPriority;
        }
        public void setText(String text)
        {
            this.text = text;
        }
        public void setPriority(int notesPriority)
        {
            this.notesPriority = notesPriority;
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
