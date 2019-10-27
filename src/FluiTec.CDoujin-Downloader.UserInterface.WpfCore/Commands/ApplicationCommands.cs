using System.Windows.Input;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Commands
{
    public class ApplicationCommands
    {
        public static RoutedUICommand Minimize = new RoutedUICommand("Minimize", "Minimize", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.H, ModifierKeys.Control | ModifierKeys.Alt) }));

        public static RoutedUICommand Quit = new RoutedUICommand("Quit", "Quit", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.Q, ModifierKeys.Control) }));
    }
}
