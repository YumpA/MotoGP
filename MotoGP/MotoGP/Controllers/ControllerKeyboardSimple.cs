using Microsoft.Xna.Framework;
using MotoGP.GameEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class ControllerKeyboardSimple
        : ControllerKeyboardBase
    {
        public override void ProcessAction(EnumActionKey action, ref Vector2 delta)
        {
            switch (action)
            {
                case EnumActionKey.None:
                    break;
                case EnumActionKey.MoveUp:
                    delta.Y = - _velocity;
                    break;
                case EnumActionKey.MoveRight:
                    delta.X = _velocity;
                    break;
                case EnumActionKey.MoveDown:
                    delta.Y = _velocity;
                    break;
                case EnumActionKey.MoveLeft:
                    delta.X = - _velocity;
                    break;
            }
        }
    }
}
