using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace topic_1_monogame
{
    public class Game1 : Game
    {
        Texture2D starsTexture;
        Texture2D purplespaceTexture;
        Texture2D planetTexture;
        Texture2D deathstarsTexture;
        Texture2D deathbeamTexture;
        Texture2D boomTexture;
        Texture2D alienHDTexture;

        MouseState mouseState;//MOUSE


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            starsTexture = Content.Load<Texture2D>("stars");
            purplespaceTexture = Content.Load<Texture2D>("purplespace");
            planetTexture = Content.Load<Texture2D>("planet");
            deathstarsTexture = Content.Load<Texture2D>("deathstars");
            deathbeamTexture = Content.Load<Texture2D>("deathbeam");
            boomTexture = Content.Load<Texture2D>("boom");
            alienHDTexture = Content.Load<Texture2D>("alienHD");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();//MOUSE
            Window.Title = mouseState.X + ", " + mouseState.Y;//MOUSE

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Violet);


            _spriteBatch.Begin();
            _spriteBatch.Draw(starsTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(planetTexture, new Rectangle(150, 120, 300, 300), Color.White);
            _spriteBatch.Draw(deathstarsTexture, new Vector2(500, 25), Color.White);
            _spriteBatch.Draw(deathbeamTexture, new Vector2(255, 120), Color.White);
            _spriteBatch.Draw(boomTexture, new Rectangle(170, 120, 150, 150), Color.White);
            _spriteBatch.Draw(alienHDTexture, new Rectangle(325, 10, 50, 130), Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}