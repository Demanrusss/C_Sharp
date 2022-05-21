using System;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ManagingElements.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ManagingElements
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Student> Students = new ObservableCollection<Student>();

        public MainPage()
        {
            this.InitializeComponent();
            InitStudents();
        }

        void InitStudents()
        {
            Students.Add(new Student()
            {
                Icon = "Assets/ball.png",
                FirstName = "Michail",
                Completion = 20
            });

            Students.Add(new Student()
            {
                Icon = "Assets/construct.png",
                FirstName = "Alex",
                Completion = 80
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Students.Add(new Student()
            {
                Icon = "Assets/construct.png",
                FirstName = "New line",
                Completion = 50
            });
        }

        private void Highlighted_Button_Click(object sender, RoutedEventArgs e)
        {
            if (bindingListBox.SelectedItems != null)
            {
                MessageDialog messageDialog = new MessageDialog("FirstName " +
                    (bindingListBox.SelectedItem as Student).FirstName +
                    ", Index " + bindingListBox.SelectedIndex);
                messageDialog.ShowAsync().AsTask();
            }
        }
    }
}
