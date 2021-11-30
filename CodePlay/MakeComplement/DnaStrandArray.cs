using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay.MakeComplement
{
    internal class DnaStrandArray
    {
        public static string MakeComplement(string dna)
        {
            var array = dna.ToCharArray();

            for (var i = array.Length - 1; i >= 0; --i)
            {
                switch (array[i])
                {
                    case 'A':
                        array[i] = 'T';
                        break;
                    case 'T':
                        array[i] = 'A';
                        break;
                    case 'C':
                        array[i] = 'G';
                        break;
                    case 'G':
                        array[i] = 'C';
                        break;
                }
            }

            return new string(array);
        }
    }
}
