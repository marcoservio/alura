using System;
using System.Collections.Generic;

namespace CSharpCollections2
{
    public class ComparadadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}