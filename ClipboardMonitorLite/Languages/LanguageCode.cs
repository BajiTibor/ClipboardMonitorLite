namespace ClipboardMonitorLite.Languages
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
            English,
            Hungarian,
            Norwegian,
            Finnish,
            Filipino,
            Dutch,
            Serbian,
            Danish,
            Polish
        }
    }
}
