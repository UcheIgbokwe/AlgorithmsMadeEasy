using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsMadeEasy.Implementation
{
    class LongestCommonPrefix
    {
        #region UcheIgbokwe
        //20200712
        //Write a function to find the longest common prefix string amongst an array of strings. If there is no common prefix, return an empty string "".
        #endregion
        public string LongestPrefix(string[] longWords)
        {
            string longestPrefix = string.Empty;

            if (longWords.Length == 0)
            {
                longestPrefix = "";
            }
            else
            {
                int numberOfWords = longWords.Length;

                for (int i = 0; i < numberOfWords; i++)
                {
                    string[] selectedLetter = new string[numberOfWords];
                    int wordsPicked = 1;
                    int matchingLetters = 0;

                    //add the character to an array.
                    if (longWords[0].Length >= 1)
                    {
                        selectedLetter[0] = longWords[0].Substring(i, 1);
                    }
                    

                    //This will pick the words after the first word and extract their sepecified character.
                    while (wordsPicked < numberOfWords)
                    {
                        //add the character to an array.
                        if (longWords[wordsPicked].Length >= 1)
                        {
                            selectedLetter[wordsPicked] = longWords[wordsPicked].Substring(i, 1);
                            wordsPicked++;
                        }
                        
                    }

                    //Check if each letter picked from each word matches.
                    if (selectedLetter.Length > 0)
                    {
                        for (int j = 0; j < selectedLetter.Length; j++)
                        {
                            if (selectedLetter[0] == selectedLetter[j])
                            {
                                //check if all the characters selected are equal.
                                matchingLetters += 1;
                            }
                        }

                        //if the number of words match the number of characters selected, then it's a yes.
                        if (matchingLetters == numberOfWords)
                        {
                            longestPrefix += selectedLetter[0];
                        }
                    }

                }


            }
            return longestPrefix;
        }
    }
}
