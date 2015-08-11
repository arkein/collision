using System;
using System.Windows.Media;
using ReactiveUI.Fody.Helpers;

namespace CollisionTest.ViewModels
{
    public class SquareItemViewModel : ItemViewModel
    {
        public SquareItemViewModel()
        {
            var rnd = new Random();
            Color = new SolidColorBrush(System.Windows.Media.Color.FromScRgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
            Width = 50;
        }

        [Reactive]
        public Brush Color { get; private set; }
    }
}