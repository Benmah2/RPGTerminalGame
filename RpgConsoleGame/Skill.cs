namespace RpgConsoleGame
{
    public class Skill
    {
        public string Name { get; private set; }

        public int XP { get; private set; }

        public Skill(string name, int xp)
        {
            Name = name;
            XP = xp;
        }
        public void AddXP(int amount)
        {
            XP += amount;
        }
        public int Level
        {
           
            get { return XP / 100 + 1; }

        }
    }
}
