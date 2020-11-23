using System;
using System.Collections.Generic;
using System.Linq;

namespace WoerterbuchLogic
{
    public class WoerterbuchController
    {
        /// <summary>
        /// words in dictionary
        /// </summary>
        private Dictionary<string, List<string>> _wordsDict;

        public WoerterbuchController()
        {
            _wordsDict = new Dictionary<string, List<string>>();
    }
                
        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public void ReadDictionary(string path)
        {
            string[] fileContent = System.IO.File.ReadAllLines(path);

            if (_wordsDict != null)
            {
                _wordsDict.Clear();
            }
          
            foreach (string fileLine in fileContent)
            {
                string[] stringArray = fileLine.Split(';');

                List<string> translations = new List<string>();

                for (int i = 1; i < stringArray.Length; i++)
                {
                    translations.Add(stringArray[i]);
                }               

                _wordsDict.Add(stringArray[0], translations);
            }
            SortDictionary();
        }

        private void SortDictionary() 
        {
            var sorted = _wordsDict.OrderBy(item => item.Key).ToDictionary(item => item.Key,item => item.Value); //.ToDictionary( obj => obj.Key , obj => obj.Value );//   Keys.OrderBy(key => key).ToDictionary(); //  (.Key()
            _wordsDict = sorted;
        }

        /// <summary>
        /// writes the dictionary to file
        /// </summary>
        public void WriteToFile(string path)
        {
            SortDictionary();

            var exportStrings = new List<string>();

            foreach (var dictonaryItem in _wordsDict)
            {
                string translations = dictonaryItem.Key;

                foreach (var translation in dictonaryItem.Value)
                {
                    translations += ";" + translation;
                }  

                exportStrings.Add(translations);
            }

            System.IO.File.WriteAllLines(path, exportStrings);
        }

        /// <summary>
        /// filters the dictionary and returns a list
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="hasToStartsWith"></param>
        /// <returns></returns>
        public List<string> FindResults(string filterString, bool hasToStartsWith)
        {
            List<string> result = new List<string>();
            Dictionary<string, List<string>> searchResults = null;


            if (hasToStartsWith)
            {
                var result1 = _wordsDict.Select(x => x).Where(x => x.Key.ToUpper().StartsWith(filterString.ToUpper())).ToList();

                var result2 = _wordsDict.Where(x => x.Key.ToUpper().StartsWith(filterString.ToUpper())).
                    Select(x => x.Key.ToString() + " --  " + x.Value[0].ToString()).ToList();

                searchResults = _wordsDict.Where(x => x.Key.ToUpper().StartsWith(filterString.ToUpper())).
                    Select(x => x).ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                var result3 = _wordsDict.Where(x => x.Key.ToUpper().Contains(filterString.ToUpper())).
                    Select(x => x.Key.ToString() + " --  " + x.Value[0].ToString()).ToList();

                searchResults = _wordsDict.Where(x => x.Key.ToUpper().Contains(filterString.ToUpper())).
                     Select(x => x).ToDictionary(x => x.Key, x => x.Value);
            }

            foreach (var searchResult in searchResults)
            {
                string s = searchResult.Key;

                foreach (var value in searchResult.Value)
                {
                    s += " - " + value;
                }
                result.Add(s);
            }

            return result;


        }

        /// <summary>
        /// returns the alphabet for the filtering
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlphabet()
        {
            var alphabet = _wordsDict.Keys.OrderBy(word => word).
                Select(word => word.Substring(0,1)); // Listet alle Anfangsbuchstaben auf

            var a = _wordsDict.Keys.OrderBy(word => word).
                Select(word => word.Substring(0, 1).ToUpper()).
                Distinct().ToList();// District listet das Element nur einmal auf

            return a;
        }
    }
}
