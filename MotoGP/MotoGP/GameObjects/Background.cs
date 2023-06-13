using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotoGP.Helpers;

namespace MotoGP.GameObjects
{
    public class Background
        :GameObjectStatic
    {
        protected Rectangle _rectScreen;

        public Background(Texture2D texture)
            : base(texture)
        {
            _rectScreen = new Rectangle(
                0, 0,
                Shared.ScreenWidth,
                Shared.ScreenHeight
                );
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Begin();
            base.Draw(batch);
            batch.End();
        }

        public void DrawStretch(SpriteBatch batch)
        {
            batch.Begin();
            batch.Draw(_texture, _rectScreen, Color.White);
            batch.End();
        }

        public void DrawTiling(SpriteBatch batch)
        {
            batch.Begin(
                SpriteSortMode.Deferred,
                null,
                SamplerState.PointWrap);

            batch.Draw(_texture, Vector2.Zero, _rectScreen, Color.White);
            batch.End();
        }

        public void DrawStretchUniform(SpriteBatch batch)
        {
            float q = _texture.Width / (float)_texture.Height;

            int height = (int)(Shared.ScreenWidth / q);

            _rectScreen.Height = height;

            batch.Begin();
            batch.Draw(_texture, _rectScreen, null, Color.White);
            batch.End();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _rectScreen.X+=5;
        }
    }
}
