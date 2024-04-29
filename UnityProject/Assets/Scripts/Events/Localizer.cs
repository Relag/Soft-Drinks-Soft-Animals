using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public enum LANGUAGE { ENGLISH, FRENCH };

public sealed class Localizer {
    Dictionary<string, string> LocalizedText = new Dictionary<string, string>();
    string stream = "../UnityProject/Assets/Resources/Text/GameText.csv";

    public LANGUAGE gameLanguage;

    private Dictionary<string, string> currentLanguage = new Dictionary<string, string>()

    private static readonly Localizer instance = new Localizer();

    static Localizer() { }

    private Localizer() {
        GetLocalizedText(LANGUAGE.ENGLISH);
    }

    public static Localizer Instance {
        get { return instance; }
    }

    //Function reads the .csv file and puts the requested language a dictionary
    //This dictionary is then called by text objects to determine what text should be displayed.
    //Should only be called at start of game, and when changing language.
    public void GetLocalizedText(LANGUAGE language) {
        gameLanguage = language;
    
    using var reader = new StreamReader(stream);
        var csv = new CSVReader();

        currentLanguage.Clear();
        currentLanguage = csv.ParseCSV(File.ReadAllText(stream), gameLanguage);

        int i = 0;

        foreach(var line in result) {
            Debug.Log(line.Key.ToString() + " : " + line.Value.ToString());
        }
    }

    public string getText(string key) {
        return currentLanguage[key];
    }
}
