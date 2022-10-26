namespace Quizz
{
    public class Player //Un joueur
    {
        public int id { get; set; }
        public string name { get; set; }
        public string passwd { get; set; }
        public int lvl { get; set; }
        public string score { get; set; }
    }
    public class Players //Liste de joueur
    {
        public List<Player> players { get; set; }
    }
}