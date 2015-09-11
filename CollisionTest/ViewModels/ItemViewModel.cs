using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollisionTest.Interfaces;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CollisionTest.ViewModels
{
    public class ItemViewModel : ReactiveObject, IDrawingObject
    {
        [Reactive]
        public string Id { get; protected set; }

        [Reactive]
        public int Left { get; set; }

        [Reactive]
        public int Width { get; set; }
    }
}
