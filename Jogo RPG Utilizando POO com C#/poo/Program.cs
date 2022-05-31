using poo.src.Entities;

Knight Arus = new Knight("Arus", 23, "knight", 530, 200);
Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 300, 450);
BlackWizard blackWizard = new BlackWizard("Malévolo", 23, "Black Wizard", 350, 400);
Ninja ninja = new Ninja("Naruto", 23, "Ninja", 200, 400);


Console.WriteLine(Arus.Attack());
Console.WriteLine(wizard.Attack(7));
Console.WriteLine(blackWizard.Attack());
Console.WriteLine(ninja.Attack());