using Microsoft.Xna.Framework.Input;
using MotoGP.GameEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers.KeyboardLayouts
{
    public class KeyboardLayoutArrows
        : KeyboardLayoutBase
    {
        public KeyboardLayoutArrows() : base()
        {
            AddAction(Keys.Up, EnumActionKey.MoveUp);
            AddAction(Keys.Right, EnumActionKey.MoveRight);
            AddAction(Keys.Down, EnumActionKey.MoveDown);
            AddAction(Keys.Left, EnumActionKey.MoveLeft);
        }
    }
}
