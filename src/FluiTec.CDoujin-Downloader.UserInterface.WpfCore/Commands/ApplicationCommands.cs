using System.Windows.Input;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Commands
{
    public class ApplicationCommands
    {
        public static RoutedUICommand Minimize = new RoutedUICommand("Minimize", "Minimize", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.H, ModifierKeys.Control | ModifierKeys.Alt) }));

        public static RoutedUICommand Quit = new RoutedUICommand("Quit", "Quit", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.Q, ModifierKeys.Control) }));

        public static RoutedUICommand PasteClipboard = new RoutedUICommand("PasteClipboard", "PasteClipboard", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.V, ModifierKeys.Control | ModifierKeys.Shift) }));

        public static RoutedUICommand ClipboardMonitor = new RoutedUICommand("ClipboardMonitor", "ClipboardMonitor", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.V, ModifierKeys.Control | ModifierKeys.Alt) }));

        public static RoutedUICommand AddFromList = new RoutedUICommand("AddFromList", "AddFromList", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.L, ModifierKeys.Control) }));

        public static RoutedUICommand ShowBookmarks = new RoutedUICommand("ShowBookmarks", "ShowBookmarks", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.D, ModifierKeys.Control) }));

        public static RoutedUICommand SearchManga = new RoutedUICommand("AddFromList", "AddFromList", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.F3) }));

        public static RoutedUICommand StartDownloads = new RoutedUICommand("StartDownloads", "StartDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.A, ModifierKeys.Control | ModifierKeys.Shift) }));

        public static RoutedUICommand QueueDownloads = new RoutedUICommand("QueueDownloads", "QueueDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.Q, ModifierKeys.Control) }));

        public static RoutedUICommand PauseDownloads = new RoutedUICommand("PauseDownloads", "PauseDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.P, ModifierKeys.Control) }));

        public static RoutedUICommand StopDownloads = new RoutedUICommand("StopDownloads", "StopDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.A, ModifierKeys.Control | ModifierKeys.Alt) }));

        public static RoutedUICommand FilterDownloads = new RoutedUICommand("FilterDownloads", "FilterDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.F, ModifierKeys.Control) }));

        public static RoutedUICommand HistoryDownloads = new RoutedUICommand("HistoryDownloads", "HistoryDownloads", typeof(ApplicationCommands), new InputGestureCollection(new[] { new KeyGesture(Key.H, ModifierKeys.Control) }));
    }
}
