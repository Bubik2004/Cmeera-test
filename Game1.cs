using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cmeera_test
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Player Squirt;
        private Tree tree;
        private Texture2D tex;
        private Vector2 pos;
        private Vector2 size;
        private InputManager inputMan = new InputManager();

        private Camera Cam;


        private float inZoomAmount;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
       

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            inZoomAmount = 0.5f;
            Cam = new Camera(GraphicsDevice.Viewport);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tex = Content.Load<Texture2D>("squirtle");
            Squirt = new Player(tex, new Vector2(1, 1), new Vector2(30, 50));

            tex = Content.Load<Texture2D>("Big_tree");
            tree = new Tree(tex, new Vector2(100, 100), new Vector2(50, 70));


            



            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            inputMan.CheckKeys(Squirt);


            Cam.AdjustZoom(inZoomAmount);
            Cam.UpdateCamera(GraphicsDevice.Viewport);
            Cam.MoveCamera(Squirt.spritePosition);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            BeginDraw();

            Squirt.DrawSprite(_spriteBatch, Squirt.spriteTexture);
            tree.DrawSprite(_spriteBatch, tree.spriteTexture);

            EndDraw();

            base.Draw(gameTime);
        }
    }
}
