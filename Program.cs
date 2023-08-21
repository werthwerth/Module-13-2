using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string readText = File.ReadAllText(@"./Text1.txt");
        var rows = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, Int32> wordList = new Dictionary<string, Int32>();
        foreach (string row in rows)
        {
            var words = readText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (wordList.ContainsKey(word))
                {
                    wordList[word] = wordList[word] + 1;
                }
                else
                {
                    wordList.Add(word, 0);
                }
            }
        }
        Console.WriteLine(wordList.FirstOrDefault(x => x.Value == wordList.Values.Max()));
    }
}

