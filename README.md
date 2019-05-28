# Xamarin.Forms_browser
A simple browser app using webview controler in xamarin.forms.


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
