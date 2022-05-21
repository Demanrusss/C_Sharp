using System;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EventsWPF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog("Clicked " + sender.ToString());
            messageDialog.ShowAsync().AsTask();
            e.Handled = true;
        }

        private void Border_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(sender.ToString());
            messageDialog.ShowAsync().AsTask();
        }
    }
}
