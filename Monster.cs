using Raylib_cs;
namespace TowerDefense
{

    class Monster
    {
        int hp;
        int movementSpeed;
        int size;
        string name;
        bool hit = false;

        public Monster(string name, int hp, int size, int moveSpeed)
        {
            self.hp = hp;
            self.movementSpeed = moveSpeed;
            self.size = size;
            self.name = name;
        }

        public int damageMonster()
        {
            if (Monster.hit == true)
            {
                Monster.hp -= Tower.damage;
                /* 
                come back and change this later when the tower damage
                variable is created.
                */
                Monster.hit == false;
                return Monster.hp;
            }
        }
    }
}
