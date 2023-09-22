namespace Queue.Joshua.DeBord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game MyGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "Joshua");
            Player p2 = new Player(100, "Biggamerdog123123");
            Player p3 = new Player(100, "DiamondMiner222");
            Player p4 = new Player(100, "ZombieKiller420");

            p1.JoinGame(MyGame, waitingToJoinQ);
            p2.JoinGame(MyGame, waitingToJoinQ);
            p3.JoinGame(MyGame, waitingToJoinQ);
            p4.JoinGame(MyGame, waitingToJoinQ);

            Console.WriteLine("Players: ");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
                MyGame.KickPlayer();
                MyGame.CheckQueue(waitingToJoinQ);

            Console.WriteLine("\nPlayers in the queue:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}