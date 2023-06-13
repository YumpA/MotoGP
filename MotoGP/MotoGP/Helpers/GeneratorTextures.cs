using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP.Helpers
{
    public static class GeneratorTextures
    {
        public static Texture2D TexturePixel(GraphicsDevice graphics)
        {
            var texture = new Texture2D(graphics, 1, 1);

            Color[] colors = new Color[1]
            {
                Color.White
            };

            texture.SetData<Color>(colors);

            return texture;
        }
    }
}
