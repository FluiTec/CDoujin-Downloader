using System;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Configuration
{
    public class Constants
    {
        public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public const string AppDir = "FluiTec.CDoujin-Downloader.UserInterface.WpfCore";

        public const string UserSettingsFile = "appsettings.user.json";
    }
}
