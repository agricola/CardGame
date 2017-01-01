

namespace CardGame
{
    public class DamageEffect : CardEffect
    {
        private int damage;

        public DamageEffect(int damage, string des, TargetGroup targets)
        {
            this.damage = damage;
            this.Description = $"Deal {damage} damage to {targets}";
            this.PotentialTargets = targets;
        }
        
    }
}