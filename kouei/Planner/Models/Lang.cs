namespace Planner.Models;

public enum Kana
{
    あ, い, う, ゔ, え, お,
    か, き, く, け, こ,
    が, ぎ, ぐ, げ, ご,
    さ, し, す, せ, そ,
    ざ, じ, ず, ぜ, ぞ,
    た, ち, つ, っ, て, と,
    だ, ぢ, づ, で, ど,
    な, に, ぬ, ね, の,
    は, ひ, ふ, へ, ほ, 
    ば, び, ぶ, べ, ぼ,
    ぱ, ぴ, ぷ, ぺ, ぽ,
    ま, み, む, め, も,
    や, ゆ, よ, ゃ, ゅ, ょ,
    ら, り, る, れ, ろ, 
    わ, ゐ, ゑ, を,
    ん
}

public static class Lang
{
    public static string KanaOfEi(string ei)
    {
        return ei switch
        {
            "a" => "あ",
            "i" => "い",
            "u" => "う",
            "e" => "え",
            "o" => "お",
            "ka" => "か",
            "ga" => "が",
            "ki" => "き",
            "gi" => "ぎ",
            "ku" => "く",
            "gu" => "ぐ",
            "ke" => "け",
            "ge" => "げ",
            "ko" => "こ",
            "go" => "ご",
            "sa" => "さ",
            "si" or "shi" => "し",
            "su" => "す",
            "se" => "せ",
            "so" => "そ",
            _ => throw new ArgumentException("Not implemented yet...")
        };
    }
    
    public static string KanaStringOfEi(string ei)
    {
        var analysed = ei.Trim();
        var vowels = new List<char> {'a', 'i', 'u', 'e', 'o'};

        while (string.IsNullOrEmpty(analysed))
        {
            
        }

        return "";
    }
}