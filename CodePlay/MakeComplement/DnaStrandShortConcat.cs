using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandShortConcat
    {
        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(c => "AGCT"["TCGA".IndexOf(c)]));
        }

    }
}
