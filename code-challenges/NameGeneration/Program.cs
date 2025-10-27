using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography;

/*
https://open.kattis.com/problems/namegeneration
Ingrid is the founder and CEO of bicycle retailer BIKEA. 
The company sells bicycles for customers to assemble themselves.

BIKEA has N different bicycles to offer. Ingrid wants to give 
each of them a human-readable name, to make it easy to remember. 
But doing this by hand is a very time consuming task.

You are given the number N, and your task is to generate N different names. 
To make the names readable, they must satisfy the following:

1. Each name has length between 3 and 20, 
and only consists of lowercase English letters.

2. Three consecutive letters of a name cannot all be vowels 
or consonants. Here we consider a, e, i, o, u vowels, while 
the remaining 21 letters are consonants.

For example, 'hello', 'bar', and 'lkab' are all valid names, 
whereas 'ingrid', 'bo and 'louise' are invalid.

## Input
The input consists of one integer N (1 ≤ N ≤ 30000), 
the number of names to generate.

## Output
Print N lines, each of them containing a name. 
It can be proven that it is possible to generate N different names.

## Sample input:
3

## Sample output:
abdullah
bjorn
nils
*/
namespace NameGeneration
{
    class Program
    {
        static readonly int MIN_NAME_LENGTH = 3;
        static readonly int MAX_NAME_LENGTH = 20;
        /*
            Index 0-4: vowels
            Index 5-end: consonants
        */
        static readonly string LETTERS = "aeioubcdfghjklmnpqrstvwxyz";
        static readonly int CONSONANTS_START_INDEX = 5;
        static readonly int MAX_CONSECUTIVE_SPEECH_SOUNDS = 2;
        static readonly int MAX_NAMES_AMOUNT = 30000;
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine() ?? "0";
            if (rawInput == "")
                rawInput = "0";
            int namesAmount = int.Parse(rawInput);
            if (namesAmount < 1)
            {
                Console.WriteLine("No names to create. Exiting...");
                return;
            }
            if (namesAmount > MAX_NAMES_AMOUNT)
            {
                Console.WriteLine(string.Format("Max amount of names is {0:N0}. Exiting...", MAX_NAMES_AMOUNT));
                return;
            }

            HashSet<string> generatedNamed = GenerateNames(namesAmount);
            foreach (string name in generatedNamed)
            {
                Console.WriteLine(name);
            }
        }

        static HashSet<string> GenerateNames(int nameAmount)
        {
            HashSet<string> names = [];

            for (int i = 0; i < nameAmount; i++)
            {
                int nameLength = RandomNumberGenerator.GetInt32(MIN_NAME_LENGTH, MAX_NAME_LENGTH + 1);
                string name = "";
                SpeechSoundCounter counter = new();
                
                for (int j = 0; j < nameLength; j++)
                    name += GetRandomLetter(counter);

                if (!names.Add(name))
                    i--;
            }

            return names;
        }
        static char GetRandomLetter(SpeechSoundCounter counter)
        {
            char letter = LETTERS[RandomNumberGenerator.GetInt32(LETTERS.Length)];

            if (LETTERS[..5].Contains(letter))
            /* letter is a vowel */
            {
                if (counter.Add(SpeechSound.Vowel))
                {
                    return letter;
                }
                return LETTERS[RandomNumberGenerator.GetInt32(CONSONANTS_START_INDEX, LETTERS.Length)];
            }
            /* letter is a consonant */
            if (counter.Add(SpeechSound.Consonant))
            {
                return letter;
            }
            return LETTERS[RandomNumberGenerator.GetInt32(CONSONANTS_START_INDEX)];
        }

        class SpeechSoundCounter
        {
            private int _count = 0;
            private SpeechSound? _lastSpeechSound = null;

            public bool Add(SpeechSound speechSound)
            {
                if (speechSound == _lastSpeechSound)
                {
                    /* Increment count before comparing to consecutive limit */
                    if (++_count < MAX_CONSECUTIVE_SPEECH_SOUNDS)
                    {
                        _lastSpeechSound = speechSound;
                        return true;
                    }
                    _count = 0;
                    _lastSpeechSound = speechSound == SpeechSound.Vowel ?
                        SpeechSound.Consonant : SpeechSound.Vowel;
                    return false;
                }
                _count = 0;
                _lastSpeechSound = speechSound;
                return true;
            }
        }

        enum SpeechSound
        {
            Vowel,
            Consonant,
        }
    }
}
