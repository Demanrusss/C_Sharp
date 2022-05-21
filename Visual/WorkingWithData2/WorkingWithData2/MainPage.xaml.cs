using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WorkingWithData2.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WorkingWithData2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Person Data = new Person();
        public MainPage()
        {
            this.InitializeComponent();
            Data.FirstName = "Ivan";
            Data.LastName = "Ivanov";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(Data.FirstName);
            messageDialog.ShowAsync().AsTask();
        }
    }
}
