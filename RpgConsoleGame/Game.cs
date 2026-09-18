using RpgConsoleGame;
Dictionary <string, Skill > typeOfSkills = new();
var woodCutting = "WoodCutting";

typeOfSkills.Add("WoodCutting", new Skill("WoodCutting", 0));
typeOfSkills.Add("Mining", new Skill("Mining", 0));
foreach(var n in typeOfSkills)
{
    Console.WriteLine(n.Key + " lvl " + n.Value.Level);
}

var chosenSkill = chooseSkill();


string chooseSkill()
{
    var userName = "";

    while (userName != woodCutting) {
        Console.WriteLine("Which skill are you going to train? ");
        userName = Console.ReadLine();
        if (userName != woodCutting)
        {
            Console.WriteLine("No. A skill! Try again!");
        } 

    } return userName;
}

void trainingSkill(Skill p)
{
    var chop = "chop";
    Console.Clear();

    while (chop == "chop")
    {
        
        Console.WriteLine("WoodCutting. Write 'chop' to level up the skill.");
        chop = Console.ReadLine();
        
        
        if ( chop == "chop") {
            Console.Clear();
            int previousLevel = p.Level;
            int woodCuttingBaseEXP = 50;
            p.AddXP(woodCuttingBaseEXP);
            int currentLevel = p.Level;
            Console.WriteLine("");
            Console.WriteLine("______________");
            Console.WriteLine("WoodCutting skill Level: " + currentLevel);
            Console.WriteLine("Skill: " + p.Name);
            Console.WriteLine("Exp: " + p.XP);
            Console.WriteLine("______________");
            Console.WriteLine("");
            if (previousLevel != currentLevel)
            {
                Console.WriteLine("Level up!");
                Console.WriteLine("You leveled up " + previousLevel + " --> " + currentLevel);

            }
            Console.WriteLine(woodCuttingBaseEXP + " exp. Keep going!");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Ok stopped.");
        }

    }
}


var p = new Skill(chosenSkill, 0);
trainingSkill(p);
Console.WriteLine("______________");
Console.WriteLine("WoodCutting skill Level: " + p.Level);
Console.WriteLine("Skill: " + p.Name);
Console.WriteLine("Exp: " + p.XP);
Console.WriteLine("______________");

Console.WriteLine("Cool");
