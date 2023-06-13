using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MotoGP.Controllers.KeyboardLayouts;
using MotoGP.GameEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public abstract class ControllerKeyboardBase
        : ControllerBase
    {
        protected KeyboardLayoutBase _layout;
        protected float _velocity;

        public void ChangeLayout(KeyboardLayoutBase layout)
        {
            _layout = layout;
        }

        public void SetVelocity(float velocity)
        {
            _velocity = velocity;
        }

        public ControllerKeyboardBase()
        {
            _layout = new KeyboardLayoutArrows();
            _velocity = 1;
        }


        public abstract void ProcessAction(EnumActionKey action, ref Vector2 delta);

        public override void Update(GameTime gametime)
        {
            KeyboardState ks = Keyboard.GetState();
            Vector2 delta = new Vector2(0, 0);

            Keys[] pressedKeys = ks.GetPressedKeys();

            foreach(var k in pressedKeys)
            {
                EnumActionKey action = _layout.GetAction(k);

                ProcessAction(action, ref delta);
            }

            _controlled.Move(delta);
        }
    }
}
