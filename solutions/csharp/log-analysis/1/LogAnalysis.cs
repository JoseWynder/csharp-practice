public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter) =>  str.Substring(str.IndexOf(delimiter) + delimiter.Length);

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter) 
    {
        string textAfterStartDelimiter = str.SubstringAfter(startDelimiter);
        return textAfterStartDelimiter.Substring(0, textAfterStartDelimiter.IndexOf(endDelimiter));
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}