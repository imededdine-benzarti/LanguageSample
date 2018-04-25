using LanguageSample.Model;
using LanguageSample.Resources;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LanguageSample
{
	public partial class MainPage : ContentPage
	{
       public ObservableCollection<Language> Languages { get; }

        public MainPage()
		{
			InitializeComponent();

            Languages = new ObservableCollection<Language>() {
                new Language{DisplayName="French", ShortName="Fr"},
                new Language{DisplayName="English", ShortName="En"},
                new Language{DisplayName="Arabic", ShortName="Ar"},
            };

            BindingContext = this;
            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;
        }

        private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];
            try
            {
                var culture = new CultureInfo(language.ShortName);
                AppResources.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
            }
            catch (Exception)
            {
            }
            ChangeLanguage.Text = AppResources.ChangeLanguage;
            ButtonApply.Text = AppResources.Apply;
        }

        private void GoToAddCategory(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HomePage());
        }


    }
}
