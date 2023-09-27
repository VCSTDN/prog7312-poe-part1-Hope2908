using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace LibraryApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            InfoPopup.IsOpen = true;
        }

        private void Sorting_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Sorting window
            Sorting SortingWindow = new Sorting();
            SortingWindow.Show(); // Show the Sorting window
            this.Close(); // Close the current MainWindow if needed
        }

        private void IdentifyingAreas_Click(object sender, RoutedEventArgs e)
        {
            // Add code for Identifying Areas button click
        }

        private void FindingCallNumbers_Click(object sender, RoutedEventArgs e)
        {
            // Add code for Finding Call Numbers button click
        }
    }
}
