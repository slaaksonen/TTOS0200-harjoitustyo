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
    public sealed partial class AddNew : Page
    {
        public class Items
        {
            public string Tuote { get; set; }
            public string Kpl { get; set; }
            public string AHinta { get; set; }
            public string YHinta { get; set; }

            public override string ToString()
            {
                return Tuote + "         -   " + Kpl + "   -   " + AHinta + "   -   " + YHinta;
            }
        }

        public AddNew()
        {
            this.InitializeComponent();
        }

        public static  List<Items> items = new List<Items>();
        private async void TallennaButton_Click(object sender, RoutedEventArgs e)
        {           
           try
           {
                int yhteensa = Convert.ToInt32(KplTextBox.Text) * Convert.ToInt32(AHintaTextBox.Text);


                items.Add(new Items
                {
                    Tuote = TuoteTextBox.Text,
                    Kpl = KplTextBox.Text,
                    AHinta = AHintaTextBox.Text,
                    YHinta = Convert.ToString(yhteensa)
                });

                foreach (Items item in items)
                {
                    TallennettuTextBlock.Text ="Seuraava tieto tallennettu : " + Convert.ToString(item);
                }
            }
           catch (FormatException)
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "Tekstissä tapahtui virhe",
                    Content = "Tarkista että hinta ja kpl ovat numeroita",
                    PrimaryButtonText = "Ok"

                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }                    
        }

        private void GoBack_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public async void TallennaInventaarioButton_Click(object sender, RoutedEventArgs e)
        {
            string FileName = NimiTextBox.Text;

            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.CreateFileAsync(FileName,
                    Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.AppendTextAsync(sampleFile, "Tämä inventaario luotiin : " + PvmTextBox.Text + Environment.NewLine + "Tuote    -   Kpl    -  AHinta    -      Yhinta" + Environment.NewLine);

            foreach (object item in items)
            {
                
                await Windows.Storage.FileIO.AppendTextAsync(sampleFile, Convert.ToString(item) + Environment.NewLine);
            }
        }
    }
}
