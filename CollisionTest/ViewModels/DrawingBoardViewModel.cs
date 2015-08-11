using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollisionTest.Interfaces;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CollisionTest.ViewModels
{
    public class DrawingBoardViewModel : ReactiveObject
    {
        private readonly ReactiveList<IDrawingObject> _drawingObjects;
        public DrawingBoardViewModel()
        {
            _drawingObjects = new ReactiveList<IDrawingObject> { ChangeTrackingEnabled = true };
        }

        public IReadOnlyReactiveList<IDrawingObject> Items
        {
            get { return _drawingObjects; }
        }

        public void AddNew(IDrawingObject drawingObject)
        {
            drawingObject.Left = _drawingObjects.Sum(x => x.Width);
            _drawingObjects.Add(drawingObject);
        }
    }
}
