namespace Queue.Joshua.DeBord
{
    internal class Player
    {
        public int Health { get; set; }

        public string GamerTag { get; set; }

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining game!");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()
        {

            return GamerTag;
        }
    }
}

