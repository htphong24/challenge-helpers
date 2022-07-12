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
