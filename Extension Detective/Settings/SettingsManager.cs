using System.IO;
using MessagePack;

namespace Extension_Detective.Settings
{
    internal static class SettingsManager
    {
        private const string FILE_NAME = "settings.dat";

        internal static SettingsData SettingsDataInstance;

        static SettingsManager()
        {
            if (!File.Exists(FILE_NAME) || File.ReadAllBytes(FILE_NAME).Length == 0)
            {
                File.Create(FILE_NAME).Close();
                SettingsDataInstance = new SettingsData();

                return;
            }
            SettingsDataInstance = MessagePackSerializer.Deserialize<SettingsData>(File.ReadAllBytes(FILE_NAME));
        }

        internal static void UpdateSettings(SettingsData settingsData)
        {
            byte[] data = MessagePackSerializer.Serialize<SettingsData>(settingsData);
            File.WriteAllBytes(FILE_NAME, data);
        }
    }
}