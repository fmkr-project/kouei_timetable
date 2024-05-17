namespace Planner.Models;

public class Station
{
    public string KanjiName = "";
    public string KanaName = "";
    public string EiName = "";

    public Station(string kanji, string kana, string ei)
    {
        if (kanji == "" || kana == "" || ei == "")
            throw new ArgumentException("Station names cannot be empty");
        
        KanjiName = kanji;
        KanaName = kana;
        EiName = ei;
    }

    public char HashKey()
    {
        return KanaName[0];
    }

    public string DisplaySearchName()
    {
        // Return the string that will be printed in the search boxes
        return KanjiName;
    }

    public int MatchesSearch(string query)
    {
        // Does the current search matches the station name ?
        // 2: yes, from the start. 1: yes, from the middle. 0: no.
        // TODO
        if (KanjiName[..query.Length] == query) return 2;
        return KanjiName.Contains(query) ? 1 : 0;
    }
}