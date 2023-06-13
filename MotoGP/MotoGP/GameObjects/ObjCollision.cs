using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MotoGP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.GameObjects
{
    public class ObjCollision
        :GameObjectMovable
    {

        public bool IsBoxVisible;
        public Color BoxColor;

        public Rectangle GetBoundingBox()
        {
            return new Rectangle(
                (int) (Position.X - _origin.X),
                (int) (Position.Y - _origin.Y),
                _texture.Width/4,
                _texture.Height/4);
        }

        public ObjCollision(Texture2D texture) : base(texture)
        {
            IsBoxVisible = true;
            BoxColor = Color.Green;
        }

        public virtual bool IsCollide(ObjCollision collide)
        {
            Rectangle r1 = this.GetBoundingBox();
            Rectangle r2 = collide.GetBoundingBox();

            return r1.Intersects(r2);
        }
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            if (IsBoxVisible)
            {
                Geometry.DrawRectangle(
                    spriteBatch,
                    Position.X - _origin.X,
                    Position.Y - _origin.Y,
                    Position.X + _texture.Width - _origin.X,
                    Position.Y + _texture.Height - _origin.Y,
                    BoxColor,
                    1);
            }
        }
    }
}
