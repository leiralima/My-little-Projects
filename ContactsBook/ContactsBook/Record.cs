using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsBook
{
    class Record
    {
        public List<string> Lines { get; private set; }
        public Record()
        {
            Lines = new List<string>();
        }
    }
}
