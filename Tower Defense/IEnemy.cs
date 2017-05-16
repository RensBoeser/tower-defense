using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
  interface IEnemy : IDrawable
  {
    void move(double speed);
    void getNextNode();
    void takeDamage(int damage, string damageType);
    void showHealth();
    Tuple<int, int> getPosition();
  }
}
