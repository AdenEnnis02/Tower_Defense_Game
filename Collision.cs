
using Raylib_cs;
using System.Numerics;

public class Collision
{
    public int thingOneX; // Object's collider box x coordinate
    public int thingOneY; // Object's collider box y coordinate
    public int thingTwoX; // 2nd Object's collider box x coordinate
    public int thingTwoY; // 2nd Object's collider box y coordinate

    public bool isCollide;

  public void checkCollision(int thingOneX, int thingOneY, int thingTwoX, int thingTwoY) //If both objects share a x and y value then they have collided
  {
    if (thingOneX == thingTwoX & thingOneY == thingTwoY)
        isCollide = true;
  }
}

