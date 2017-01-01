using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public abstract class CardEffect
    {
        public string Description
        {
            get;
            protected set;
        }

        public TargetGroup PotentialTargets
        {
            get;
            protected set;
        }

        protected Action<GameEntity, GameEntity> Effect
        {
            get;
            set;
        }
        
        public void Applyffect(GameEntity source, GameEntity target)
        {
            if (PotentialTargets.IsValidTarget(target))
            {
                Effect(source, target);
            }
        }
    }
}