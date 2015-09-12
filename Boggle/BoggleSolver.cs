using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boggle_game
{
    class BoggleSolver
    {

        public static BoggleChar LoadWords(IEnumerable<string> words)
        {
            var root = new  BoggleChar("", false);
            foreach (var word in words)
            {
                if (word.Length > 2)
                    root.AddWordTail(word.ToLower());
            }
            return root;
        }

        //The distinct chars in the boggle field. Returns a dictionary with words which consist of chars:
        public static  BoggleChar LoadWords(IEnumerable<string> words, HashSet<char> chars)
        {
            var root = new  BoggleChar("", false);
            foreach (var word in words)
            {
                var theword = word.ToLower();
                if (word.Length > 2 && theword.All(chars.Contains))
                    root.AddWordTail(theword);
            }
            return root;
        }

       
        // Finds all words in dictionary that are in the char field
        public static IEnumerable<BogglePath> FindWords1(char[,] chars,  BoggleChar dictionary)
        {
            for (int x = 0; x < chars.GetLength(0); x++)
                for (int y = 0; y < chars.GetLength(1); y++)
                {
                    foreach (var word in FindWords2(
                            chars,
                            new bool[chars.GetLength(0), chars.GetLength(1)],
                            dictionary,
                            new Stack<BogglePath.Point>(),
                            x,
                            y
                            ))
                        yield return word;
                }
        }

        private static IEnumerable<BogglePath> FindWords2(char[,] chars, bool[,] visited,  BoggleChar lastStep, Stack<BogglePath.Point> path, int x, int y)
        {
            if (x < 0 || y < 0 || x >= chars.GetLength(0) || y >= chars.GetLength(0) || visited[x, y])
                yield break;
            var nextstep = lastStep[chars[x, y]];
            if (nextstep == null) // no word in this direction
                yield break;
            path.Push(new BogglePath.Point { X = x, Y = y });
            if (nextstep.IsWord)  // Victory! Found a word, return it... 
                yield return new BogglePath(nextstep.Word, path);
            // Return possible longer words.
            var newVisited = new bool[chars.GetLength(0), chars.GetLength(1)];
            Array.Copy(visited, newVisited, visited.Length);
            newVisited[x, y] = true;

            //Only straight paths are allowed:

            //foreach (var word in
            //    FindWords2(chars, newVisited, nextstep, path, x + 1, y).Concat(
            //    FindWords2(chars, newVisited, nextstep, path, x, y + 1)).Concat(
            //    FindWords2(chars, newVisited, nextstep, path, x - 1, y)).Concat(
            //    FindWords2(chars, newVisited, nextstep, path, x, y - 1)))
            //    yield return word;
            //path.Pop();


            // Both Straight paths and diagonal paths are allowed (like in the real Boggle game): 
            foreach (var word in
                FindWords2(chars, newVisited, nextstep, path, x + 1, y).Concat(
                FindWords2(chars, newVisited, nextstep, path, x, y + 1)).Concat(
                FindWords2(chars, newVisited, nextstep, path, x - 1, y)).Concat(
                FindWords2(chars, newVisited, nextstep, path, x + 1, y + 1)).Concat(
                FindWords2(chars, newVisited, nextstep, path, x + 1, y - 1)).Concat(
                FindWords2(chars, newVisited, nextstep, path, x - 1, y - 1)).Concat(
                 FindWords2(chars, newVisited, nextstep, path, x - 1, y + 1)).Concat(
                FindWords2(chars, newVisited, nextstep, path, x, y - 1)))
                yield return word;
            path.Pop();

        }

    }


}
