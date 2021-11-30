using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.RegularExpressions.Regex;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandRegex
    {
        public static string MakeComplement(string dna)
        {
            return Replace(dna, ".", m => $"{"TAGC"["ATCG".IndexOf(m.Value[0])]}");
        }
    }
}
