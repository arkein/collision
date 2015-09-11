using System;
using System.Windows;
using CollisionTest.ViewModels;
using ReactiveUI.Fody.Helpers;
using System.Collections;

namespace CollisionTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string TestData = "Lorem Ipsum Dolor Sit Amet";
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            DrawingBoard = new DrawingBoardViewModel();
            DrawingBoard.AddNew(new SquareItemViewModel(NewId()));
            Board.DataContext = DrawingBoard;
        }

        private string NewId()
        {
            var start = rnd.Next(0, TestData.Length - 3);
            var length = rnd.Next(2, 3);
            return TestData.Substring(start, length);
        }

        [Reactive]
        public DrawingBoardViewModel DrawingBoard { get; private set; }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            var item = new SquareItemViewModel(NewId());
            DrawingBoard.AddNew(item);
            Log.Log.Message(string.Format("Added new item: {0}", item));
        }
    }
}
