using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Localizer {
    Dictionary<string, string> LocalizedText = new Dictionary<string, string>();
    string stream = "../UnityProject/Assets/Resources/Text/GameText.csv";

    public void GetLocalizedText(string language) {
    using var reader = new StreamReader(stream);
        var csv = new CSVReader();
        var result = csv.ParseCSV(File.ReadAllText(stream));

        int i = 0;

        foreach(var line in result) {
            Debug.Log(line[0]);
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
