using Fortnite2.Domain.Entities.PointingLogic;
using Fortnite2.Domain.Entities.Shoot;

namespace Fortnite2.Domain.Entities
{
    public abstract class Entity: IShooter, IPointer
    {
        //properties
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int XPosition { get; protected set; }
        public int YPosition { get; protected set; }
        public BulletType Bullet { get; protected set; }
        public Pointing Pointing { get; protected set; }

        //constructor
        public Entity() { }
        public Entity(string name)
        {
            Name = name;
            Health = 100;
            XPosition = 0;
            YPosition = 0;
            Pointing = Pointing.South;

        }
        public Entity(string name, int health)
        {
            Name = name;
            Health = health;
            XPosition = 0;
            YPosition = 0;
            Pointing = Pointing.South;
        }
        public Entity(string name, int health, int x, int y)
        {
            Name = name;
            Health = health;
            XPosition = x;
            YPosition = y;
            Pointing = Pointing.South;
        }
        public Entity(string name, int health, int x, int y, Pointing poinitng)
        {
            Name = name;
            Health = health;
            XPosition = x;
            YPosition = y;
            Pointing = poinitng;
        }

        //Methods
        public virtual void Shoot() 
        {
            //TO DO: shoot logic
        }
        
        public virtual void Move(int  x, int y)
        {
            XPosition += x;
            YPosition += y;
        }

        public virtual void ChangePointing(Pointing pointing)
        {

        }
    }
}
