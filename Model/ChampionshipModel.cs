namespace Model
{
    public class ChampionshipModel
    {
        public int Id { get; set; }
        public string? CommandName { get; set; }
        public string? TeamCity { get; set; }
        public int NumberOfVictories { get; set; }
        public int NumberOfLesions { get; set; }
        public int NumberOfDraws { get; set; }
    }
}
