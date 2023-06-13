using Microsoft.Xna.Framework.Input;
using MotoGP.GameEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Controllers.KeyboardLayouts
{
    public class KeyboardLayoutBase
    {
        protected Dictionary<Keys, EnumActionKey> _dictionary;

        public KeyboardLayoutBase()
        {
            _dictionary = new Dictionary<Keys, EnumActionKey>();
        }

        public void AddAction(Keys key, EnumActionKey action)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary[key] = action;
            }
            else
            {
                _dictionary.Add(key, action);
            }
        }

        public EnumActionKey GetAction(Keys k)
        {
            if (_dictionary.ContainsKey(k))
            {
                return _dictionary[k];
            }

            return EnumActionKey.None;
        }
    }
}
