using System;
using System.Threading;

namespace Wizard_Game
{
    class WizardGame
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("El Hechicero", "Abracadabra");
            Wizard wizard02 = new Wizard("Shazam", "Alakazam");

            wizard01.CastSpell();
            wizard02.CastSpell();

            wizard01.Meditate();
            wizard02.Meditate();

            Console.ReadLine();
        }

    }
    
}
