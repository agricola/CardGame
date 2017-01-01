using System;
using Xunit;
using System.Collections.Immutable;
using System.Collections.Generic;

namespace CardGame.Tests
{
    
    public class TargetGroupTests
    {
        private ImmutableList<ImmutableList<GameEntity>> targets;
        private ImmutableList<TargetGroup> groups;

        public TargetGroupTests()
        {
            GameEntity e0 = new GameEntity("e0");
            GameEntity e1 = new GameEntity("e1");
            GameEntity e2 = new GameEntity("e2");
            GameEntity e3 = new GameEntity("e3");
            targets = ImmutableList.Create<ImmutableList<GameEntity>>(
                ImmutableList.Create<GameEntity>(e0, e1),
                ImmutableList.Create<GameEntity>(e0, e1, e2),
                ImmutableList.Create<GameEntity>(e0, e1, e2, e3),
                ImmutableList.Create<GameEntity>(e0)
            );
            groups = ImmutableList.Create<TargetGroup>(
                new TargetGroup(targets[0]),
                new TargetGroup(targets[1]),
                new TargetGroup(targets[2]),
                new TargetGroup(targets[3])
            );
        }

        [Fact]
        public void TargetTextListsTargetsProperly()
        {
            string expected0 = "e0 and e1";
            string expected1 = "e0, e1 and e2";
            string expected2 = "e0, e1, e2 and e3";
            string expected3 = "e0";
            Assert.Equal(expected0, groups[0].TargetText());
            Assert.Equal(expected1, groups[1].TargetText());
            Assert.Equal(expected2, groups[2].TargetText());
            Assert.Equal(expected3, groups[3].TargetText());
        }

    }
}
