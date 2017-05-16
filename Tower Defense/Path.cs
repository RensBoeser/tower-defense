using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
  class Path : IPath
  {
    private List<Tuple<int, int>> nodes;
    public Path(List<Tuple<int, int>> nodes)
    {
      this.nodes = nodes;
    }

    public List<Tuple<int, int>> getNodes()
    {
      return nodes;
    }

    public void draw(SpriteBatch spriteBatch)
    {
      Texture2D texture = new Texture2D(spriteBatch.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
      texture.SetData<int>(new Int32[] { 0xFFFFFF }, 0, texture.Width * texture.Height);
      spriteBatch.Draw(texture, new Microsoft.Xna.Framework.Rectangle(10, 10, 100, 100), new Microsoft.Xna.Framework.Color(255, 0, 0));
    }
  }
}
