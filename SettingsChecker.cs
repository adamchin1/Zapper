
namespace Zapper
{
    public class SettingsChecker
    {
        public bool IsSettingEnabled(string settings, int value)
        {
            if (settings.Length != 8)
            {
                throw new ArgumentOutOfRangeException("Settings string length must be 8");
            }

            if (value < 0 || value > 7)
            {
                throw new ArgumentOutOfRangeException("Setting value must be between 1 and 8");
            }

            return settings[value - 1] == '1';
        }
    }
}