namespace MasterDuell.Data;

public abstract class Monster
{
    public abstract string MonsterName { get; set; }
    //param des points de vio
    public abstract int MonsterHP { get; set; }
    public abstract int MonsterCurrentHP { get; set; }
    //param de combat (a completer)
    public MonsterHit? MonsterHit { get; set; }
    public abstract MonsterHit[] HitTable { get; set; }
}
