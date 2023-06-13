using MotoGP.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public abstract class ControllerBase
        : UptadableObject
    {
        protected GameObjectMovable _controlled;

        public void Attach(GameObjectMovable controlled)
        {
            _controlled = controlled;
        }
    }
}
