namespace MasterDuell.Data.Character
{
    public class Fighter : Character
    {
        //point de vie
        public override int MaxHitPoints { get; set; } = 30;
        public override int CurrentHitPoints { get; set; } = 30;
    }
}
