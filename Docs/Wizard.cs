using System;

namespace Wizard_Game
{
    public class Wizard
    {
    public string name;
    public string favoriteSpell;
    private int spellSlots;
    private double experience;
    private int healthPoints = 100;
        
    public static string[] NameList = new string[10] ;
    public static int Count = 0;
        
    public Wizard(string aName, string aFavoriteSpell)
    {
            name = aName;
            favoriteSpell = aFavoriteSpell;
            spellSlots = 2;
            experience = 0;
            
            NameList[Count] = name;
            Count++;
    }

        public void CastSpell()
    {
        if (healthPoints > 0)
        {
            if (spellSlots > 0 )
            {
                foreach (var item in NameList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("----------------------------------------");
                Console.Write("Specify what wizard from the list do you want to attack: ");

                string attackedWizard = Console.ReadLine();

                for (int i = 0; i < Count; i++)
                {
                     if (attackedWizard == NameList[i])
                {
                    if (name != attackedWizard)
                    {
                        Console.WriteLine(name + " casts " + favoriteSpell + " to " + attackedWizard );
                        Console.WriteLine(attackedWizard + " lost 30 hp");
                        healthPoints -= 30;
                        Console.WriteLine(healthPoints); 
                        spellSlots--;
                        experience += 0.3;
                        Console.WriteLine("----------------------------------------");
                        break;
                    } else 
                    {
                        Console.WriteLine("You can't cast a spell on yourself.");
                    }
                }       
                }                    
                
            } else
            {
                Console.WriteLine(name + " is out of spell slots, meditate to regain slots.");
            }

            if (healthPoints <= 0)
            {
                Console.WriteLine($"{name} is dead");

            }            
            } else
            {
                Console.WriteLine("A dead wizard can't cast a spell");
            }    
    }

    public void Meditate()
    {
        if (healthPoints <= 0)
        {
            Console.WriteLine("Dead Wizards can't meditate");
        }
        Console.WriteLine(name + " meditates to regain spell slots.");
        spellSlots = 2;
        healthPoints += 20; 
        if (healthPoints > 100)
        {
                    healthPoints = 100;
        }
    }
} 
}
