using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class RansomNoteService : ServiceBase<RansomNoteRequest, bool>
    {
        /*
         * INPUT:                    => OUTPUT:
         * ransomeNote = "a", magazine = "b"    => false
         * ransomeNote = "aa", magazine = "ab"  => false
         * ransomeNote = "aa", magazine = "aab" => true
         *
         * */


        protected override bool DoRun(RansomNoteRequest request)
        {
            var ransomeNoteDict = new Dictionary<char, int>(); // key: letter, value: occurrences
            var magazineDict = new Dictionary<char, int>(); // key: letter, value: occurrences

            foreach (var character in request.RansomNote)
                if (!ransomeNoteDict.ContainsKey(character))
                    ransomeNoteDict.Add(character, 1);
                else
                    ransomeNoteDict[character]++;

            foreach (var character in request.Magazine)
                if (!magazineDict.ContainsKey(character))
                    magazineDict.Add(character, 1);
                else
                    magazineDict[character]++;

            foreach (var pair in ransomeNoteDict)
            {
                // return false if magazine does not contain the letter found in ransomeNote
                if (!magazineDict.ContainsKey(pair.Key))
                    return false;

                // return false if occurrences of the letter found in ransomeNote is greater than the occurrences of the same letter found in magazine
                if (ransomeNoteDict[pair.Key] > magazineDict[pair.Key])
                    return false;
            }

            return true;
        }

        public override void RunTest()
        {
            var r0010 = Run(new RansomNoteRequest("a","b"), out var t0010); // false

            var r0020 = Run(new RansomNoteRequest("aa", "ab"), out var t0020); // false

            var r0030 = Run(new RansomNoteRequest("aa", "aab"), out var t0030); // true

            var r0040 = Run(new RansomNoteRequest("thanh","xytbhbattanzhanc"), out var t0040); // true

            var r0050 = Run(new RansomNoteRequest("a","b"), out var t0050); // false

            var r0060 = Run(new RansomNoteRequest("thanh", "xytbhbattazhac"), out var t0060); // false

            var r0070 = Run(new RansomNoteRequest("thanh", "xybthanhzc"), out var t0070); // true

            var r0080 = Run(new RansomNoteRequest("aa", "a"), out var t0080); // false

            var r0090 = Run(new RansomNoteRequest("thanhphong", "thanhphong"), out var t0090); // true

            var r0100 = Run(new RansomNoteRequest("thanhphong", "thanhphon"), out var t0100); // false

            var r0110 = Run(new RansomNoteRequest("thanhphong", "o"), out var t0110); // false
        }
    }

    public class RansomNoteRequest
    {
        public string RansomNote { get; private set; }

        public string Magazine { get; private set; }

        public RansomNoteRequest(string ransomNote, string magazine)
        {
            RansomNote = ransomNote;
            Magazine = magazine;
        }
    }
}
