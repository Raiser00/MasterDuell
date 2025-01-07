namespace MasterDuell.Data
{
    public class Game
    {
        //param de base de jeu
        public Map GameMap { get; set } = new Map();
        public Character Player { get; set; } = new Fighter { };
        public Monster MonsterFight { get; private set; } new 
    }
}
