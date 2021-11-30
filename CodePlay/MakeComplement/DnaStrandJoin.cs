using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandJoin
    {
        public static string MakeComplement(string dna)
        {
            return String.Join("",
                   from ch in dna
                   select "AGCT"["TCGA".IndexOf(ch)]
                  );

        }
    }
}
