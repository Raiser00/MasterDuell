namespace MasterDuell.Data;

public class Game
{
    public int GameId { get; set; } = 1;
    //param de base de jeu
    public Map GameMap { get; set; } = new Map();
    public Character Player { get; set; } = new Fighter { };
    public Monster MonsterFight { get; private set; } = new BeastWarrior { };

}
