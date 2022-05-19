using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Listing_8_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ArrayList Children = new ArrayList();
        }

        private static void AddChild(string firstName, string lastName, ArrayList Children)
        {
            Children.Add(new Person(firstName, lastName));
        }

        private static void DeleteChild(int index, ArrayList Children)
        {
            Children.Remove(index);
        }

        private static Person GetChild(int index, ArrayList Children)
        {
            return (Person)Children[index];
        }
    }
}
