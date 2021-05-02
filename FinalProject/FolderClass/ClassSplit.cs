using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.FolderClass
{
    class ClassSplit
    {
        public static string[] SpliString(string s)
        {
            string[] words = s.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
    }
}
