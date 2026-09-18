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
        public int AddXP(int amount)
        {
            XP += amount;
            return XP;
        }
    }
}
