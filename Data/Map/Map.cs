using System.Collections.Specialized;

namespace MasterDuell.Data;

public class Map
{
    public Square[][] MapLayout { get; }
    //variable affichage de la map (a completer)
    public int StartI { get; set; }
    public int MaxI { get; set; }
    public int StartJ { get; set; }
    public int MaxJ { get; set; }

    public Map()
    {
        Plain = new Biomes(TypeOfBiome.Plain, PoolOfPlain, "img/biomes/plaine.png", img/Layout/fondFightPlaine.png");
        Plain1 = new Biomes(TypeOfBiome.Plain, PoolOfPlain, "img/biomes/plaine1.png", "img/layout/fondFightPlaine.png");
        Plain2 = new Biomes(TypeOfBiome.Plain, PoolOfPlain, "img/biomes/plaine2.png", "img/layout/fondFightPlaine.png");

        Forest = new Biomes(TypeOfBiome.Forest, PoolOfForest, "img/biomes/foret.png", "img/layout/fondFightBois.png");
        Forest1 = new Biomes(TypeOfBiome.Forest, PoolOfForest, "img/biomes/foret1.png", "img/layout/fondFightBois.png");
        Forest2 = new Biomes(TypeOfBiome.Forest, PoolOfForest, "img/biomes/foret2.png", "img/layout/fondFightBois.png");
        Forest3 = new Biomes(TypeOfBiome.ForestDifficult, PoolOfForest, "img/biomes/foret3.png", "img/layout/fondFightBois.png");
        BossForest = new Biomes(TypeOfBiome.ForestBoss, BossOfForest, "img/biomes/foretBoss.png", "img/layout/fondFightBossBois.png");

        Desert = new Biomes(TypeOfBiome.Desert, PoolOfDesert, "img/biomes/desert.png", "img/layout/fondFightDesert.png");
        Desert1 = new Biomes(TypeOfBiome.Desert, PoolOfDesert, "img/biomes/desert1.png", "img/layout/fondFightDesert.png");
        Desert2 = new Biomes(TypeOfBiome.Desert, PoolOfDesert, "img/biomes/desert2.png", "img/layout/fondFightDesert.png");
        Desert3 = new Biomes(TypeOfBiome.DesertDifficult, PoolOfDesert, "img/biomes/desert3.png", "img/layout/fondFightDesert.png");
        Desert4 = new Biomes(TypeOfBiome.DesertDifficult, PoolOfDesert, "img/biomes/desert4.png", "img/layout/fondFightDesert.png");
        Desert5 = new Biomes(TypeOfBiome.DesertDifficult, PoolOfDesert, "img/biomes/desert5.png", "img/layout/fondFightDesert.png");
        BossDesert = new Biomes(TypeOfBiome.DesertBoss, BossOfDesert, "img/biomes/desertBoss.png", "img/layout/fondFightBossDesert.png");

        RuinedVillage = new Biomes(TypeOfBiome.AbandonedVillage, PoolOfRuined, "img/biomes/ruine.png", "img/layout/fondFightRuine.png");
        RuinedVillage1 = new Biomes(TypeOfBiome.AbandonedVillage, PoolOfRuined, "img/biomes/ruine1.png", "img/layout/fondFightRuine.png");
        RuinedVillage2 = new Biomes(TypeOfBiome.AbandonedVillage, PoolOfRuined, "img/biomes/ruine2.png", "img/layout/fondFightRuine.png");
        RuinedVillage3 = new Biomes(TypeOfBiome.AbandonedVillageDifficult, PoolOfRuined, "img/biomes/ruine3.png", "img/layout/fondFightRuine.png");
        BossRuinedVillage = new Biomes(TypeOfBiome.AbandonedVillageBoss, BossOfRuined, "img/biomes/ruineBoss.png", "img/layout/fondFightBossRuine.png");

        Graveyard = new Biomes(TypeOfBiome.Graveyard, PoolOfGraveyard, "img/biomes/cimetiere.png", "img/layout/fondFightCimetiere.png");
        Graveyard1 = new Biomes(TypeOfBiome.Graveyard, PoolOfGraveyard, "img/biomes/cimetiere1.png", "img/layout/fondFightCimetiere.png");
        Graveyard2 = new Biomes(TypeOfBiome.Graveyard, PoolOfGraveyard, "img/biomes/cimetiere2.png", "img/layout/fondFightCimetiere.png");
        Graveyard3 = new Biomes(TypeOfBiome.GraveyardDifficult, PoolOfGraveyard, "img/biomes/cimetiere3.png", "img/layout/fondFightCimetiere.png");
        BossGraveyard = new Biomes(TypeOfBiome.GraveyardBoss, BossOfGraveyard, "img/biomes/cimetiereBoss.png", "img/layout/fondFightBossCimetiere.png");

        Village = new Biomes(TypeOfBiome.Village, PoolOfVillage, "img/biomes/village.png", "img/layout/fondFightBossVillage.png");
        Village2 = new Biomes(TypeOfBiome.Village, PoolOfVillage, "img/biomes/village2.png", "img/layout/fondFightBossVillage.png");
        Village3 = new Biomes(TypeOfBiome.Village, PoolOfVillage, "img/biomes/village3.png", "img/layout/fondFightBossVillage.png");
        Village4 = new Biomes(TypeOfBiome.Village, PoolOfVillage, "img/biomes/village4.png", "img/layout/fondFightBossVillage.png");
        BossVillage = new Biomes(TypeOfBiome.VillageBoss, BossOfVillage, "img/biomes/villageBoss.png", "img/layout/fondFightBossVillage.png");

        MapLayout = CreateMapLayout();
    }

    //fonction qui va changer les valerus de la map en fonction de la position du joueur
    public void UpdateMapDisplay(Character player)
    {
        StartI = player.PositionI - 4;
        MaxI = player.PositionI + 5;
        StartJ = player.PositionJ - 4;
        MaxJ = player.PositionJ + 5;
        if (StartI < 0) { StartI = 0; }
        if (StartJ < 0) { StartJ = 0; }
        if (MaxI > 500) { MaxI = 500; }
        if (MaxJ > 500) { MaxJ = 500; }
    }
    //fonction pour ajuster le pool de monster en cas de level up de la map

    //fonction pour creer la map, contenu, pool de monster

    //plaine
    public List<Monster> PoolOfPlain { get; private set; } = new List<Monster> { new };
}
