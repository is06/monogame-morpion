using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Morpion
{
    class Slot
    {
        public Vector2 Position;
        private Game _game;
        private Texture2D _circleTexture;

        public Slot(Game game)
        {
            _game = game;
            _circleTexture = _game.Content.Load<Texture2D>("circle");
        }

        public void Update()
        {

        }

        public void Draw()
        {
            if (_game is MorpionGame g) {
                g.SpriteBatch?.Draw(
                    texture: _circleTexture,
                    position: Position,
                    sourceRectangle: new Rectangle(0, 0, 64, 64),
                    color: Color.White,
                    rotation: 0f,
                    origin: Vector2.Zero,
                    scale: Vector2.One,
                    effects: SpriteEffects.None,
                    layerDepth: 0
                );
            }
        }
    }
}