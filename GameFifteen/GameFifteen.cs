namespace GameFifteen
{
    using System;
    
    /// <summary>
    /// Class, containing the main method for running the game.
    /// </summary>
    public class GameFifteen
    {
        /// <summary>
        /// Main method. triggers the GameEngine class.
        /// </summary>
        static void Main()
        {
            GameEngine game = new GameEngine();
            game.PlayGame();
        }
    }
}
