namespace MasterDuell.Data;

public abstract class BeastWarrior : Monster
{
    public override TypeOfMonster MonsterType { get; set; } = TypeOfMonster.BeastWarrior;
}
