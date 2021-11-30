//Console.Write("Enter a number > ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(IsSquare(n));

//Console.WriteLine(5 % 1);
//Console.WriteLine(6.1 % 1);
//Console.WriteLine((5 % 1) == (6.2 % 1));
var watch2 = System.Diagnostics.Stopwatch.StartNew();
Console.WriteLine(MakeArrayComplement("ATTGC"));
watch2.Stop();
Console.WriteLine(watch2.ElapsedMilliseconds);

var watch = System.Diagnostics.Stopwatch.StartNew();
Console.WriteLine(MakeComplement("ATTGC"));
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);



//static bool IsSquare(int n)
//{
//    return (Math.Sqrt(n) % 1 == 0);
//}

static string MakeComplement(string dna)
{
    var complements = new Dictionary<char, char>()
    {
        {'A', 'T' },
        {'T', 'A' },
        {'C', 'G' },
        {'G', 'C' }
    };

    string dnaResult = "";

    foreach (char c in dna.ToArray())
    {
        dnaResult += complements[c];
    }

    return dnaResult;
}


static string MakeArrayComplement(string dna)
{
    char[] arr = dna.ToArray();
    string dnaResult = "";
    for(int i = 0; i < arr.Length; i++)
    {
        switch (arr[i])
        {
            case 'T':
                arr[i] = 'A';
                break;

            case 'A':
                arr[i] = 'T';
                break;

            case 'G':
                arr[i] = 'C';
                break;

            case 'C':
                arr[i] = 'G';
                break;
        }
    }

    foreach(char c in arr)
    {
        dnaResult += c;
    }

    return dnaResult;
}