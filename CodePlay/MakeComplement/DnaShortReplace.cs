using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaShortReplace
    {
        public static string MakeComplement(string dna)
        {
            return dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();
        }
    }
}
