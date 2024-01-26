using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class MyGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D ball, playerRacket, enemyRacket;

        public MyGame()
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

            // TODO: use this.Content to load your game content here
            ball = Content.Load<Texture2D>("sprites/ball");
            playerRacket = Content.Load<Texture2D>("sprites/racket");
            enemyRacket = Content.Load<Texture2D>("sprites/racket");
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
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            base.Draw(gameTime);

            _spriteBatch.Begin();

            //Window default: 800x480

            _spriteBatch.Draw(ball, new Rectangle((800/2)-(25/2), (480/2) - (25/2), 25, 25), Color.White);

            _spriteBatch.Draw(playerRacket, new Rectangle(0 + 10, (480/2) - (120/2), 40, 120), Color.White);

            _spriteBatch.Draw(enemyRacket, new Rectangle(800 - 40 - 10, (480/2) - (120/2), 40, 120), Color.White);

            _spriteBatch.End();
        }
    }
}
