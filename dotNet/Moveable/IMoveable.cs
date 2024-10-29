using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moveable
{
    public interface IMoveable
    {
        void MoveDown();
        void MoveUp();
        void MoveLeft();
        void MoveRight();
    }
}