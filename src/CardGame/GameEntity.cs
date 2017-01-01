namespace CardGame
{
    public class GameEntity
    {
        public string Name
        {
            get;
            private set;
        }

        public GameEntity(string name = "GameEntity")
        {
            this.Name = name;
        }
    }
}