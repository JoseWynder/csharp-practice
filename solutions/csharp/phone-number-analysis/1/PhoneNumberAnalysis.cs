public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber[..3] == "212";
        bool isFake = phoneNumber[4..7] == "555";
        string localNumber = phoneNumber[8..];
        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
