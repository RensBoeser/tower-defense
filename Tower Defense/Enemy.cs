using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Defense
{
  class Enemy : IEnemy
  {
    private int health;

    private Tuple<int, int> position;
    private IPath path;
    private int target;
    private int rotation;

    private int speed;
    private int width;
    private int height;

    private int level;
    private string type;
    private int damage;

    public Enemy(int x, int y, int w, int h, int speed, int level, int damage, string type, IPath path)
    {
      this.position = new Tuple<int, int>(x, y);
      this.width = w;
      this.height = h;
      this.speed = speed;
      this.level = level;
      this.damage = damage;
      this.type = type;
      this.path = path;
      this.health = 100;
      this.target = 0;
    }

    public void move(double speed)
    {
      double distance = Math.Sqrt(Math.Pow(path.getNodes()[target].Item1 - position.Item1, 2) + Math.Pow(position.Item2 - path.getNodes()[target].Item2, 2));
      if (speed > distance)
      {
        position = path.getNodes()[target];
        getNextNode();
        double newspeed = speed - distance;
        move(newspeed);
      }
      else if (speed < distance)
      {
        int x = Convert.ToInt32(speed * (path.getNodes()[target].Item1 - position.Item1) / distance + position.Item1);
        int y = Convert.ToInt32(speed * (position.Item2 - path.getNodes()[target].Item2) / distance + position.Item2);

        position = new Tuple<int, int>(x, y);
      }
      else if (speed == distance)
      {
        position = path.getNodes()[target];
        getNextNode();
      }
    }

    public void getNextNode()
    {
      if (this.target < path.getNodes().Count)
      {
        this.target += 1;
      }
      else
      {
        // DAMAGE THE BASE
        throw new NotImplementedException();
      }

    }

    public void takeDamage(int damage, string damageType)
    {
      throw new NotImplementedException();
      // algorithm
    }

    public void showHealth()
    {
      throw new NotImplementedException();
      // draw either a healthbar or text above the enemy
    }

    public Tuple<int, int> getPosition()
    {
      return position;
    }

    public void draw(SpriteBatch spriteBatch)
    {
      throw new NotImplementedException();
    }
  }
}
