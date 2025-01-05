namespace MasterDuell.Data.Map;
public class Square //(a completer)
{
    public Biomes SquareBiome { get; set; }
    public string Name { get; set; }
    public double ChanceToTriggerFight { get; set; }
    public bool HasQuestTarget { get; set; } = false;
}
