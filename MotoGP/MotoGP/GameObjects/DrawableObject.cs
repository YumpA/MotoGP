using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.GameObjects
{
    public abstract class DrawableObject
        : UptadableObject
    {
        protected Texture2D _texture;
        protected Vector2 _position;
        protected Vector2 _origin;

        public void SetPosition(float x, float y)
        {
            _position.X = x;
            _position.Y = y;
        }


        public DrawableObject(Texture2D texture)
        {
            _texture = texture;
            _position = new Vector2(0, 0);
            _origin = new Vector2(texture.Width, texture.Height);
        }

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
