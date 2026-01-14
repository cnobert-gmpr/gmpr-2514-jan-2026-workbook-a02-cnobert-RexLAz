using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson02;

public class IntroGame : Game
{
    //an object that represents the screen
    private GraphicsDeviceManager _graphics;
    //an object that batches up draw commands so that they can be sent
    //to the screen all at once
    private SpriteBatch _spriteBatch;

    private Texture2D _pixel;

    public IntroGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        //new texture that is one pixel by one pixel
        _pixel = new Texture2D(GraphicsDevice, 1, 1);
        _pixel.SetData(new [] {Color.White});
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Wheat);

        //all draw commands should always be with the spritebatch begin and end
        _spriteBatch.Begin();

        Rectangle rect = new Rectangle(100, 150, 80, 50);
        _spriteBatch.Draw(_pixel, rect, Color.White);
        
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
