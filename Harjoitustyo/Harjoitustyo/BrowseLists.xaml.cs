using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Harjoitustyo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class BrowseLists : Page
    {
        public BrowseLists()
        {
            this.InitializeComponent();
        }

        private void GoBack_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void InventaarioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddNew));
        }

        private async void OpenExplorer_button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.Pickers.FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.ComputerFolder;
            openPicker.FileTypeFilter.Add(".txt");

            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            string text = await Windows.Storage.FileIO.ReadTextAsync(file);

            textBlock.Text = text;
        
        }
    }
}
