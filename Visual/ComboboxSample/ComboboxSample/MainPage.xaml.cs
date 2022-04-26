//using System;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices.WindowsRuntime;
//using Windows.Foundation;
//using Windows.Foundation.Collections;
//using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
//using Windows.UI.Xaml.Controls.Primitives;
//using Windows.UI.Xaml.Data;
//using Windows.UI.Xaml.Input;
//using Windows.UI.Xaml.Media;
//using Windows.UI.Xaml.Navigation;
using ComboboxSample.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ComboboxSample
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
                Complation = 20
            });

            Students.Add(new Student()
            {
                Icon = "Assets/constructor.png",
                FirstName = "Alex",
                Complation = 80
            });
        }
    }
}
