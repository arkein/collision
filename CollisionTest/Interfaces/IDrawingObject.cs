using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollisionTest.Interfaces
{
    public interface IDrawingObject
    {
        int Left { get; set; }
        int Width { get; }
    }
}
