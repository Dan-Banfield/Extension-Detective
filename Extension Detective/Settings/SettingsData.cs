using MessagePack;

namespace Extension_Detective.Settings
{
    [MessagePackObject]
    public class SettingsData
    {
        [Key(0)]
        public bool IsFirstRun { get; set; } = true;
    }
}