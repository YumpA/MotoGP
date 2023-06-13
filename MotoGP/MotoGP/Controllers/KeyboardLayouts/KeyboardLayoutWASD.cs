using Microsoft.Xna.Framework.Input;
using MotoGP.GameEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers.KeyboardLayouts
{
    public class KeyboardLayoutWASD
        : KeyboardLayoutBase
    {
        public KeyboardLayoutWASD() : base()
        {
            AddAction(Keys.W, EnumActionKey.MoveUp);
            AddAction(Keys.D, EnumActionKey.MoveRight);
            AddAction(Keys.S, EnumActionKey.MoveDown);
            AddAction(Keys.A, EnumActionKey.MoveLeft);
        }
    }
}
