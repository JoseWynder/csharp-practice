static class LogLine
{
    public static string Message(string logLine) 
    {
        int separatorIndex = logLine.IndexOf(':');
        return logLine.Substring(separatorIndex + 1).Trim();    
    } 

    public static string LogLevel(string logLine) 
    {
        int start = logLine.IndexOf('[') + 1;
        int length = logLine.IndexOf(']') - start;
        return logLine.Substring(start, length).ToLower();
    }
        
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
