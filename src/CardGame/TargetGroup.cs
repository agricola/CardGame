using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CardGame
{
    public class TargetGroup
    {
        public ImmutableList<GameEntity> Targets
        {
            get;
            private set;
        }

        public TargetGroup(ImmutableList<GameEntity> targets)
        {
            this.Targets = targets;
        }

        public bool IsValidTarget(GameEntity target)
        {
            List<GameEntity> viableTargets = Targets
                .Where(t => target.GetType() == t.GetType())
                .ToList();

            return viableTargets.Count > 0;
        }

        public string TargetText()
        {
            List<string> names = Targets.Select(t => t.Name).ToList();
            int last = names.Count - 1;
            string result = names.Count == 1
            ? names[0]
            : String.Join(", ", names.GetRange(0, last)) + " and " + names[last];
            return result;
        }
    }
}