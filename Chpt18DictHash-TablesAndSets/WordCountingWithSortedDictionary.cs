// using System;

// namespace Chpt18DictHash_TablesAndSets;

// public class WordCountingWithSortedDictionary
// {
//     private static readonly string Text = "Mary had a little lamb " + "little lamb, " + "Mary had a Little lamb, " + "whose fleece were white as snow";

//     private static IDictionary<string, int> GetWordOccurrenceMap(string text)
//     {
//         string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');

//         IDictionary<string, int> words = new SortedDictionary<string, int>();

//         foreach (string word in tokens)
//         {
//             if (!string.IsNullOrEmpty(word.Trim()))
//             {
//                 int count;
//                 if (!words.TryGetValue(word, out count))
//                 {
//                     count = 0;
//                 }
//                 words[word] = count + 1;
//             }
//         }
//         return words;
//     }

//     private static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccurrenceMap)
//     {
//         foreach (var wordEntry in wordOccurrenceMap)
//         {
//             Console.WriteLine("Word '{0}' occurs {1} time(s) in the text", wordEntry.Key, wordEntry.Value);
//         }

//     }

//     public static void Run()
//     {
//         IDictionary<string, int> wordOccurrenceMap = GetWordOccurrenceMap(Text); PrintWordOccurrenceCount(wordOccurrenceMap);
//     }
// }
