using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandDictAggregate
    {
        private static Dictionary<char, char> _complements =
          new Dictionary<char, char>(){
            {'A','T'},
            {'T','A'},
            {'C','G'},
            {'G','C'},
          };

        public static string MakeComplement(string dna)
        {
            return dna.Aggregate("", (sum, acid) => sum + _complements[acid]);
        }
    }
}
