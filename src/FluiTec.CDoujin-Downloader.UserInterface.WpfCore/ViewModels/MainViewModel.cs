using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            LoadLanguage();
            ChangeLanguage = new RelayCommand<CultureInfo>(c => 
            { 
                CurrentLanguage = c; 
            });
        }

        #region Properties

        public string ApplicationName => "CDoujin-Downloader";

        private CultureInfo _currentLanguage = CultureInfo.InvariantCulture;
        public CultureInfo CurrentLanguage
        {
            get
            {
                return _currentLanguage;
            }
            set
            {
                if (Cultures.CultureResources.SupportedCultures.Contains(value))
                {
                    RaisePropertyChanging();
                    _currentLanguage = value;
                    CultureInfo.CurrentUICulture = _currentLanguage;
                    Cultures.CultureResources.ChangeCulture(value);
                    Settings.Default.Language = value.Name;
                    Settings.Default.Save();
                    RaisePropertyChanged();
                }
                else if (Cultures.CultureResources.SupportedCultures.Any(c => c.Equals(value.Parent)))
                {
                    RaisePropertyChanging();
                    var parent = value.Parent;
                    _currentLanguage = value;
                    CultureInfo.CurrentUICulture = _currentLanguage;
                    Cultures.CultureResources.ChangeCulture(parent);
                    Settings.Default.Language = parent.Name;
                    Settings.Default.Save();
                    RaisePropertyChanged();
                }
            }
        }

        public ObservableCollection<CultureInfo> Languages { get; private set; }

        #endregion

        #region Commands 

        public RelayCommand<CultureInfo> ChangeLanguage { get; set; }

        #endregion

        #region Methods

        private void LoadLanguage()
        {
            Languages = new ObservableCollection<CultureInfo>(Cultures.CultureResources.SupportedCultures.OrderBy(c => c.NativeName));
            if (!string.IsNullOrWhiteSpace(Settings.Default.Language))
            {
                try
                {
                    var savedLanguage = new CultureInfo(Settings.Default.Language);
                    if (Cultures.CultureResources.SupportedCultures.Contains(savedLanguage))
                    {
                        CurrentLanguage = savedLanguage;
                    }
                    else
                    {
                        CurrentLanguage = CultureInfo.CurrentUICulture;
                    }
                }
                catch (Exception)
                {
                    CurrentLanguage = CultureInfo.CurrentUICulture;
                }
            }
            else
            {
                CurrentLanguage = CultureInfo.CurrentUICulture;
            }
        }

        #endregion
    }
}