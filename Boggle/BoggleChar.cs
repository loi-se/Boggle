using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Boggle_game
{
    class BoggleChar
    {

        private Dictionary<char,  BoggleChar> _next;
        public bool IsWord { get; private set; }
        public string Word { get; private set; }

        public BoggleChar(string sofar, bool word)
        {
            Word = sofar;
            IsWord = word;
        }


        private Dictionary<char, BoggleChar> Next
        {
            get { return _next ?? (_next = new Dictionary<char, BoggleChar>(1)); }
        }

        public BoggleChar this[char next]
        {
            get
            {
                BoggleChar nextChar;
                if (!Next.TryGetValue(next, out nextChar))
                    return null;
                return nextChar;
            }
            set
            {
                Debug.Assert(this[next] == null);
                Next[next] = value;
            }
        }


        // Creates entries for all characters in tail and adds them to this entry.
        public void AddWordTail(string tail)
        {
            BoggleChar nextChar = this[tail[0]];
            var nextIsWord = tail.Length == 1;
            if (nextChar == null)
            {
                nextChar = new BoggleChar(Word + tail[0], nextIsWord);
                this[tail[0]] = nextChar;
            }
            if (!nextIsWord) //more chars left
            {
                nextChar.AddWordTail(tail.Substring(1)); // consume 1 char and recurse
            }
        }
    }
}
