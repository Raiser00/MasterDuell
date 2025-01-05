using System.Globalization;

namespace MasterDuell.Data;

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
}

