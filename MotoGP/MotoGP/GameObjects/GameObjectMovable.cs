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

    public class GameObjectMovable
        : DrawableObject
    {
        protected Vector2 _velocity;
        protected Rectangle _rectScreen;
        protected Vector2? _lastMove;

        public Vector2 Position
        {
            get { return _position; }
        }

        public Vector2? LastMove
        {
            get { return _lastMove; }
        }

        public void SetVelocity(float vx, float vy)
        {
            //_velocity.X = vx;
            //_velocity.Y = vy;
            _velocity = new Vector2(vx, vy);
        }

        public void Move(Vector2 delta)
        {
            _position += delta;
            _lastMove = delta;
        }

        public GameObjectMovable(Texture2D texture)
            : base(texture)
        {
            _velocity=new Vector2(0, 0);
            _rectScreen = new Rectangle(0, 0, Shared.ScreenWidth, Shared.ScreenHeight);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }

        public override void Update(GameTime gametime)
        {
            _position += _velocity;
        }
    }
}
