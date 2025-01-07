using static System.Net.Mime.MediaTypeNames;

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

    //fonction combats(a completer)
    public void TakeDamage(int damageReceived)
    {
        MonsterCurrentHP -= damageReceived;
    }
    //selection d'un objet ou de la vie au monster(a completer)
    //selection d'une attaque du monster(a completer)
    //fonction d'attaque du monster (a completer)


}
