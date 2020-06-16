using System;
using System.Collections.Generic;
using System.Text;

namespace ComponentLoader
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class EDW_Challenge:Attribute
    {
        string someText;
        public EDW_Challenge() : this(string.Empty) { }
        public EDW_Challenge(string txt) { someText = txt; }
    }
}
