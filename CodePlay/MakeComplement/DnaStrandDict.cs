using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandDict
    {
        private static Dictionary<char, char> map =
            new Dictionary<char, char>
            {
                {'T', 'A'},
                {'A', 'T'},
                {'C', 'G'},
                {'G', 'C'}
            };

        public static string MakeComplement(string dna)
        {
            var mychars = dna.ToCharArray();

            var outChars = new String(mychars.Select(x => map[x]).ToArray());

            return outChars;
        }
    }
}
