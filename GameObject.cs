using Raylib_cs;
using System.Numerics;
namespace TowerDefense
{
    class GameObject
    {
        public Vector2 position { get; set; } = new Vector2(0, 0);
        public Vector2 movespeed { get; set; } = new Vector2(0, 0);
        public Rectangle hitbox;
        virtual public void draw()
        {
            hitbox = new Rectangle((int)position.X, (int)position.Y, 30, 30);
        }
        public void Move()
        {
            Vector2 NewPosition = this.position;
            NewPosition.X += movespeed.X;
            NewPosition.Y += movespeed.Y;
            this.position = NewPosition;
            hitbox.x = NewPosition.X;
            hitbox.y = NewPosition.Y;
        }
    }
    
}