namespace MasterDuell.Data.Map
{
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
        }

    }
}
