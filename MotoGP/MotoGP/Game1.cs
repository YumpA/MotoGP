using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MotoGP.Controllers;
using MotoGP.GameObjects;
using MotoGP.Helpers;
using System.Collections.Generic;

namespace MotoGP
{
    public class Game1 : Game
    {
        private List<ObjCollision> _collisions;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private ControllerKeyboardSimple _keyboard1;
        //private ControllerKeyboardSimple _keyboard2;

        private ObjCollision _tree1;
        private ObjCollision _tree2;
        private ObjCollision _tree3;


        private Background _background1;

        //private GameObjectMovable _biker1;
        private ObjCollision _biker1;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);

            _graphics.PreferredBackBufferWidth = 1440;
            _graphics.PreferredBackBufferHeight = 900;
            _graphics.IsFullScreen = false;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            Shared.ScreenWidth = _graphics.PreferredBackBufferWidth;
            Shared.ScreenHeight = _graphics.PreferredBackBufferHeight;
        }

        protected override void Initialize()
        {
            base.Initialize();

            _collisions = new List<ObjCollision>();
            //_collisions.Add(_objCollision1);
            _collisions.Add(_biker1);
            _collisions.Add(_tree1);
            _collisions.Add(_tree2);
            _collisions.Add(_tree3);

            _biker1.SetPosition(70, 600);
            //_objCollision1.SetPosition(0, 0);

            _tree1.SetPosition(1500, 20);
            _tree2.SetPosition(2000, 230);
            _tree3.SetPosition(3500, 20);

            _tree1.SetVelocity(-5, 0);
            _tree2.SetVelocity(-5, 0);
            _tree3.SetVelocity(-5, 0);

            _keyboard1 = new ControllerKeyboardSimple();
            _keyboard1.Attach(_biker1);
            //_keyboard1.Attach(_objCollision1);
            _keyboard1.SetVelocity(2);

        }

        protected override void LoadContent()
        {
            Shared.Device = GraphicsDevice;
            Geometry.Pixel = GeneratorTextures.TexturePixel(_graphics.GraphicsDevice);


            _spriteBatch = new SpriteBatch(GraphicsDevice);


            Texture2D map = Content.Load<Texture2D>("MotoGP_map1");
            Texture2D textureBiker = Content.Load<Texture2D>("MotoGP_biker");

            //_objCollision1 = new ObjCollision(textureBiker);
            _tree1 = new ObjCollision(Content.Load<Texture2D>("MotoGP_tree1"));
            _tree2 = new ObjCollision(Content.Load<Texture2D>("MotoGP_tree2"));
            _tree3 = new ObjCollision(Content.Load<Texture2D>("MotoGP_tree3"));


            _biker1 = new ObjCollision(textureBiker);
            _background1 = new Background(map);
        }

        private void Detection()
        {
            for (int i = 0; i < _collisions.Count - 1; i++)
            {
                for(int j = i+1; j < _collisions.Count; j++)
                {
                    ObjCollision objI = _collisions[i];
                    ObjCollision objJ = _collisions[j];

                    if (objI.IsCollide(objJ))
                    {
                        objI.BoxColor = Color.Transparent;
                        objJ.BoxColor = Color.Transparent;

                        if (objI.LastMove != null)
                        {
                            objI.Move(-objI.LastMove.Value);

                        }
                    }
                    else
                    {
                        
                        objI.BoxColor = Color.Transparent;
                        objJ.BoxColor = Color.Transparent;
                    }
                }
            }
        }

        protected override void Update(GameTime gameTime)
        {
            _background1.Update(gameTime);
            _keyboard1.Update(gameTime);

            _tree1.Update(gameTime);
            _tree2.Update(gameTime);
            _tree3.Update(gameTime);

            Detection();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);

            _background1.DrawTiling(_spriteBatch);

            _spriteBatch.Begin();

            _biker1.Draw(_spriteBatch);
            //_objCollision1.Draw(_spriteBatch);

            _tree1.Draw(_spriteBatch);
            _tree2.Draw(_spriteBatch);
            _tree3.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}