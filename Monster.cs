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
        int value;

        public Monster (string name, int hp, int size, int moveSpeed, int value)
        {
            this.hp = hp;
            this.movementSpeed = moveSpeed;
            this.size = size;
            this.name = name;
            this.value = value;
        }

        public int damageMonster()
        {
            if (Monster.hit == true)

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
