using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Helpers
{
    public static class Geometry
    {
        public static Texture2D Pixel;

        public static void DrawRectangle(
            SpriteBatch spriteBatch,
            float x1, float y1, float x2, float y2,
            Color color,
            float penWidth
            )
        {
            if (x2 < x1)
            {
                float t = x1;
                x1 = x2;
                x2 = t;
            }
            if (y2 < y1)
            {
                float t = y1;
                y1 = y2;
                y2 = t;
            }

            float width = x2 - x1;
            float height = y2 - y1;

            spriteBatch.Draw(
                Pixel,
                new Vector2(x1, y1),
                null,
                color,
                0,
                Vector2.Zero,
                new Vector2(width, penWidth),
                SpriteEffects.None,
                1);
            spriteBatch.Draw(
                Pixel,
                new Vector2(x1, y1),
                null,
                color,
                (float)Math.PI / 2,
                Vector2.Zero,
                new Vector2(height, penWidth),
                SpriteEffects.None,
                1);

            spriteBatch.Draw(
                Pixel,
                new Vector2(x1, y2),
                null,
                color,
                0,
                Vector2.Zero,
                new Vector2(width, penWidth),
                SpriteEffects.None,
                1);
            spriteBatch.Draw(
                Pixel,
                new Vector2(x2, y1),
                null,
                color,
                (float)Math.PI / 2,
                Vector2.Zero,
                new Vector2(height, penWidth),
                SpriteEffects.None,
                1);
        }
    }
}
