using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.GameObjects
{
    public abstract class GameObjectBase
        : DrawableObject
    {
        public Texture2D Texture
        {
            get { return _texture; }
            set
            {
                _texture = value;
            }
        }

        public GameObjectBase(Texture2D texture) 
            : base(texture)
        {
        }
    }
}
