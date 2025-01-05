using System.Globalization;

namespace MasterDuell.Data.Character;

public abstract class Character
{
    public string Name { get; set; }
    //Parametre de gestion de niveau
    private int level = 1;
    public int Level
    {
        get { return level; }
        set
        {
            if (level! > value)
            {
                level = value;
            }
        }
    }
    public int CurrentXp { get; set; } = 0;
    public int XpToNextLevel { get; set; } = 100;
    //Parametre de gestion de vie
    public abstract int MaxHitPoints { get; set; }
    public abstract int CurrentHitPoints { get; set; }
    //Parametre de gestion d'objets
    public int Coins { get; private set; } = 10;
    // param a completer
    public string MapSprite { get; set; }
    public int CollectPosI = 0;
    public int CollectPosJ = 5;
    public int PositionI { get; set; } = 250;
    public int PositionJ { get; set; } = 250;
    //Param de gestion de repos et en cas de défaite
    public bool IsRested { get; private set; } = true;
    public int lastRestVillageI { get; set; } = 250;
    public int lastRestVillageJ { get; set; } = 250;
    //param de gestion de stats (a completer)
    //param de gestion d'etat (a complter)
    //param de gestion d'aavancement des quetes (a completer)


    //constructeur a definir  pour les quetes du jeu 
    //param de gestion d'etat (a completer)
    //fonction de repos au village qui va remettre les points de vie a leur maximum (a completer)
    public void Rest()
    {
        CurrentHitPoints = MaxHitPoints;
        IsRested = true;
    }
}

