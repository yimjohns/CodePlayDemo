using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandShortReplace
    {
        public static string MakeComplement(string dna)
        {
            return dna.Replace('T', 'P').Replace('C', 'K').Replace('A', 'T').Replace('G', 'C').Replace('P', 'A').Replace('K', 'G');
        }
    }
}
