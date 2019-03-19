using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SpaceInvadersProto.Entities
{
    //All game entity classes will inherit from the GameEntity class
    public abstract class GameEntity
    {
        //Location of the game entity object
        public Vector2 Position { get; set; }
        //Movement speed of the game entity object in pixels per second
        public Vector2 Velocity { get; set; }

        //Part of the game logic
        //millisecondsElapsed indicates how much time has passes since this method was last called
        public virtual void GameTick(float millisecondsElapsed)
        {

        }

        //Method the game entity object uses to draw itself to the screen
        public virtual void Draw(WriteableBitmap surface)
        {

        }
    }
}
