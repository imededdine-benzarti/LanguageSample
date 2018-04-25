using LanguageSample.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanguageSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            if (System.Globalization.CultureInfo.CurrentCulture.TextInfo.IsRightToLeft)
            {
                StackApp.FlowDirection = FlowDirection.RightToLeft;
               
            }
            else
            {
                StackApp.FlowDirection = FlowDirection.LeftToRight;
                           }

            TitleAddCategory.Text = AppResources.Title;
            ItemInformations.Text = AppResources.ItemInformations;
            CodeItem.Text = AppResources.Code;
            Icon.Text = AppResources.Icon;
            NameEn.Text = AppResources.NameEn;
            NameAr.Text = AppResources.NameAr;
            ShortNameEn.Text = AppResources.ShortNameEn;
            ShortNameAr.Text = AppResources.ShortNameAr;
            OtherInformations.Text = AppResources.OtherInformations;
            ProductCategory.Text = AppResources.ProductCategory;
            ProductCategoryImages.Text = AppResources.ProductCategoryImages;
            ShowOnHeader.Text = AppResources.ShowOnHeader;
            ShowOnMainPage.Text = AppResources.ShowOnMainPage;
            Save.Text = AppResources.Save;
        }

        private void GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}