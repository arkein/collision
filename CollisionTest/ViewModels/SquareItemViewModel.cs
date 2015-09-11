using System;
using System.Windows.Media;
using ReactiveUI.Fody.Helpers;

namespace CollisionTest.ViewModels
{
    public class SquareItemViewModel : ItemViewModel
    {
        public SquareItemViewModel(string id)
        {
            Id = id;
            var rnd = new Random();
            Color = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
            Width = rnd.Next(25, 75);
        }

        [Reactive]
        public Brush Color { get; private set; }

        public override string ToString()
        {
            return string.Format("Left = {0}, Width = {1}", Left, Width);
        }
    }
}