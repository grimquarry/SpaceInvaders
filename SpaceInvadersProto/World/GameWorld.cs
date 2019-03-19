using SpaceInvadersProto.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvadersProto.World
{
    public class GameWorld
    {
        public GameWorld()
        {
            GameEntities = new List<GameEntity>();
            GameTimer = new Stopwatch();
        }

        public List<GameEntity> GameEntities { get; }
        public Stopwatch GameTimer { get; }
        private TimeSpan previousGameTick;


        public void AddEntity(GameEntity entity)
        {
            GameEntities.Add(entity);
        }

        public float EllapsedMillisecondsSinceLastTick
        {
            get
            {
                return (float)(GameTimer.Elapsed - previousGameTick).TotalMilliseconds;
            }
        }

        public void GameTick()
        {
            foreach (var entity in GameEntities)
                entity.GameTick(EllapsedMillisecondsSinceLastTick);

            previousGameTick = GameTimer.Elapsed;
        }
    }
}
