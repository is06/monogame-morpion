using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Morpion
{
    public class MorpionGame : Game
    {
        public SpriteBatch? SpriteBatch { get; private set; }

        private GraphicsDeviceManager _graphics;

        private Slot[] _slots;

        public MorpionGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _slots = new Slot[9];
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 480;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            var positionX = 32;
            var positionY = 32;
            for (var i = 0; i < 9; i++) {
                if (i > 0 && i % 3 == 0) {
                    positionX = 32;
                    positionY += 72;
                }
                _slots[i] = new Slot(this);
                _slots[i].Position.X = positionX;
                _slots[i].Position.Y = positionY;
                positionX += 72;
            }

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (var slot in _slots) {
                slot.Update();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            SpriteBatch?.Begin();

            foreach (var slot in _slots) {
                slot.Draw();
            }

            SpriteBatch?.End();

            base.Draw(gameTime);
        }
    }
}
