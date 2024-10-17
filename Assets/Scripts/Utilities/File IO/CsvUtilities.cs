using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OSGames.Utilities {
    public static class CSVUtilities {

        public static List<string[]> ReadCsv(TextAsset file, bool skipHeader=false){

            string[] lines = file.text.Split('\n');
            List<string[]> results = new List<string[]>();
            
            bool readingHeader = skipHeader;
            
            foreach (string line in lines){
                if (readingHeader){
                    readingHeader = false;
                    continue;
                }
                if (line.Length > 0){
                    results.Add(line.Split(','));
                }
            }

            return results;
        }
    }

}