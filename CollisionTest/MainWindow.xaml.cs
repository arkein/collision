using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CollisionTest.ViewModels;
using ReactiveUI.Fody.Helpers;

namespace CollisionTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawingBoard = new DrawingBoardViewModel();
            DrawingBoard.AddNew(new SquareItemViewModel());
        }

        [Reactive]
        public DrawingBoardViewModel DrawingBoard { get; private set; }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            DrawingBoard.AddNew(new SquareItemViewModel());
        }
    }
}
