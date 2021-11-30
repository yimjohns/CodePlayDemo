using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandSwitch
    {
        public static string MakeComplement(string dna)
        {
            StringBuilder strain = new StringBuilder();

            for (int i = 0; i < dna.Length; i++)
            {
                switch (dna[i])
                {
                    case 'A':
                        strain.Append('T');
                        break;
                    case 'T':
                        strain.Append('A');
                        break;
                    case 'C':
                        strain.Append('G');
                        break;
                    case 'G':
                        strain.Append('C');
                        break;
                }
            }
            return strain.ToString();
        }
    }
}
