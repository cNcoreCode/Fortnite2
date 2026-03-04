using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fortnite2.Domain.Entities.PointingLogic;
using Fortnite2.Domain.Entities.Shoot;

namespace Fortnite2.Domain.Entities
{
    public class Player: Entity
    {
        public Player(): base()
        {
            Bullet = BulletType.OpenSource;
        }
        public Player(string name) : base(name)
        {
            Bullet = BulletType.OpenSource;
        }
        public Player(string name, int health) : base(name, health)
        {
            Bullet = BulletType.OpenSource;
        }
        public Player(string name, int health, int x, int y) : base(name, health, x, y)
        {
            Bullet = BulletType.OpenSource;
        }
        public Player(string name, int health, int x, int y, Pointing poinitng) : base(name, health, x, y, poinitng)
        {
            Bullet = BulletType.OpenSource;
        }
    }
}
