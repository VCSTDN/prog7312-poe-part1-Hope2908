using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading; // Added for DispatcherTimer

namespace LibraryApp
{
    public partial class Sorting : Window
    {
        private List<string> generatedCallNumbers = new List<string>();
        private int pointCount = 0; // Track the number of points earned

        public Sorting()
        {
            InitializeComponent();
        }

        private void GenerateRandomCallNumbers_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous data
            ClearCallNumbersLists();

            // Generate 10 random call numbers
            GenerateRandomCallNumbers();

            // Enable sorting and display progress
            EnableSorting();
        }

        private void ClearCallNumbersLists()
        {
            generatedCallNumbers.Clear();
            CallNumbersListBox.Items.Clear();
            SortedCallNumbersListBox.Items.Clear();
        }

        private void GenerateRandomCallNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string callNumber = $"{random.Next(1000):D3}.{random.Next(100):D2} {GetRandomAuthorSurname()}";
                generatedCallNumbers.Add(callNumber);
                AddCallNumberButton(callNumber);
            }
        }

        private string GetRandomAuthorSurname()
        {
            string[] surnames = { "AXB", "BCG", "ANP", "ZYP", "LVZ" };
            return surnames[new Random().Next(surnames.Length)];
        }

        private void AddCallNumberButton(string callNumber)
        {
            Button callNumberButton = new Button
            {
                Content = callNumber,
                Width = 150,
                Margin = new Thickness(0, 5, 0, 0)
            };
            callNumberButton.Click += CallNumberButton_Click;
            CallNumbersListBox.Items.Add(callNumberButton);
        }

        private void EnableSorting()
        {
            CallNumbersListBox.IsEnabled = true;
            SortButton.IsEnabled = true;
            pointCount = 0; // Reset points to 0
            UpdatePointCount(); // Initialize point count to 0
        }

        private void CallNumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedCallNumber = clickedButton.Content.ToString();
            MoveCallNumberToSorted(selectedCallNumber, clickedButton);
        }

        private void MoveCallNumberToSorted(string callNumber, Button buttonToRemove)
        {
            CallNumbersListBox.Items.Remove(buttonToRemove);
            SortedCallNumbersListBox.Items.Add(callNumber);
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> userSortedCallNumbers = GetUserSortedCallNumbers();

            bool isOrderCorrect = CheckUserInputOrder(userSortedCallNumbers);

            if (isOrderCorrect)
            {
                // Calculate points based on correct sorts
                int earnedPoints = userSortedCallNumbers.Count * 10;
                pointCount += earnedPoints;

                if (pointCount == 100)
                {
                    // User earned 100 points, show animation here
                    ShowPointsAnimation();
                }
            }

            ShowResultMessage(isOrderCorrect);
        }

        private void ShowPointsAnimation()
        {
            double startValue = 0;
            double endValue = 100;
            double step = 1; // You can adjust the step value to control the animation speed

            // Create a DispatcherTimer to update the points with animation
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(50); // Adjust the interval for smoother animation
            timer.Tick += (sender, e) =>
            {
                if (startValue <= endValue)
                {
                    PointCountTextBlock.Text = $"Points: {startValue:F0}";
                    startValue += step;
                }
                else
                {
                    PointCountTextBlock.Text = $"Points: {endValue:F0}";
                    timer.Stop();
                }
            };

            // Start the animation
            timer.Start();

            // You can also add additional celebratory animations or effects here if needed
            // For example, change the color, play a sound, etc.
        }

        private List<string> GetUserSortedCallNumbers()
        {
            return SortedCallNumbersListBox.Items.Cast<string>().ToList();
        }

        private bool CheckUserInputOrder(List<string> userSortedCallNumbers)
        {
            for (int i = 0; i < userSortedCallNumbers.Count - 1; i++)
            {
                if (string.Compare(userSortedCallNumbers[i], userSortedCallNumbers[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void ShowResultMessage(bool isOrderCorrect)
        {
            if (isOrderCorrect)
            {
                MessageBox.Show($"Congratulations! Your sorting is correct. You earned {pointCount} points. 🎉", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Oops! Your sorting is incorrect. Please try again. 😞", "Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                // You may choose to decrease the point count for incorrect attempts here.
            }
        }

        private void UpdatePointCount()
        {
            PointCountTextBlock.Text = $"Points: {pointCount}";
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous data and restart the sorting process
            ClearCallNumbersLists();
            GenerateRandomCallNumbers();
            EnableSorting();
        }
    }
}
