using Raylib_cs;
namespace TowerDefense
{
    class Monster : GameObject
    {
        int hp;
        int size;
        string name;
        bool hit = false;
        int value;
        Color color;

        public Monster(string name, int hp, int size, int value, Color color)
        {
            this.hp = hp;
            this.size = size;
            this.name = name;
            this.value = value;
            this.color = color;
        }

        override public void draw()
        {
            Raylib.DrawRectangle((int)position.X, (int)position.Y, size, size, color);

        }
        // public int damageMonster()
        // {
        //     if (Monster.hit == true)

        //         Monster.hp -= Tower.damage;
        //     /* 
        //     come back and change this later when the tower damage
        //     variable is created.
        //     */
        //     Monster.hit == false;
        //     return Monster.hp;
            
        }
    }
}
