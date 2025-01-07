namespace MasterDuell.Data;

public class GuerrierCastor
{
    public override string MonsterName { get; set; } = "Guerrier Castor";
    public override int MonsterHP { get; set; } = 1500;
    public override int MonsterCurrentHP { get; set; } = 1500;
    public override string fightImgUrl { get; set; } = "img/monsters/BeastWarrior/guerrierCastor.png";
    public override int XpGranted { get; set; } = 100;

    //possible loot d'objet

    protected override MonsterHit[] BuildHitTable()
    {
        return new MonsterHit[]
        {
            new MonsterHit{ Name = "Coup d'épée Castor", Damage = 1200 }
            };
    }
}
