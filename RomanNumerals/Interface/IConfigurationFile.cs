namespace RomanNumerals.Interface
{
    public interface IConfigurationFile
    {

        string GetString(string key);

        int GetInteger(string key);

    }
}
