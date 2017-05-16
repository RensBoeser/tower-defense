using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
  class Main
  {
    Texture2D dot;
    public Main(Texture2D dot)
    {
      this.dot = dot;
    }
    ILevel level = new Level1(new Path(
                              new List<Tuple<int, int>>()
                              { new Tuple<int, int>(10, 10),
                                new Tuple<int, int>(200, 100),
                                new Tuple<int, int>(300, 150)}));
    public void draw(SpriteBatch spriteBatch)
    {
      level.getPath().draw(spriteBatch);
    }
  }
}
