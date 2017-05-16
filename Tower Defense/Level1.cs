using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
  class Level1 : ILevel
  {
    IPath path;
    public Level1(IPath path)
    {
      this.path = path;
    }
    public IPath getPath()
    {
      return path;
    }
  }
}
