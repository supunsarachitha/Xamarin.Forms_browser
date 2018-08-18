using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App12
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "http://www.google.com/search?q=" + SearchBar.Text;
            SearchButton.Text = "Loading...";
            await Task.Delay(1000);
        }

        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            SearchButton.Text = "Back";

        }
    }
}
