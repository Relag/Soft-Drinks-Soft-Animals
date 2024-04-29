using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public enum LANGUAGE { ENGLISH, FRENCH };

public class Localizer {
    Dictionary<string, string> LocalizedText = new Dictionary<string, string>();
    string stream = "../UnityProject/Assets/Resources/Text/GameText.csv";

    public LANGUAGE gameLanguage = LANGUAGE.ENGLISH;

    public void GetLocalizedText() {
    
    using var reader = new StreamReader(stream);
        var csv = new CSVReader();
        var result = csv.ParseCSV(File.ReadAllText(stream), gameLanguage);

        int i = 0;

        foreach(var line in result) {
            Debug.Log(line.Key.ToString() + " : " + line.Value.ToString());
        }

        /*while (csv.Read()) {
            LocalizedText.Add(csv.GetField("Key"), csv.GetField(language));
        }

        foreach (KeyValuePair<string, string> text in LocalizedText) {
            Debug.Log(text.Key + " : " + text.Value);
        }*/
      //  reader.ReadHeaders();
}
}
