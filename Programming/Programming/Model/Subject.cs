using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Subject
    {
        private string _nameSubject;
        private int _mark;
        private string _teacher;
        
        public Subject(string nameSubject, int mark, string teacher)
        {
            NameSubject = nameSubject;
            Mark = mark;
            Teacher = teacher;
        }

        public string NameSubject { get; private set; }
        public int Mark { get; private set; }
        public string Teacher { get; private set; }
    }
}
