using RpgConsoleGame;
var chop = "chop";
var woodCutting = "WoodCutting";
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


    while (chop == "chop")
    {
        Console.WriteLine("WoodCutting. Write 'chop' to level up the skill.");
        chop = Console.ReadLine();

        if ( chop == "chop") {
              p.AddXP(1);

            Console.WriteLine("______________");
            Console.WriteLine("Skill: " + p.Name);
            Console.WriteLine("Exp: " + p.XP);
            Console.WriteLine("______________");
            Console.WriteLine("");
            Console.WriteLine("1 exp. Keep going!");
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
p.AddXP(1);



Console.WriteLine("Cool");
