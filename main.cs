﻿using raylib;
namespace TowerDefense
{

    class Monster
    {
        int hp;
        int movementSpeed;
        int size;
        string name;
        bool hit = false;

        public Monster(int hp, int moveSpeed, int size, string name)
        {
            self.hp = hp;
            self.movementSpeed = moveSpeed;
            self.size = size;
            self.name = name;
        }

        public int damaged()
        {
            if (Monster.hit == true){
                Monster.hp -= Tower.damage;
            }
        }
    }
}