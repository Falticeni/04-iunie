using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    public static class StringBuilderExtension
    {
        public static string Substring(this StringBuilder sb, int index, int length)
        {
            return sb.ToString().Substring(index, length);
        }
    }
}
