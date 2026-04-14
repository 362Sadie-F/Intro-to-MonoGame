using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro_to_MonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle window;
        Texture2D dinoTexure;
        Texture2D moonTexture;
        Texture2D summonTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 820, 620);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            this.Window.Title = "Topic 1 Assignment";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexure = Content.Load<Texture2D>("dino");

            moonTexture = Content.Load<Texture2D>("moon corner bottom");

            summonTexture = Content.Load<Texture2D>("Summon2");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightSteelBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(summonTexture, new Vector2(-85, 215), Color.FloralWhite);
            _spriteBatch.Draw(moonTexture, new Vector2(-15, -10),null, Color.White, 0f, Vector2.Zero, 1.0f, SpriteEffects.FlipHorizontally | SpriteEffects.FlipVertically, 1f);
            _spriteBatch.Draw(dinoTexure, new Vector2(350, 100),null, Color.Thistle, 0f, Vector2.Zero, 1.0f, SpriteEffects.FlipHorizontally, 1f);
            _spriteBatch.Draw(dinoTexure, new Vector2(110, 200), Color.Fuchsia);
            _spriteBatch.Draw(moonTexture, new Vector2(499, 197), Color.Ivory);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
