using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandPureReplace
    {
        public static string MakeComplement(String dna)
        {
            return dna.Replace("A", "t")
                      .Replace("T", "a")
                      .Replace("G", "c")
                      .Replace("C", "g")
                      .ToUpper();
        }
    }
}
