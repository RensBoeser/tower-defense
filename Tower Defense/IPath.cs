using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
  interface IPath : IDrawable
  {
    List<Tuple<int, int>> getNodes();
  }
}
