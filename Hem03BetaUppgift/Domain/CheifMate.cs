using System;
using System.Collections.Generic;
using System.Text;

namespace Hem03BetaUppgift.Domain
{
    class CheifMate : Person
    {
        public CheifMate(string firstName, string lastName, string favoritColor, string rank) : base (firstName, lastName, favoritColor, rank)
        {
            
        }

        public void Turning()
        {
            Console.WriteLine("The ship is turning");
        }
    }
}
