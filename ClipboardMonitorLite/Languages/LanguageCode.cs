namespace ClipboardMonitorLite
{
    public class LanguageCode
    {
        public static string[] LanguageList = new string[9]
        {
            "en", // English
            "hu", // Hungarian
            "no", // Norwegian
            "fi", // Finnish
            "fil", // Filipino
            "nl", // Dutch
            "sr", // Serbian
            "da", // Danish
            "pl" // Polish
        };

        public enum Language
        {
            English, // = 0
            Hungarian, // = 1
            Norwegian, // = 2 ...
            Finnish,
            Filipino,
            Dutch,
            Serbian,
            Danish,
            Polish
        }
    }
}
